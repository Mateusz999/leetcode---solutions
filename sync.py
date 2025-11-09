import os
import requests

LEETCODE_USERNAME = "MvB_Coder"
LEETCODE_SESSION = os.environ.get("LEETCODE_SESSION") or "TWOJ_SESSION"
LEETCODE_CSRF = os.environ.get("LEETCODE_CSRF") or "TWOJ_CSRF"

HEADERS = {
    "User-Agent": "Mozilla/5.0",
    "Referer": "https://leetcode.com",
    "Cookie": f"LEETCODE_SESSION={LEETCODE_SESSION}; csrftoken={LEETCODE_CSRF}",
    "x-csrftoken": LEETCODE_CSRF,
}

EXTENSIONS = {
    "cpp": "cpp", "rust": "rs", "csharp": "cs", "java": "java",
    "javascript": "js", "sql": "sql", "python": "py", "typescript": "ts",
    "go": "go", "ruby": "rb", "php": "php", "c": "c", "swift": "swift", "kotlin": "kt"
}

def get_accepted_problems():
    url = "https://leetcode.com/api/problems/all/"
    try:
        r = requests.get(url, headers=HEADERS)
        r.raise_for_status()
        data = r.json()
        return [
            {
                "title": q["stat"]["question__title"],
                "slug": q["stat"]["question__title_slug"],
                "difficulty": q["difficulty"]["level"],
                "frontend_id": q["stat"]["frontend_question_id"]
            }
            for q in data["stat_status_pairs"]
            if q.get("status") == "ac"
        ]
    except Exception as e:
        print("❌ Błąd pobierania zadań:", e)
        return []

def get_latest_accepted_submission(slug):
    query = '''
    query submissionList($questionSlug: String!, $offset: Int!, $limit: Int!) {
      submissionList(questionSlug: $questionSlug, offset: $offset, limit: $limit) {
        submissions { id lang statusDisplay timestamp }
      }
    }
    '''
    vars_ = {"questionSlug": slug, "offset": 0, "limit": 50}
    try:
        r = requests.post("https://leetcode.com/graphql", headers=HEADERS,
                          json={"query": query, "variables": vars_})
        r.raise_for_status()
        data = r.json()
        subs = data.get("data", {}).get("submissionList", {}).get("submissions", [])
        accepted = [s for s in subs if s.get("statusDisplay") == "Accepted"]
        if not accepted:
            return None, None
        accepted.sort(key=lambda s: int(s["timestamp"]), reverse=True)
        return accepted[0]["id"], accepted[0]["lang"]
    except Exception as e:
        print(f"❌ Błąd pobierania submissions dla {slug}:", e)
        return None, None

def get_submission_code(submission_id):
    query = '''
    query submissionDetails($submissionId: Int!) {
      submissionDetails(submissionId: $submissionId) {
        code
        lang { name }
      }
    }
    '''
    try:
        r = requests.post("https://leetcode.com/graphql", headers=HEADERS,
                          json={"query": query, "variables": {"submissionId": submission_id}})
        r.raise_for_status()
        data = r.json()
        if "errors" in data:
            print("❌ GraphQL errors:", data["errors"])
            return None, None
        det = data.get("data", {}).get("submissionDetails")
        if not det:
            print(f"❌ Brak danych submissionDetails dla ID: {submission_id}")
            return None, None
        code = det.get("code")
        lang_node = det.get("lang")
        lang = lang_node.get("name") if isinstance(lang_node, dict) else lang_node
        return code, lang
    except Exception as e:
        print(f"❌ Błąd pobierania kodu dla submission {submission_id}:", e)
        return None, None

def save_solution(problem):
    sub_id, lang = get_latest_accepted_submission(problem["slug"])
    if not sub_id:
        return None, None

    code, lang2 = get_submission_code(sub_id)
    if not code:
        print(f"❌ Brak kodu dla zadania: {problem['slug']}")
        return None, None

    lang = (lang2 or lang or "unknown").lower()
    ext = EXTENSIONS.get(lang, "txt")

    folder = f"solutions/{problem['frontend_id']:04d}-{problem['slug']}"
    os.makedirs(folder, exist_ok=True)
    file_path = f"{folder}/solution.{ext}"
    try:
        with open(file_path, "w", encoding="utf-8") as f:
            f.write(code)
        return file_path, lang
    except Exception as e:
        print(f"❌ Błąd zapisu pliku dla {problem['slug']}:", e)
        return None, None

def generate_readme(problems, entries):
    rows = []
    for p, entry in zip(sorted(problems, key=lambda x: int(x["frontend_id"])), entries):
        if not entry or not entry[0]:
            continue
        title = p["title"]
        link = f"https://leetcode.com/problems/{p['slug']}/"
        difficulty = ["Easy", "Medium", "Hard"][p["difficulty"] - 1]
        file_path, lang = entry
        rows.append(
            f"| {p['frontend_id']} | [{title}]({link}) | {difficulty} | {lang} | "
            f"[{os.path.basename(file_path)}]({file_path}) |"
        )
    content = f"""# 🧠 LeetCode Solutions by {LEETCODE_USERNAME}

Automatycznie pobrane rozwiązania z mojego konta LeetCode.

## 📊 Lista zadań

| ID | Nazwa | Trudność | Język | Rozwiązanie |
|----|-------|----------|--------|-------------|
{chr(10).join(rows)}
"""
    try:
        with open("README.md", "w", encoding="utf-8") as f:
            f.write(content)
    except Exception as e:
        print("❌ Błąd zapisu README.md:", e)

def main():
    problems = get_accepted_problems()
    if not problems:
        print("❌ Brak zadań do przetworzenia.")
        return
    entries = [save_solution(p) for p in problems]
    generate_readme(problems, entries)

if __name__ == "__main__":
    main()
