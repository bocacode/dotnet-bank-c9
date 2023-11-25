
/*

 Console.WriteLine("Hello, World!");


int age = 26;
string name = "Damian";
bool isHere = true;
double salary = 22000.01;

Console.WriteLine($"Hi, {name}. Your age is {age} and is here? {isHere}");
Console.WriteLine($"And you make 💰{salary} a year");

try
{
    SavingsAcount myAccount = new SavingsAcount(300);

    // myAccount.balance = 300;

    Console.Write("Your balance is ");
    Console.Write(myAccount.getBalance());

    Console.WriteLine(" and you're good looking");
} catch (Exception ex) {
    Console.WriteLine($"We got an error: {ex.Message}");
}

*/

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    try
    {
        Console.WriteLine("looking for banks!");
        SavingsAcount myAccount = new SavingsAcount("Todd Alberto",300);
        return Results.Ok($"Your balance is ${myAccount.getBalance()}");
        
    } catch (Exception ex) {

        Console.WriteLine($"We got an error: {ex.Message}");
        return Results.Ok(ex.Message);
        
    }
});

app.Run();
