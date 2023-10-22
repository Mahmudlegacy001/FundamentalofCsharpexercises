//QuestionOne
Console.WriteLine("Enternum1"); 
int num1 = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Enternum2"); 
int num2=int.Parse(Console.ReadLine()!); 
int num3=0; 
if(num1>num2) 
{ 
num3 = num1; 
num1 = num2; 
num2 = num3; 
Console.WriteLine($"The first number is:{num1}"); 
Console.WriteLine($"The second number is:{num2}"); 
} 
else 
{ 
Console.WriteLine($"The first number is:{num1}"); 
Console.WriteLine($"The second number is:{num2}"); 
} 

//QuestionTwo
Console.WriteLine("Enterarealnumber"); 
double sign = double.Parse(Console.ReadLine()!); 
Console.WriteLine("Enterarealnumber"); 
double sign1 = double.Parse(Console.ReadLine()!); 
Console.WriteLine("Enterarealnumber"); 
double sign2 = double.Parse(Console.ReadLine()!); 
if(sign<0&&sign1<0&&sign2<0) 
{ 
Console.WriteLine("Theresultis:-"); 
} 
elseif((sign>0&&sign1<0&&sign2<0)||(sign<0&&sign1>0&&sign2<0)||(sign<0&&sign1<0&&sign2>0)) 
{ 
Console.WriteLine("Theresultis:+"); 
} 
elseif((sign>0&&sign1>0&&sign2>0)||(sign==0||sign1==0||sign2==0)) 
{ 
Console.WriteLine("Theresultis:+"); 
} 
elseif((sign>0&&sign1>0&&sign2<0)||(sign<0&&sign1>0&&sign2>0)||(sign>0&&sign1<0&&sign2>0)) 
{ 
Console.WriteLine("Theresultis:-"); 
} 
else 
{ 
Console.WriteLine("InvalidInput"); 
}

//Question Three

//Question Four

//Question Five
Console.Write("Enter a digit (0 - 9): ");
int digit = int.Parse(Console.ReadLine()!);
string word;
switch(digit)
    {
        case 0:
        word = "Zero";
        break;
        case 1:
        word = "One";
        break;
        case 2:
        word = "Two";
        break;
        case 3:
        word = "Three";
        break;
        case 4:
        word = "Four";
        break;
        case 5:
        word = "Five";
        break;
        case 6:
        word = "Six";
        break;
        case 7:
        word = "Seven";
        break;
        case 8:
        word = "Eight";
        break;
        case 9:
        word = "Nine";
        break;
        default:
        word = "Invalid digit";
        break;
    }
        Console.WriteLine("The digit as a word is: " + word);

//Question Six

//Question Seven

//Question Eight
Console.WriteLine("Enter your choice.");
    Console.WriteLine("1. Integer\n2. Double\n3. String");
    int choice = int.Parse(Console.ReadLine()!);
    switch(choice)
    {
        case 1:
        Console.Write("Enter an Integer: ");
        int intValue = int.Parse(Console.ReadLine()!);
        intValue ++;
        Console.WriteLine("Result: " + intValue);
        break;

        case 2:
        Console.Write("Enter a Double: ");
        double intDouble = double.Parse(Console.ReadLine()!);
        intDouble ++;
        Console.WriteLine("Result: " + intDouble);
        break;

        case 3:
        Console.Write("Enter a String: ");
        string stringValue = (Console.ReadLine()!);
        stringValue += "*";
        Console.WriteLine("Result: " + stringValue);
        break;

        default:
        Console.WriteLine("Invalid input");
        break;
    }

//Question Nine

//Question Ten

//Question Eleven
int[] numbers = { 0, 12, 98, 273, 400, 501, 711 };
string[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
    
    foreach (int number in numbers)
        {
            string words;
            if (number < 20)
            {
                words = units[number];
            }
            else if (number < 100)
            {
                int tensDigit = number / 10;
                int unitsDigit = number % 10;
                if (unitsDigit == 0)
                {
                    words = tens[tensDigit];
                }
                else
                {
                    words = tens[tensDigit] + " " + units[unitsDigit];
                }
            }
            else if (number < 1000)
            {
                int hundredsDigit = number / 100;
                int tensAndUnits = number % 100;
                if (tensAndUnits == 0)
                {
                    words = units[hundredsDigit] + " Hundred";
                }
            else
                {
                    words = units[hundredsDigit] + " Hundred and " + units[tensAndUnits];
                }
            }
            else
            {
                words = "Invalid number. Number should be between 0 and 999.";
            }
            Console.WriteLine($"{number} --> \"{words}\"");
    }