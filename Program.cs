int random1 = 0;
int random2 = 0;
int random3 = 0;
int random4 = 0;
int random5 = 0;
int points = 0;

bool dice1 = false;
bool dice2 = false;
bool dice3 = false;
bool dice4 = false;
bool dice5 = false;

int fix1;
int j = 0;
int help;
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("PLAYER 1!");
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("========================");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Press any key to roll the dices!");
Console.ReadKey();
PlayGame();
AnalyzeAndPrintResult();
int p1points = points;

Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("PLAYER 2!");
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("========================");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Press any key to roll the dices!");
Console.ReadKey();
PlayGame();
AnalyzeAndPrintResult();
int p2points = points;
DetermineWinner();
void RollDice()
{
    if (dice1 == false)
    {
        random1 = Random.Shared.Next(1, 7);
    }
    if (dice2 == false)
    {
        random2 = Random.Shared.Next(1, 7);
    }
    if (dice3 == false)
    {
        random3 = Random.Shared.Next(1, 7);
    }
    if (dice4 == false)
    {
        random4 = Random.Shared.Next(1, 7);
    }
    if (dice5 == false)
    {
        random5 = Random.Shared.Next(1, 7);
    }
}
void PrintDice()
{
    Console.WriteLine(random1);
    Console.WriteLine(random2);
    Console.WriteLine(random3);
    Console.WriteLine(random4);
    Console.WriteLine(random5);
}
void FixDice()
{
    dice1 = false;
    dice2 = false;
    dice3 = false;
    dice4 = false;
    dice5 = false;
    Console.WriteLine("Which dice do want to fix (press 1-5, if you do not want to fix a dice press 0 at the field where the dice is to fix!) ?");
    fix1 = int.Parse(Console.ReadLine()!);
    if (fix1 == 1)
    {
        dice1 = true;
    }
    fix1 = int.Parse(Console.ReadLine()!);
    if (fix1 == 2)
    {
        dice2 = true;
    }
    fix1 = int.Parse(Console.ReadLine()!);
    if (fix1 == 3)
    {
        dice3 = true;
    }
    fix1 = int.Parse(Console.ReadLine()!);
    if (fix1 == 4)
    {
        dice4 = true;
    }
    fix1 = int.Parse(Console.ReadLine()!);
    if (fix1 == 5)
    {
        dice5 = true;
    }
    Console.WriteLine();
}
void SortDice()
{
    for (int k = -1; k != 0;)
    {
        k = 0;
        if (random1 > random2)
        {
            help = random1;
            random1 = random2;
            random2 = help;
            k++;
        }
        if (random2 > random3)
        {
            help = random2;
            random2 = random3;
            random3 = help;
            k++;
        }
        if (random3 > random4)
        {
            help = random3;
            random3 = random4;
            random4 = help;
            k++;
        }
        if (random4 > random5)
        {
            help = random4;
            random4 = random5;
            random5 = help;
            k++;
        }
    }
}
void AnalyzeAndPrintResult()
{
    if (random1 == random2 && random2 == random3 && random3 == random4 && random4 == random5)
    {
        Console.WriteLine("Five of a kind!");
        Console.WriteLine("You have rolled five identical dice values!");
        points = 8;
    }
    else if ((random1 == random2 && random2 == random3 && random3 == random4) || (random2 == random3 && random3 == random4 && random4 == random5))
    {
        Console.WriteLine("Four of a kind!");
        Console.WriteLine("You have rolled four identical dice values!");
        points = 7;
    }
    else if ((random1 == random2 && random2 == random3 && random4 == random5) || (random1 == random2 && random3 == random4 && random4 == random5))
    {
        Console.WriteLine("Full House!");
        Console.WriteLine("You have rolled three of a kind and a pair in a single hand!");
        points = 6;
    }
    else if (random1 + 1 == random2 && random2 + 1 == random3 && random3 + 1 == random4 && random4 + 1 == random5)
    {
        Console.WriteLine("Straight!");
        Console.WriteLine("You have rolled five dice values in sequential rank!");
        points = 5;
    }
    else if ((random1 == random2 && random2 == random3) || (random2 == random3 && random3 == random4) || (random3 == random4 && random4 == random5))
    {
        Console.WriteLine("Three of a kind!");
        Console.WriteLine("You have rolled three identical dice values!");
        points = 4;
    }
    else if ((random1 == random2 && random3 == random4) || (random2 == random3 && random4 == random5) || (random1 == random2 && random4 == random5))
    {
        Console.WriteLine("Two pairs!");
        Console.WriteLine("You have rolled two pairs in a single hand!");
        points = 3;
    }
    else if (random1 == random2 || random2 == random3 || random3 == random4 || random4 == random5)
    {
        Console.WriteLine("One pair!");
        Console.WriteLine("You have rolled one pair!");
        points = 2;
    }
    else
    {
        Console.WriteLine("Bust!");
        points = 1;
    }
}
void DetermineWinner()
{
    if (p1points > p2points)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("PLAYER 1 wins!!!");
        Console.BackgroundColor = ConsoleColor.Black;
    }
    else if (p1points < p2points)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("PLAYER 2 wins!!!");
        Console.BackgroundColor = ConsoleColor.Black;
    }
    else if (p1points == p2points)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("DRAW!!!");
        Console.BackgroundColor = ConsoleColor.Black;
    }
}
void PlayGame()
{
    j = 0;
    dice1 = false;
    dice2 = false;
    dice3 = false;
    dice4 = false;
    dice5 = false;
    for (int i = 0; i < 3 && j == 0; i++)
    {
        RollDice();
        SortDice();
        PrintDice();
        if (i < 2)
        {
            FixDice();
        }
        if (dice1 == true && dice2 == true && dice3 == true && dice4 == true && dice5 == true)
        {
            j++;
        }
    }
}