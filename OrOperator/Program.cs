

int math, biology, chemistry;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());


if ((math >= 90 && chemistry >= 90) || (chemistry >= 90 && biology >=90) || (math >= 90 && chemistry >= 90)) 
{
    Console.WriteLine("Youve been accepted to college! I hope you hate it!");
}
else
{
    Console.WriteLine("You have not been accepted.. good for you..");
}