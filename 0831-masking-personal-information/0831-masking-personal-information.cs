public class Solution {
    public string MaskPII(string s) {
        if(s.Contains('@'))
        {
            s = s.ToLower();
            int indexAt = s.IndexOf('@');
            return $"{s[0]}*****{s[indexAt-1]}{s.Substring(indexAt)}";
        }
        else 
        {
            string digits = new string(s.Where(Char.IsDigit).ToArray());
            string local = digits.Substring(digits.Length-4);
            if(digits.Length == 10)
                return $"***-***-{local}";
            string mask = new string('*', digits.Length - 10);
            return $"+{mask}-***-***-{local}";
        }
    }
}