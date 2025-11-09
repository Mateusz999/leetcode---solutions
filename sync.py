import os
import requests

LEETCODE_USERNAME = "MvB_Coder"  # ← Twój login LeetCode

LEETCODE_SESSION = os.environ.get("LEETCODE_SESSION")
LEETCODE_CSRF = os.environ.get("LEETCODE_CSRF")

HEADERS = {
    "User-Agent": "Mozilla/5.0",
    "Referer": "https://leetcode.com",
    "Cookie": f"LEETCODE_SESSION={LEETCODE_SESSION}; csrftoken={LEETCODE_CSRF}",
    "x-csrftoken": LEETCODE_CSRF,
}

EXTENSIONS = {
    "python3": "py",
    "java": "java",
    "cpp": "cpp",
    "c": "c",
    "csharp": "cs",
    "javascript": "js",
    "typescript": "ts",
    "golang": "go",
    "rust": "rs",
    "kotlin": "kt",
    "swift": "swift",
    "ruby": "rb",
    "php": "php"
}

def get_accepted_problems():
    url = "https://leetcode.com/api/problems/all/"
    response = requests.get(url, headers=HEADERS)
    data = response.json()
    accepted = [
        {
            "title": q["stat"]["question__title"],
            "slug": q["stat"]["question__title_slug"],
            "difficulty": q["difficulty"]["level"],
            "frontend_id": q["stat"]["frontend_question_id"]
        }
        for q in data["stat_status_pairs"]
        if q.get("status") == "ac"
    ]
    return accepted

def get_latest_accepted_submission(slug):
    query = '''
    query submissionList($titleSlug: String!, $offset: Int!, $limit: Int!) {
      submissionList(titleSlug: $titleSlug, offset: $offset, limit: $limit) {
        submissions {
          id
          lang
          statusDisplay
          timestamp
        }
      }
    }
    '''
    variables = {"titleSlug": slug, "offset": 0, "limit": 20}
    response = requests.post(
        "https://leetcode.com/graphql",
        headers=HEADERS,
        json={"query": query, "variables": variables}
    )

    data = response.json()

    if "errors" in data:
        print(f"❌ GraphQL error for {slug}: {data['errors']}")
        return None, None
    if "data" not in data or not data["data"].get("submissionList"):
        print(f"❌ No data returned for {slug}. Response: {data}")
        return None, None

    submissions = data["data"]["submissionList"]["submissions"]
    for sub in submissions:
        if sub["statusDisplay"] == "Accepted":
            return sub["id"], sub["lang"]
    return None, None

def get_submission_code(submission_id):
    query = '''
    query submissionDetails($submissionId: Int!) {
      submissionDetails(submissionId: $submissionId) {
        code
        lang
      }
    }
    '''
    variables = {"submissionId": submission_id}
    response = requests.post(
        "https://leetcode.com/graphql",
        headers=HEADERS,
        json={"query": query, "variables": variables}
    )

    data = response.json()

    if "errors" in data:
        print(f"❌ Error fetching submission {submission_id}: {data['errors']}")
        return "# Error", "Unknown"
    if "data" not in data or not data["data"].get("submissionDetails"):
        print(f"❌ No submission details for {submission_id}. Response: {data}")
        return "# Error", "Unknown"

    details = data["data"]["submissionDetails"]
    return details["code"], details["lang"]

def save_solution(problem):
    submission_id, lang = get_latest_accepted_submission(problem["slug"])
    folder_name = f"solutions/{problem['frontend_id']:04d}-{problem['slug']}"
    os.makedirs(folder_name, exist_ok=True)

    if not submission_id:
        # Zapisz pusty plik, żeby katalog zawsze powstał
        file_path = f"{folder_name}/solution.txt"
        with open(file_path, "w", encoding="utf-8") as f:
            f.write("# Brak zaakceptowanego rozwiązania lub sesja wygasła\n")
        return file_path, "Unknown"

    code, lang = get_submission_code(submission_id)
    ext = EXTENSIONS.get(lang.lower(), "txt")
    file_path = f"{folder_name}/solution.{ext}"
    with open(file_path, "w", encoding="utf-8") as f:
        f.write(code if code else "# Brak kodu\n")
    return file_path, lang

def generate_readme(problems, entries):
    rows = []
    for p, entry in zip(sorted(problems, key=lambda x: int(x["frontend_id"])), entries):
        file_path, lang = entry
        title = p["title"]
        link = f"https://leetcode.com/problems/{p['slug']}/"
        difficulty = ["Easy", "Medium", "Hard"][p["difficulty"] - 1]
        rows.append(f"| {p['frontend_id']} | [{title}]({link}) | {difficulty} | {lang} | [{os.path.basename(file_path)}]({file_path}) |")

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
