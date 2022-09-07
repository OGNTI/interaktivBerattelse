string yesNo;
string direction;
string name;

Console.WriteLine("Start adventure? (6 endings)");
yesNo = Console.ReadLine();
if (yesNo == "yes" || yesNo == "Yes" || yesNo == "sure" || yesNo == "Sure" || yesNo == "ok" || yesNo == "Ok")
{
    Console.WriteLine("Good.");
}
else if (yesNo == "no" || yesNo == "No" || yesNo == "nah" || yesNo == "Nah")
{
    Console.WriteLine("Then don't bother me you little shit.");
    Console.WriteLine("This is not an automated response,");
    Console.WriteLine("I have to write out each command manually and you have the audacity of wasting my time.");
    Console.WriteLine("I get paid 2 kr a day for writing this and there's millions of people who want me to write their commands.");
    Console.ReadLine();
    Environment.Exit(0);

}
else
{
    Environment.Exit(0);
}

Console.WriteLine("You wake up, Go downstairs or jump out the window?");
direction = Console.ReadLine();

if (direction == "Go downstairs" || direction == "go downstairs" || direction == "downstairs" || direction == "Downstairs")
{
    Console.WriteLine("You decide to go downstairs, but you trip and fall down the stairs and lose consciousness. (-80% strength)");
    Console.WriteLine("You wake up again, Go downstairs or jump out the window?");
    direction = Console.ReadLine();

    if (direction == "Go downstairs" || direction == "go downstairs" || direction == "downstairs" || direction == "Downstairs")
    {
        Console.WriteLine("You go downstairs again, this time you don't trip and fall.");
        Console.WriteLine("You decide to sit down and watch TV to rest. You fall asleep on the couch not long after.");
        Console.WriteLine("Your dog took a shit in your mouth and you suffocated in your sleep. L");
    }
    else if (direction == "Jump out the window" || direction == "jump out the window" || direction == "jump" || direction == "Jump" || direction == "jump out" || direction == "Jump out")
    {
        Console.WriteLine("You jump out of the window and break your legs because you were so weak.");
        Console.WriteLine("You bleed out before even being able to call for an ambulance.");
    }
    else
    {
        Console.WriteLine("You were too tired to do anything and fell asleep on the spot.");
    }
}
else if (direction == "Jump out the window" || direction == "jump out the window" || direction == "jump" || direction == "Jump" || direction == "jump out" || direction == "Jump out")
{
    Console.WriteLine("You decided to jump out of the window for some reason.");
    Console.WriteLine("You land in a pile of dog shit, your shoes are now covered in it.");
    Console.WriteLine("Throw away your shoes?");
    yesNo = Console.ReadLine();

    if (yesNo == "yes" || yesNo == "Yes" || yesNo == "sure" || yesNo == "Sure" || yesNo == "ok" || yesNo == "Ok")
    {
        Console.WriteLine("You threw away your shoes but you threw too hard and they broke your neighbours window.");
        Console.WriteLine("You hear your neighbour shouting angrily. He opens the 2nd floor window and sticks out his shotgun.");
        Console.WriteLine("You died.");
    }
    else if (yesNo == "no" || yesNo == "No" || yesNo == "nah" || yesNo == "Nah")
    {
        Console.WriteLine("You kept your shoes on and didn't care about the dog shit.");
        Console.WriteLine("You walk over to the road, a woman walks past you and makes a stinky face.");
        Console.WriteLine("What is your name?, she asks.");
        name = Console.ReadLine();
        Console.WriteLine($"You answered, My name is {name} but everyone calls me stupid.");
        Console.WriteLine("She gives you a fine of 69 000 kr for waking around with dog shit on your shoes.");
        Console.WriteLine("You forgot that there's a law that outlaws walking around with dog shit on your shoes.");
        Console.WriteLine("You are poor as fuck, so you get sent to prison for lifetime instead.");
        Console.WriteLine("You apparently also forgot the law about getting lifetime in prison if you can't pay a fine.");
    }
    else
    {
        Console.WriteLine("It's a yes or no question, dumb fuck.");
    }
}
else
{
    Console.WriteLine("You didn't like either option and went back to sleep.");
}

Console.ReadLine();