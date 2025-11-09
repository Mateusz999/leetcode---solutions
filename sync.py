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

def get_first_accepted_nonpaid_slug():
    url = "https://leetcode.com/api/problems/all/"
    r = requests.get(url, headers=HEADERS)
    data = r.json()
    for q in data["stat_status_pairs"]:
        if q.get("status") == "ac" and not q.get("paid_only", False):
            return q["stat"]["question__title_slug"], q["stat"]["frontend_question_id"]
    return None, None

def get_first_accepted_submission(slug):
    query = '''
    query submissionList($questionSlug: String!, $offset: Int!, $limit: Int!) {
      submissionList(questionSlug: $questionSlug, offset: $offset, limit: $limit) {
        submissions { id lang statusDisplay timestamp }
      }
    }
    '''
    vars_ = {"questionSlug": slug, "offset": 0, "limit": 50}
    r = requests.post("https://leetcode.com/graphql", headers=HEADERS,
                      json={"query": query, "variables": vars_})
    subs = r.json().get("data", {}).get("submissionList", {}).get("submissions", [])
    for sub in subs:
        if sub["statusDisplay"] == "Accepted":
            return sub["id"], sub["lang"]
    return None, None

def get_submission_code(submission_id):
    query = '''
    query submissionDetails($submissionId: Int!) {
      submissionDetails(submissionId: $submissionId) { code lang }
    }
    '''
    r = requests.post("https://leetcode.com/graphql", headers=HEADERS,
                      json={"query": query, "variables": {"submissionId": submission_id}})
    det = r.json().get("data", {}).get("submissionDetails", {})
    return det.get("code"), det.get("lang")

def save_to_file(code, lang, slug, frontend_id):
    lang = lang or "Unknown"
    ext = EXTENSIONS.get(lang.lower(), "txt") if isinstance(lang, str) else "txt"
    folder = f"solutions/{frontend_id:04d}-{slug}"
    os.makedirs(folder, exist_ok=True)
    file_path = f"{folder}/solution.{ext}"
    with open(file_path, "w", encoding="utf-8") as f:
        f.write(code if code else "# Brak kodu\n")
    print(f"✅ Zapisano: {file_path}")

def main():
    slug, frontend_id = get_first_accepted_nonpaid_slug()
    if not slug:
        print("❌ Nie znaleziono zaakceptowanych zadań.")
        return
    sub_id, lang = get_first_accepted_submission(slug)
    if not sub_id:
        print("❌ Brak Accepted submission.")
        return
    code, lang2 = get_submission_code(sub_id)
    final_lang = lang2 or lang or "Unknown"
    save_to_file(code, final_lang, slug, frontend_id)

if __name__ == "__main__":
    main()
