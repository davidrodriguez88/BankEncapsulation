namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            Console.WriteLine("Welcome to the Bank!");
            Console.Write("How much would you like to deposit?");
            
            var input = Console.ReadLine();
            double amount = double.Parse(input);
            
            myAccount.Deposit(amount);
            
            Console.WriteLine($"Your current balance is: ${myAccount.GetBalance()}");
        }
    }
}
