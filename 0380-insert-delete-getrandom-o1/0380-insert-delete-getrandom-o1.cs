public class RandomizedSet {
    List<int> v = new List<int>();
    private Dictionary<int,int> exists= new Dictionary<int,int>();
    public RandomizedSet() {
        
    }
    
    public bool Insert(int val) {
       if(!exists.ContainsKey(val))
       {
        exists[val] = v.Count;
        v.Add(val);
        return true;
       } 
       return false;
    }
    
    public bool Remove(int val) {
        if(exists.ContainsKey(val))
        {
            v[exists[val]] = v[v.Count-1];
            exists[v[v.Count-1]] = exists[val];
            v.RemoveAt(v.Count-1);
            exists.Remove(val);
            return true;
        }
        return false;
    }
    
    public int GetRandom() {
        Random random = new Random();
        return v[random.Next(v.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */