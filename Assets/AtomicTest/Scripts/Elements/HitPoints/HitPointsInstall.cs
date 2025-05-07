using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class HitPointsInstall : IEntityInstaller
    {
        public Event<float> OnHit;

        [SerializeField] private ReactiveVariable<float> _hitpoints = 3;
        public ReactiveVariable<bool> IsAlive = true;

        public void Install(IEntity entity)
        {
            Debug.Log("Installing hitpoints");
            entity.AddOnHit(OnHit);
            entity.AddHitPoints(_hitpoints);
            entity.AddIsAlive(new ReactiveVariable<bool>(IsAlive.Value));
        }
    }
}
