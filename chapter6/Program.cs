//Quetion one
Console.WriteLine("Enter an integer number"); 
int num= int.Parse(Console.ReadLine()!); 
for(int i=1; i<=num; i++) 
{ 
Console.Write(i+" "); 
}  

//Question Two
Console.WriteLine("Enteranumber");
int num1 = int.Parse(Console.ReadLine()!); 
for(int i=1; i<=num; i++) 
{ 
if(i % 3 == 0 && i % 7 == 0) 
{ 
Console.WriteLine($"{i} is divisible by 3 or 7"); 
} 
else 
{ 
Console.WriteLine($"{i} is not divisible by 3 or 7"); 
} 
}

//Question Three
Console.WriteLine("Enter the number of numbers you want to input:"); 
String input = Console.ReadLine()!; 
if(input.Length==0) 
{ 
Console.WriteLine("Invalidinput"); 
} 
int smallest = int.MaxValue; 
int largest = int.MinValue; 
for(int i=0; i < input.Length; i++) 
{ 
if(i<smallest) 
{ 
smallest = input[i]; 
} 
if(i>largest) 
{ 
largest = input[i]; 
} 
} 
Console.WriteLine(smallest); 
Console.WriteLine(largest);    

//Question Four
// ??????????

//Question Five
int Fibonacci = 0;
Console.WriteLine("Enter your number here"); 
int number = int.Parse(Console.ReadLine()!); 
for(int i=0; i<=number; i++) 
{ 
Fibonacci += i; 
} 
Console.WriteLine($"The sum of the Fibonacci sequence is {Fibonacci}"); 

//Question Six
try 
{ 
int productN =1; 
int productK =1; 
Console.WriteLine("Enter your number here"); 
int numbers = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Enter your numbers here!"); 
for(int i=0; i<=numbers; i++) 
{ 
productN *= i; 
} 
for(int j=0; j<=number; j++) 
{ 
productK *= j; 
} 
Console.WriteLine($"N!/K!=: {productN/productK}");
} 
catch(DivideByZeroException)
{  
Console.WriteLine("divide by zero exception"); 
}   

//Question Seven
 try
{
    int ProductN=1;
    int ProductK=1;
    Console.WriteLine("Enter N ");
    int N=int.Parse(Console.ReadLine());
    System.Console.WriteLine("Enter K");
    int K=int.Parse(Console.ReadLine());
    for (int i = 1; i <= N; i++)
    {
        ProductN*=i;
    }
    for (int j = 1; j <= K; j++)
    {
    ProductK *= j;
    }
    int formula = ProductN * ProductK / (ProductN-ProductK);
    System.Console.WriteLine(formula);
    }
    catch (System.Exception ex)
    {
    System.Console.WriteLine(ex.Message);  
    }


//Question Eight

//Question Nine

//Question Ten

//Question Eleven

//Question Twelve

//Question Thirteen

//Question Fourteen

//Question Fifteen

//Question Sixteen

//Question Seventeen

//Question Eighteen