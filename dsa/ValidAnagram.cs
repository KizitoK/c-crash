namespace Giraffe
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            var dict = new Dictionary<Char, int>();
            if (s.Length != t.Length)
                return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                    dict[s[i]] += 1;
                else
                    dict.Add(s[i], 1);
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dict.ContainsKey(t[i]))
                    dict[t[i]] -= 1;
                else
                    return false;
            }
            if (dict.Values.All(x => x == 0))
                return true;
            else
                return false;
        }
    }
}