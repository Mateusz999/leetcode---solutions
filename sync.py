import os
import requests

LEETCODE_USERNAME = "MvB_Coder"  # ← Zmień na swój login LeetCode

LEETCODE_SESSION = os.environ.get("LEETCODE_SESSION")
LEETCODE_CSRF = os.environ.get("LEETCODE_CSRF")

HEADERS = {
    "User-Agent": "Mozilla/5.0",
    "Referer": "https://leetcode.com",
    "Cookie": f"LEETCODE_SESSION={LEETCODE_SESSION}; csrftoken={LEETCODE_CSRF}",
    "x-csrftoken": LEETCODE_CSRF,
}

EXTENSIONS = {
    "Python3": "py",
    "Java": "java",
    "C++": "cpp",
    "C": "c",
    "C#": "cs",
    "JavaScript": "js",
    "TypeScript": "ts",
    "Go": "go",
    "Rust": "rs",
    "Kotlin": "kt",
    "Swift": "swift",
    "Ruby": "rb",
    "PHP": "php"
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

def get_solution_code(slug):
    query = '''
    query questionEditorData($titleSlug: String!) {
      question(titleSlug: $titleSlug) {
        codeSnippets {
          lang
          code
        }
      }
    }
    '''
    variables = {"titleSlug": slug}
    response = requests.post(
        "https://leetcode.com/graphql",
        headers=HEADERS,
        json={"query": query, "variables": variables}
    )
    snippets = response.json()["data"]["question"]["codeSnippets"]
    for snippet in snippets:
        if snippet["lang"] == "Python3":  # Prefer Python3
            return snippet["code"], snippet["lang"]
    # Fallback to first available
    if snippets:
        return snippets[0]["code"], snippets[0]["lang"]
    return "# Brak kodu", "Unknown"

def save_solution(problem):
    code, lang = get_solution_code(problem["slug"])
    ext = EXTENSIONS.get(lang, "txt")
    folder_name = f"solutions/{problem['frontend_id']:04d}-{problem['slug']}"
    os.makedirs(folder_name, exist_ok=True)
    file_path = f"{folder_name}/solution.{ext}"
    with open(file_path, "w", encoding="utf-8") as f:
        f.write(code)
    return file_path, lang

def generate_readme(problems, entries):
    rows = []
    for p, entry in zip(sorted(problems, key=lambda x: int(x["frontend_id"])), entries):
        title = p["title"]
        link = f"https://leetcode.com/problems/{p['slug']}/"
        difficulty = ["Easy", "Medium", "Hard"][p["difficulty"] - 1]
        file_path, lang = entry
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
