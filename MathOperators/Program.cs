// See https://aka.ms/new-console-template for more information

int grade = 50;

switch (grade)
{
    case int n when n <= 60:
        Console.WriteLine("Failed");
        break;
    default:
        Console.WriteLine("bla");
        break;
}

var resultgrade =grade==50 ? "equals 50" : "different";

void printName()
{
    Console.WriteLine("hi");
}
printName();









