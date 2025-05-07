using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class HitPointsInstall : IEntityInstaller
    {
        public Event<int> OnHit;

        [SerializeField] private ReactiveVariable<float> _hitpoints = 3;
        [SerializeField] private ReactiveVariable<bool> _isDead = false;

        public void Install(IEntity entity)
        {
            entity.AddOnHit(OnHit);
            entity.AddHitPoints(_hitpoints);
            entity.AddIsDead(_isDead);
        }
    }
}
