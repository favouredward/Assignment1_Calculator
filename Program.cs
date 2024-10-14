
Console.WriteLine("Hello");
Console.WriteLine("Input the first number: ");
var firstText  = Console.ReadLine();
var num1 = int.Parse(firstText);

Console.WriteLine("Input the second number");
var secondText = Console.ReadLine();
var num2 = int.Parse(secondText);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
var choice = Console.ReadLine();

if(choice == "A" || choice  == "a")
{
    var sum = num1 + num2;
    Console.WriteLine(
        num1 + " + " + num2 + " = " + sum);
}

else if (choice == "S" || choice == "s")
{
    var difference = num1 - num2;
    Console.WriteLine(
        num1 + " - " + num2 + " = " + difference);
}
else if (choice == "M" || choice == "m")
{
    var multiplied = num1 * num2;
    Console.WriteLine(
        num1 + " * " + num2 + " = " + multiplied);
}

else
{
    Console.WriteLine("Invalid Choice!");
}

Console.WriteLine("Press any key to close");
Console.ReadKey();
