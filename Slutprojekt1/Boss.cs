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


}
