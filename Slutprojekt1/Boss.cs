using System;

namespace Slutprojekt1;

public class Boss : Enemy
{
public int SpecialAttackDamage { get; set; } //Specialattack som bossen kan använda

public int Phase { get; set; } //Vilken fas som bossen är i 1 eller 2

public bool IsEnraged { get; set; } //Om bossen är i rage mode.

public int SpecialCoolDown { get; set; }

public int CurrentCoolDown { get; set; }
public int MaxPhase { get; set; } //Max antal faser som bossen kan ha

public Boss(string name, int maxHealth, int attack, int defense, int difficulty, int specialDamage)
    : base(name, maxHealth, attack, defense, difficulty) //Konstruktor som körs när bossen skapas
{
    SpecialAttackDamage = specialDamage;
    Phase = 1; //Bossen börjar i fas 1
    MaxPhase = 2;
    IsEnraged = false; //inte rage
} 
public void CheckPhase() //Metod som kollar om bossen ska byta fas
        {
    
        if (Health <= MaxHealth / 2 && Phase == 1)  //när bossen får mindre än 50 HP ändras bossens beteende och då kommer följande variabler.
        {
            Phase = 2; //Byt till Phase 2
            Attack += 10; //Öka bossens attack med 10.
            IsEnraged = true; //rage mode sätts på
            Console.WriteLine($"{Name} går in i phase 2!");
        }
} }
