namespace AtmServices;

public class atm
{
    public int balance;

    public atm(int initialBalance)
    => balance = initialBalance;

    public bool withdrwal(int amount)
    {
        if (amount < balance)
        {
            balance -= amount;
            return true;
        }
        return false;
    }
    public bool deposit(int amount)
    {
        if (amount < 0)
        {
            return false;
        }

        balance += amount;
        return true;
    }

    public int getBalance()
        => balance;
}
