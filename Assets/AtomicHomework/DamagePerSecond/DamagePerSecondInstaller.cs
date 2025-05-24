using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using Event = Atomic.Elements.Event;

namespace ZombieShooter
{
    [Serializable]
    public class DamagePerSecondInstaller: IEntityInstaller
    {
        [SerializeField] private ReactiveVariable<float> _damageColdown = new(1f);
        [SerializeField] private AndExpression _canDamagePerSecond;
        public void Install(IEntity entity)
        {
            entity.AddDamageColdown(_damageColdown);
            entity.AddDealTickDamage(new Event());
            entity.AddCanDamagePerSecond(_canDamagePerSecond);
        }
    }
}