//Number One 
Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
int findRemainder = number % 2;
Console.WriteLine($"Remainder: {findRemainder}");
if(findRemainder == 1)
{
    Console.WriteLine("it is an odd number");
}
else if(findRemainder == 0)
{
    Console.WriteLine("it is an even number");
}
else
{
    Console.WriteLine("Unhandled Exception");
}

//Number Two
bool result;
Console.WriteLine("What is your Number: ");
int yourNumber = int.Parse(Console.ReadLine()!);
if (yourNumber % 5 == 0 && yourNumber % 7 == 0)
{
    result = true;
    Console.WriteLine(result);
}
else 
{
    result = false;
    Console.WriteLine(result);
};

//Number Three
Console.WriteLine("What is your Number: ");
int numbers = int.Parse(Console.ReadLine()!);
int dividedNumber = numbers / 100;
int extendedDivision = dividedNumber % 10;
if (extendedDivision == 7)
{
    Console.WriteLine("The Third Number is Seven");
}
else 
{
    Console.WriteLine("The Third Number is not Seven");
}

//Number Four

//Number Five
int a = 34;
int b = 10;
int h = 7;
int trapeziumArea = (a + b) * h / 2;
Console.WriteLine(trapeziumArea);

//Number Six
int side = int.Parse(Console.ReadLine()!);
int height = int.Parse(Console.ReadLine()!);
int perimeter = 2 * (side + height);
int area = (side * height);
Console.WriteLine(perimeter);
Console.WriteLine(area);

//Number Seven
Console.WriteLine("Enter number: ");
int earthManWeight = Convert.ToInt32(Console.ReadLine()); 
double moonManWeight = (earthManWeight * 0.17);
Console.WriteLine(moonManWeight);

//Number Eight
Console.WriteLine("Enter a number: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter another number: ");
int y = int.Parse(Console.ReadLine()!);
bool insideOfCircle = ((x * x) + (y * y)) <= (5 * 5);
bool insideOfRectangle = x < -1 || x > 5 || y < 1 || y > 5;
bool point = insideOfCircle && insideOfRectangle;

//Number Nine
Console.WriteLine("Enter a number: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter another number: ");
int y1 = int.Parse(Console.ReadLine()!);
bool insideOfCircle1 = ((x1 * x1) + (y1 * y1)) <= (5 * 5);
bool insideOfRectangle1 = x1 < -1 || x1 > 5 || y1 < 1 || y1 > 5;
bool checkPoint = insideOfCircle && insideOfRectangle;

//Number Ten
Console.Write("Enter a four-digit number: ");
int number = int.Parse(Console.ReadLine()!);
int sumDigit = (number % 10) + ((number / 10) % 10) + ((number / 100) % 10) + ((number / 1000) % 10);
Console.WriteLine("Sum of Digits: " + sumDigit);
int reversedNumber = (number % 10) * 1000 + ((number / 10) % 10) * 100 + ((number / 100) % 10) * 10 + (number / 1000);
Console.WriteLine("Reversed Number: " + reversedNumber);
int lastDigitFirst = (number % 10) * 1000 + (number / 10);
Console.WriteLine("Last Digits in the First Position: " + lastDigitFirst);
int exchangeDigits = (number / 1000) * 1000 + ((number / 100) % 10) * 100 + ((number / 10) % 10) * 10 + ((number % 10) * 100);
Console.WriteLine("Exchange Second and Third Digits: " + exchangeDigits);

//Question Eleven
int n = 35;
int p = 5;
int bitValue = (n >> p) & 1;
Console.WriteLine("The bit at position " + p + " in the number " + n + " is: " + bitValue);

//Question Twelve
int v = 5;
int p = 1;
bool isBitOne = (v & (1 << p)) != 0;
Console.WriteLine("Is the Bit at Position " + p + " in " + v + " equals to 1? " + isBitOne);
