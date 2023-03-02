public class CheckingAccount : BankAccount {
  public CheckingAccount(string newCustomerName, double newBalance) : base(newCustomerName, newBalance) {

        deposit(100); // ALl checking accounts created get $100 more in their balance

    }

}