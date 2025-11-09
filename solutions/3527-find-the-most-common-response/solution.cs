public class Solution
{
    public string FindCommonResponse(IList<IList<string>> responses)
    {
        var frequency = new Dictionary<string, int>();

        foreach (var dayResponses in responses)
        {
            var seenToday = new HashSet<string>(dayResponses); // Remove duplicates for the day

            foreach (var response in seenToday)
            {
                if (!frequency.ContainsKey(response))
                {
                    frequency[response] = 0;
                }
                frequency[response]++;
            }
        }

        string result = null;
        int maxCount = 0;

        foreach (var pair in frequency)
        {
            string response = pair.Key;
            int count = pair.Value;

            if (count > maxCount || (count == maxCount && string.Compare(response, result) < 0))
            {
                maxCount = count;
                result = response;
            }
        }

        return result;
    }
}