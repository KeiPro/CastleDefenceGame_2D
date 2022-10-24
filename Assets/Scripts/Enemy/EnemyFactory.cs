using Enums;
using System;
using UnityEngine;

public class EnemyFactory
{
    public static Type GetEnemy(EnemyTypeEnum enemyType)
    {
        switch (enemyType)
        {
            case EnemyTypeEnum.KaKa:
                return typeof(KaKa);
            case EnemyTypeEnum.Yobin:
                return typeof(Yobin);
            case EnemyTypeEnum.Wobang:
                return typeof(Wobang);
            default:
                return null;
        }
    }
}

public class KaKa : Enemy
{
    public override void Init()
    {
        base.Init();
        SetName(GetType().Name);
    }
}

public class Yobin : Enemy
{
    public override void Init()
    {
        base.Init();
        SetName(GetType().Name);
    }
}

public class Wobang : Enemy
{
    public override void Init()
    {
        base.Init();
        SetName(GetType().Name);
    }
}
