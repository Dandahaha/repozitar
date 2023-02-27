Random rnd = new Random();
string[] weapons = { "rock", "paper", "scissors" };

Console.Clear();
Console.WriteLine("Welcome to the rock-paper-scissors game!");
Console.ReadLine();
Console.Clear();

while (true)
{
    Console.WriteLine("Choose your weapon: rock, paper or scissors");
    string playerChoice = Console.ReadLine();
    string computerChoice = weapons[rnd.Next(0, weapons.Length)];

    Console.WriteLine("You chose " + playerChoice + " and the computer chose " + computerChoice);
    if (playerChoice == computerChoice)
    {
        Console.WriteLine("It's a tie!");
    }
    else if(playerChoice == "rock" && computerChoice == "scissors")
    {
        Console.WriteLine("You win!");
    }
    else if(playerChoice == "rock" && computerChoice == "paper")
    {
        Console.WriteLine("You lose!");
    }
    else if(playerChoice == "paper" && computerChoice == "rock")
    {
        Console.WriteLine("You win!");
    }
    else if(playerChoice == "paper" && computerChoice == "scissors")
    {
        Console.WriteLine("You lose!");
    }
    else if(playerChoice == "scissors" && computerChoice == "paper")
    {
        Console.WriteLine("You win!");
    }
    else if(playerChoice == "scissors" && computerChoice == "rock")
    {
        Console.WriteLine("You lose!");
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
    Console.ReadLine();
    Console.Clear();
}