namespace TestConsole;

/*
 *
 * A main/base class named AccountCreditInformation. 
 * A main/base class method named Credit() that returns a string value, "Balance is credited".
 * A derived class of AccountCreditInformation named DebitInformation.
 * A derived class method named debit() that contains a revised version of main/base class method Credit(). The revision changes the string value to "Balance is debited".
 * And additional concepts on your program to make it more relevant for the requirements.
 * 
 */

public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("********************************");
        var aci = new AccountCreditInformation() { Balance = 100 };
        Console.WriteLine(aci.CheckBalance());
        Console.WriteLine(aci.Credit(50));
        Console.WriteLine(aci.CheckBalance());

        Console.WriteLine("********************************");
        
        var di = new DebitInformation() { Balance = 100 };
        Console.WriteLine(di.Debit(150));
        Console.WriteLine(di.Debit(50));
        Console.WriteLine(di.CheckBalance());
    }

}

class AccountCreditInformation
{
    public decimal Balance { get; set; }

    public virtual string Credit(decimal amount)
    {
        Balance += amount;
        return "Balance is credited by $" + amount;
    }

    public virtual string CheckBalance()
    {
        return "Current balance is $" + Balance;
    }
}

class DebitInformation : AccountCreditInformation
{
    public override string Credit(decimal amount)
    {
        if (Balance - amount < 0)
        {
            return "Insufficient balance to debit $" + amount;
        }

        Balance -= amount;
        return "Balance is debited by $" + amount;
    }

    public string Debit(decimal amount)
    {
        return Credit(amount);
    }
}