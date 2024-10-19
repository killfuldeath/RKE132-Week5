

Console.WriteLine("Please specify what temperature it is:");
int temp = Int32.Parse(Console.ReadLine());

if (temp <= 0)
{
    Console.WriteLine("It is Freezing cold");
}
else if (temp > 0 && temp <= 10)
{
    Console.WriteLine("It is Cold");
}
else if (temp > 10 && temp <= 15)
{
    Console.WriteLine("Its pretty chilly, huh?");
}
else if (temp > 15 && temp < 20)
{

    Console.WriteLine("Its warm.");
}
else if (temp >= 20 && temp < 30)
{

    Console.WriteLine("Its hot.");
}
else
{
    Console.WriteLine("Its boiling hot.");
}

//tegin seda teistpidi, et endale selgemaks teha(kuid saan juba aru)