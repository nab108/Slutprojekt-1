using System;

namespace Slutprojekt1;

public class Fighter
{
     
    public int Health { get; set; }

    public int MaxHealth { get; set; }
public string Name { get; set; }
    public int Attack { get; set; }

    public int Defense { get; set; }

    public int Stamina { get; set; }

    public bool IsAlive { get; set; }

    public Fighter(string name, int maxHealth, int attack, int defense)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Attack = attack;
        Defense = defense;
        IsAlive = true;
    }



}

