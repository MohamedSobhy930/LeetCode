public class Solution {
        public bool IsValid(string s)
    {
        Stack<char> Paranthese = new Stack<char>();
        Dictionary<char, char> check = new Dictionary<char, char>()
{
    {')','('},
    {']','['},
    {'}','{'}
};
        foreach (var c in s)
        {
            if (check.ContainsValue(c))
                Paranthese.Push(c);
            else if (check.ContainsKey(c))
            {
                if (Paranthese.Count == 0 || Paranthese.Pop() != check[c])
                    return false;
            }
        }
        return Paranthese.Count == 0;
    }
}