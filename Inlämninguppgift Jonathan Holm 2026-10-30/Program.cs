using Rentals;
using System.Collections;
using System.Text.Json;


string jsonRentals = File.ReadAllText("Rentals.json");

string jsonCustomer = File.ReadAllText("Customer.json");

string jsonRentalsInProgress = File.ReadAllText("RentalsInProgress.json");


List<Bike> bike = JsonSerializer.Deserialize<List<Bike>>(jsonRentals);

List<Customer> customer = JsonSerializer.Deserialize<List<Customer>>(jsonCustomer);

List<RentalsInProgress> rentalsInProgress = JsonSerializer.Deserialize<List<RentalsInProgress>>(jsonRentalsInProgress);

while (true)
{
    Console.WriteLine("""
                === Kajens Cykeluthyrning ===
        1. Visa fordon  2. Registrera kund  3. Hyr ut
        4. Lämna tillbaka  5. Ladda  6. Avsluta
        """);

    Console.Write("Välj ett alternativ: ");
    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        Console.WriteLine("""
            Val: 1
            Nr  Typ      Status  Batteri
            """);
        foreach (Bike bicykle in bike)
        {
            bicykle.Display();
        }
    }

}