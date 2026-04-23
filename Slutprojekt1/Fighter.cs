using System;

namespace Slutprojekt1;

public class Fighter
{
     
    public int Health { get; set; } //Liv (HP)

    public int MaxHealth { get; set; } //Max HP
public string Name { get; set; } //Namn på karaktären
    public int Attack { get; set; } //Hur mycket skada karaktären gör

    public int Defense { get; set; } //Hur mycket skada som minskar

    public int Stamina { get; set; } //Energi

    public bool IsAlive { get; set; } //Lever karaktären eller inte

    public Fighter(string name, int maxHealth, int attack, int defense) //Konstruktor som körs när en Fighter skapas
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth; //Börjar med fullt HP
        Attack = attack;
        Defense = defense;
        IsAlive = true;
        Stamina = 100; 
    }
public void AttackEnemy(Fighter enemy) //Metod för att attackera en annan fighter (alltså denna tidigare fighterns fiende.)
{
    if (Stamina <= 0) //kollar om spelaren har tillräckligt med stamina
    {
        Console.WriteLine($"{Name} är för trött för att attackera!");
        return;
    }
    int damage = Attack - enemy.Defense;

    if (damage < 0)
    {
      damage = 0;
      Console.WriteLine("Ingen skada gjord! ");
    }
        

    enemy.Health -= damage; //Tar bort HP från enemy.

 Console.WriteLine($"{Name} attackerar {enemy.Name} och gör {damage} skada! ({enemy.Health} HP kvar)");
}


}

