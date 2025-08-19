// See https://aka.ms/new-console-template for more information


using FullStack.Domain;

Console.WriteLine("Testing Demo");


var shippingService = new ShippingService();

var shippingCharge = shippingService.Calculate(10, "IE");
Console.WriteLine($"{shippingCharge}");
