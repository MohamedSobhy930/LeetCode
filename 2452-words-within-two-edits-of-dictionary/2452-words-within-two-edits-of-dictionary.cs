public class Solution {
    public IList<string> TwoEditWords(string[] queries, string[] dictionary) {
      var result = new List<string>();

      for(int i = 0 ; i < queries.Length; i++)
      {
        string s = queries[i];
        for(int j = 0 ; j < dictionary.Length ; j++)
        {
            string ss = dictionary[j];
            int diff = 0;
            int k = 0; 
            while(k < s.Length)
            {
                if(s[k] != ss[k])
                    diff++;
                k++;
            }
            if(diff <= 2)
            {
                result.Add(s);
                break;
            }
        }
      }
      return result;  
    }
}