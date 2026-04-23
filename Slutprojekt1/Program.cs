using System;
using Slutprojekt1;
//En konstruktor startar upp ett objekt och ger det värden direkt
class Program
{
    static void Main()
    {
        // Skapar spelaren
        Fighter hero = new Fighter("Hero", 120, 20, 10);

        // Skapar bossen
        Boss boss = new Boss("Dragon", 200, 15, 10, 5, 40);

        Console.WriteLine("FIGHT START!");
        Console.WriteLine("Hero attackerar först!");
        Console.WriteLine("Tryck ENTER för att spela en runda");

        // Testar input så programmet inte kraschar
        Console.WriteLine("Skriv ett startvärde (heltal):");

        int number;

        // Loopar tills användaren skriver ett giltigt tal 
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Fel! Skriv ett heltal:");
        }

        Console.WriteLine("Startvärde godkänt: " + number);
        Console.WriteLine("----------------------");

        // Spelet körs tills någon dör
        while (hero.Health > 0 && boss.Health > 0)
        {
            Console.ReadLine(); // väntar på spelaren

            // Hero attackerar bossen
            hero.AttackEnemy(boss);

            // Kollar om boss ska byta phase
            boss.CheckPhase();

            // Boss attackerar om den lever
            if (boss.Health > 0)
            {
                boss.AttackEnemy(hero);
            }

            // Skriver ut HP
            Console.WriteLine($"Hero HP: {hero.Health}");
            Console.WriteLine($"Boss HP: {boss.Health}");
            Console.WriteLine("----------------------");
        }

        // Visar vem som vann
        if (hero.Health > 0)
            Console.WriteLine("Hero wins!");
        else
            Console.WriteLine("Boss wins!");

        // Stoppar programmet så fönstret inte stängs direkt
        Console.WriteLine("Tryck ENTER för att avsluta...");
        Console.ReadLine();
    }
}