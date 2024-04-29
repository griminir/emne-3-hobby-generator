// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hobby Generator");

string[] hobby = ["chess", "programming", "MMA", "looking at grass grow"];
Random num = new Random();


Console.WriteLine("Who needs a new hobby?");
var name = Console.ReadLine();
giveHobby();


void giveHobby()
{
    int randomHobby = num.Next(hobby.Length);
    Console.WriteLine($"{name} your new hobby is {hobby[randomHobby]}");
}

//another way
Console.WriteLine("Who needs a new hobby?");
var name2 = Console.ReadLine();
getHobby();

void getHobby()
{
    int randomHobby2 = num.Next(hobby.Length);
    if (randomHobby2 == 0)
    {
        Console.WriteLine($"{name2} your new hobby is watching paint dry");
    }
    else if (randomHobby2 == 1)
    {
        Console.WriteLine($"{name2} your new hobby having fun");
    } 
    else if (randomHobby2 == 2)
    {
        Console.WriteLine($"{name2} your new hobby is gaming");
    }
    else
    {
        Console.WriteLine($"{name2} you dont get a new hobby");
    }
}