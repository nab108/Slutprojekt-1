using System;

namespace Slutprojekt1;

public class Enemy : Fighter
{

//Hur svår enemy är (tex 1 = enkel, 5 = svår)
public int Difficulty { get; private set; } 

public Enemy(string name, int maxHealth, int attack, int defense, int difficulty)
        : base(name, maxHealth, attack, defense) //Konstruktor som körs när Enemy skapas
    {
        Difficulty = difficulty; //sätter difficulty
    }
}
