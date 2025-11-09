import requests

def get_user_stats(username):
    query = '''
    query getUserProfile($username: String!) {
      matchedUser(username: $username) {
        username
        submitStats {
          acSubmissionNum {
            difficulty
            count
          }
        }
      }
    }
    '''
    variables = {"username": username}
    response = requests.post(
        "https://leetcode.com/graphql",
        json={"query": query, "variables": variables}
    )
    data = response.json()
    return data

def generate_readme(stats):
    user = stats["data"]["matchedUser"]["username"]
    submissions = stats["data"]["matchedUser"]["submitStats"]["acSubmissionNum"]

    easy = next((x["count"] for x in submissions if x["difficulty"] == "Easy"), 0)
    medium = next((x["count"] for x in submissions if x["difficulty"] == "Medium"), 0)
    hard = next((x["count"] for x in submissions if x["difficulty"] == "Hard"), 0)
    total = easy + medium + hard

    content = f"""# 🧠 LeetCode Solutions by {user}

Automatycznie synchronizowane rozwiązania z mojego profilu LeetCode.

## 📊 Statystyki

- 🔢 Rozwiązane zadań: {total}
- 🧩 Łatwe: {easy}
- ⚙️ Średnie: {medium}
- 🔥 Trudne: {hard}

## 🔗 Profil LeetCode

[{user} na LeetCode](https://leetcode.com/{user})
"""

    with open("README.md", "w", encoding="utf-8") as f:
        f.write(content)

# 🧪 Uruchomienie
stats = get_user_stats("MvB_Coder")
generate_readme(stats)
print("README.md wygenerowany!")
