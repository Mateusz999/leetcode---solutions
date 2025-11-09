import os
import requests

LEETCODE_USERNAME = "MvB_Coder"

LEETCODE_SESSION = os.environ.get("LEETCODE_SESSION") or "TWOJ_LEETCODE_SESSION"
LEETCODE_CSRF = os.environ.get("LEETCODE_CSRF") or "TWOJ_CSRF_TOKEN"

HEADERS = {
    "User-Agent": "Mozilla/5.0",
    "Referer": "https://leetcode.com",
    "Cookie": f"LEETCODE_SESSION={LEETCODE_SESSION}; csrftoken={LEETCODE_CSRF}",
    "x-csrftoken": LEETCODE_CSRF,
}

EXTENSIONS = {
    "python3": "py", "java": "java", "cpp": "cpp", "c": "c", "csharp": "cs",
    "javascript": "js", "typescript": "ts", "golang": "go", "rust": "rs",
    "kotlin": "kt", "swift": "swift", "ruby": "rb", "php": "php"
}

def get_accepted_problems():
    url = "https://leetcode.com/api/problems/all/"
    r = requests.get(url, headers=HEADERS)
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

def get_all_submissions(slug):
    """Pobierz wszystkie submissions dla problemu (paginacja)."""
    all_subs, offset, limit = [], 0, 50
    while True:
        query = '''
        query submissionList($questionSlug: String!, $offset: Int!, $limit: Int!) {
          submissionList(questionSlug: $questionSlug, offset: $offset, limit: $limit) {
            submissions { id lang statusDisplay timestamp }
          }
        }
        '''
        vars_ = {"questionSlug": slug, "offset": offset, "limit": limit}
        r = requests.post("https://leetcode.com/graphql", headers=HEADERS,
                          json={"query": query, "variables": vars_})
        data = r.json()
        subs = data.get("data", {}).get("submissionList", {}).get("submissions", [])
        if not subs:
            break
        all_subs.extend(subs)
        offset += limit
    return all_subs

def get_latest_accepted_submission(slug):
    subs = get_all_submissions(slug)
    accepted = [s for s in subs if s.get("statusDisplay") == "Accepted"]
    if not accepted:
        return None, None
    accepted.sort(key=lambda s: int(s["timestamp"]), reverse=True)
    return accepted[0]["id"], accepted[0]["lang"]

def get_submission_code(submission_id):
    query = '''
    query submissionDetails($submissionId: Int!) {
      submissionDetails(submissionId: $submissionId) { code lang }
    }
    '''
    r = requests.post("https://leetcode.com/graphql", headers=HEADERS,
                      json={"query": query, "variables": {"submissionId": submission_id}})
    data = r.json()
    det = data.get("data", {}).get("submissionDetails", {})
    return det.get("code"), det.get("lang")

def save_solution(problem):
    sub_id, lang = get_latest_accepted_submission(problem["slug"])
    if not sub_id:
        return None, None
    code, lang2 = get_submission_code(sub_id)
    # preferuj lang2 z details, jeśli istnieje
    lang = lang2 or lang or "Unknown"
    # bezpieczne rozszerzenie
    ext = EXTENSIONS.get(lang.lower(), "txt") if isinstance(lang, str) else "txt"

    folder = f"solutions/{problem['frontend_id']:04d}-{problem['slug']}"
    os.makedirs(folder, exist_ok=True)
    file_path = f"{folder}/solution.{ext}"
    with open(file_path, "w", encoding="utf-8") as f:
        f.write(code if code else "# Brak kodu\n")
    return file_path, lang

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

Automatycznie synchronizowane rozwiązania z mojego profilu LeetCode.

## 📊 Lista zadań

| ID | Nazwa | Trudność | Język | Rozwiązanie |
|----|-------|----------|--------|-------------|
{chr(10).join(rows)}
"""
    with open("README.md", "w", encoding="utf-8") as f:
        f.write(content)

def main():
    problems = get_accepted_problems()
    entries = [save_solution(p) for p in problems]
    generate_readme(problems, entries)

if __name__ == "__main__":
    main()
