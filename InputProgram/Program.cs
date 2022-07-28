// See https://aka.ms/new-console-template for more information
//Taking user input
Console.WriteLine("Enter your name below:");
String name = Console.ReadLine();
Console.WriteLine("Hello " + name);
//Taking user input and converting it
Console.WriteLine("Enter your age below:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is " + age);
Console.ReadKey();