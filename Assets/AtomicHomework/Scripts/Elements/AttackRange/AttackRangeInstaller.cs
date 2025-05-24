using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    [Serializable]
    public class AttackRangeInstaller: IEntityInstaller
    {
        [SerializeField] private ReactiveVariable<float> _enemyAttackDistance = new(1f);
        [SerializeField] private ReactiveVariable<bool> _isAttackDistance = new(false);


        public void Install(IEntity entity)
        {
            entity.AddEnemyAttackDistance(_enemyAttackDistance);
            entity.AddIsAttackDistance(_isAttackDistance);
        }
    }
}