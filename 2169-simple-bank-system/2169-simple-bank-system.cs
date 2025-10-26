public class Bank {
    private readonly List<long> accounts;
    public Bank(long[] balance) {
        accounts = new List<long>(balance);
    }
    
    public bool Transfer(int account1, int account2, long money) {
        if(account1 > accounts.Count || account2 > accounts.Count) return false;
        if(accounts[account1-1] < money) return false;
        accounts[account1-1] -= money;
        accounts[account2-1] += money;
        return true;
    }
    
    public bool Deposit(int account, long money) {
        if(account > accounts.Count) return false;
        accounts[account-1] += money;
        return true;
    }
    
    public bool Withdraw(int account, long money) {
        if(account > accounts.Count) return false;
        if(accounts[account - 1] < money) return false;
        accounts[account -1] -= money;
        return true;
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * bool param_1 = obj.Transfer(account1,account2,money);
 * bool param_2 = obj.Deposit(account,money);
 * bool param_3 = obj.Withdraw(account,money);
 */