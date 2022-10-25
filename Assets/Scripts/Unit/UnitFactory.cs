using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using System;

public partial class UnitFactory
{
    public static Type GetUnit(EntityTypeEnum entityType, int unitEnumIndex)
    {
        switch (entityType)
        {
            case EntityTypeEnum.Enemy:
                return CreateEnemyUnit((EnemyUnitTypeEnum)unitEnumIndex);

            case EntityTypeEnum.Alliance:
                return CreatePlayerUnit((PlayerUnitTypeEnum)unitEnumIndex);

            default:
                break;
        }

        return null;
    }

    private static Type CreateEnemyUnit(EnemyUnitTypeEnum enemyType)
    {
        switch (enemyType)
        {
            case EnemyUnitTypeEnum.KaKa:
                return typeof(KaKa);
            case EnemyUnitTypeEnum.Yobin:
                return typeof(Yobin);
            case EnemyUnitTypeEnum.Wobang:
                return typeof(Wobang);
            default:
                return null;
        }
    }

    private static Type CreatePlayerUnit(PlayerUnitTypeEnum playerUnitType)
    {
        switch (playerUnitType)
        {
            case PlayerUnitTypeEnum.Arma:
                return typeof(Arma);
            case PlayerUnitTypeEnum.Bora:
                return typeof(Bora);
            case PlayerUnitTypeEnum.Uni:
                return typeof(Uni);
            default:
                return null;
        }
    }
}
