//Number One
Console.WriteLine("Enter your First Number");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter your Second Number");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter your Third Number");
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine(a + b + c);

//Number Two
double radius = double.Parse(Console.ReadLine()!);
double circleArea = Math.PI * radius;
Console.WriteLine(circleArea);

//Number Three
Console.Write("Enter company name: ");
string companyName = Console.ReadLine()!;
Console.Write("Enter company address: ");
string companyAddress = Console.ReadLine()!;
Console.Write("Enter company phone number: ");
string companyPhoneNumber = Console.ReadLine()!;
Console.Write("Enter company fax number: ");
string companyFaxNumber = Console.ReadLine()!;
Console.Write("Enter company website: ");
string companyWebsite = Console.ReadLine()!;
Console.Write("Enter manager name: ");
string managerName = Console.ReadLine()!;
Console.Write("Enter manager surname: ");
string managerSurname = Console.ReadLine()!;
Console.Write("Enter manager phone number: ");
string managerPhoneNumber = Console.ReadLine()!;
Console.WriteLine($"Company Information:\nName: {companyName} \nAddress: {companyAddress} \nPhone Number: {companyPhoneNumber}\nFax Number: {companyFaxNumber}\nWebsite: {companyWebsite}");
Console.WriteLine($"\nManager Information:\nName: {managerName}\nSurname: {managerSurname}\nPhone Number:: {managerPhoneNumber}");

//Question Four
int number1 = 75;          
double number2 = 34.56; 
double number3 = -68.454; 
Console.WriteLine("{0,-10:X}{1,-10:F2}{2,-35:F9}", number1, number2, number3);

//Question Five

//Question Six
Console.Write("Enter the first number: ");
double firstNumber = double.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
double secondNumber = double.Parse(Console.ReadLine());
double greaterNumber = Math.Max(firstNumber, secondNumber);
Console.WriteLine($"The greater number is: {greaterNumber}");

//Question Seven
long sum = 0;
int count = 0;
while(count < 5)
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
            {
                sum += number;
                count++;
            }
        else
            {
                Console.WriteLine("Invalid number. Please enter a valid integer.");
            }
        }
        Console.WriteLine("Sum: " + sum);

//Question Eight

//Question Nine
Console.WriteLine("How many numbers do you want to sum ?: ");
int reply = int.Parse(Console.ReadLine()!);
for (int i = 0; i <= reply; i++)
    {
        Console.Write("Enter the first number: ");
        int Number1 = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the next number: ");
        int Number2 = int.Parse(Console.ReadLine()!);
    }    

//Question Ten
Console.Write("Enter the number of integer (n): ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Numbers in the range [1…n]: ");
for (int i = 0; i <= n; i++)
    {
        Console.WriteLine(i);
    }

//Question Eleven

//Question Twelve
    