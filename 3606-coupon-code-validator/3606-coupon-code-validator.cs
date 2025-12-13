using System.Text.RegularExpressions;
public class Solution {
    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive) {
        var categories = new HashSet<string>() { "electronics", "grocery", "pharmacy", "restaurant"};
        Regex validPattern = new Regex("^[a-zA-Z0-9_]+$");
        var validCoupons = new List<(string Code, string Line)>();
        var priorityMap = new Dictionary<string,int>()
        {
            { "electronics", 0 },
            { "grocery", 1 },
            { "pharmacy", 2 },
            { "restaurant", 3 }
        };
        int n = code.Length;
        for(int i = 0 ; i < n ; i++)
        {
            if(code[i] == "") continue;
            if(!isActive[i]) continue;
            if(!categories.Contains(businessLine[i])) continue;
            if(validPattern.IsMatch(code[i]))
                validCoupons.Add((code[i] , businessLine[i]));
        }
        return validCoupons
        .OrderBy(x => priorityMap[x.Line]) 
        .ThenBy(x => x.Code, StringComparer.Ordinal)               
        .Select(x => x.Code)               
        .ToList();
    }
}