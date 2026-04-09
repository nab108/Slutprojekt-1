using System;

namespace Slutprojekt1;

public class Boss : Enemy
{
public int SpecialAttackDamage { get; set; }

public int Phase { get; set; }

public bool IsEnraged { get; set; }

public int SpecialCoolDown { get; set; }

public int CurrentCoolDown { get; set; }
public int MaxPhase { get; set; }

public void CheckPhase() //Metod som kollar om bossen ska byta fas
        {
    {
        if (Health <= MaxHealth / 2 && Phase == 1)  //när bossen får mindre än 50 HP ändras bossens beteende och då kommer följande variabler.
            Phase = 2;
            Attack += 10; //Öka bossens attack med 10.
            IsEnraged = true; //rage mode sätts på
            Console.WriteLine($"{Name} går in i phase 2!");
        }
}}
