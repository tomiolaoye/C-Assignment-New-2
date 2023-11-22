using System;
using System.Collections.Generic;

class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
}

class Payment
{
    public int PaymentId { get; set; }
    public int UserId { get; set; }
    public decimal PaymentAmount { get; set; }
}

class Program
{
    static void Main()
    {
        // Generate static records for 5 users
        List<User> users = new List<User>
        {
            new User { UserId = 1, FirstName = "Tolu", LastName = "Obasun", EmailAddress = "tolu.obasun@yahoo.com" },
            new User { UserId = 2, FirstName = "Dami", LastName = "Akintayo", EmailAddress = "dami.akintayo@yahoo.com" },
            new User { UserId = 3, FirstName = "Hassan", LastName = "Azi", EmailAddress = "hassan.azi@yahoo.com" },
            new User { UserId = 4, FirstName = "Givyeolu", LastName = "Embaga", EmailAddress = "givyeolu.embaga@yahoo.com" },
            new User { UserId = 5, FirstName = "Oluchi", LastName = "Williams", EmailAddress = "oluchi.williams@yahoo.com" }
        };

        // Generate static records for 15 payments
        List<Payment> payments = new List<Payment>
        {
            new Payment { PaymentId = 1, UserId = 1, PaymentAmount = 100050},
            new Payment { PaymentId = 2, UserId = 2, PaymentAmount = 75200},
            new Payment { PaymentId = 3, UserId = 3, PaymentAmount = 150750},
            new Payment { PaymentId = 4, UserId = 4, PaymentAmount = 50000},
            new Payment { PaymentId = 5, UserId = 5, PaymentAmount = 120230},
            new Payment { PaymentId = 6, UserId = 1, PaymentAmount = 20000},
            new Payment { PaymentId = 7, UserId = 2, PaymentAmount = 45000},
            new Payment { PaymentId = 8, UserId = 3, PaymentAmount = 90000},
            new Payment { PaymentId = 9, UserId = 4, PaymentAmount = 120800},
            new Payment { PaymentId = 10, UserId = 5, PaymentAmount = 19000},
            new Payment { PaymentId = 11, UserId = 1, PaymentAmount = 120000},
            new Payment { PaymentId = 12, UserId = 2, PaymentAmount = 81900},
            new Payment { PaymentId = 13, UserId = 3, PaymentAmount = 46800},
            new Payment { PaymentId = 14, UserId = 4, PaymentAmount = 92550},
            new Payment { PaymentId = 15, UserId = 5, PaymentAmount = 48000},

        };

        // Display the generated user records
        Console.WriteLine("Users:");
        foreach (var user in users)
        {
            Console.WriteLine($"User ID: {user.UserId}, Name: {user.FirstName} {user.LastName}, Email: {user.EmailAddress}");
        }

        // Display the generated payment records
        Console.WriteLine("\nPayments:");
        foreach (var payment in payments)
        {
            Console.WriteLine($"Payment ID: {payment.PaymentId}, User ID: {payment.UserId}, Amount: {payment.PaymentAmount:C}");
        }
    }
}