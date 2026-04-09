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

public void CheckPhase()
    {
        if (Health <= MaxHealth / 2 && Phase == 1) //Metod som kollar om bossen ska byta fas
        {
            Phase = 2;
            Attack += 10; //Öka bossens attack med 10.
            IsEnraged = true; //rage mode sätts på
            Console.WriteLine($"{Name} går in i phase 2!");
        }
}}
