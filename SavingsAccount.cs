public class SavingsAcount : BankAccount {

    public SavingsAcount(string newCustomerName, double newBalance) 
    : base(newCustomerName, newBalance) {

       deposit(200);

    }
}