using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using Event = Atomic.Elements.Event;

namespace ZombieShooter
{
    [Serializable]
    public class HitPointsInstall : IEntityInstaller
    {
        public Event<float> OnTakeDamageAction;
        public Event OnTakeDamageEvent;
        public Event OnHitPointsEmpty;

        [SerializeField] private ReactiveVariable<float> _hitpoints = 3;
        public ReactiveVariable<bool> IsAlive = new(true);

        public void Install(IEntity entity)
        {
            entity.AddOnHitPointsEmpty(OnHitPointsEmpty);
            entity.AddOnTakeDamageAction(OnTakeDamageAction);
            entity.AddOnTakeDamageEvent(OnTakeDamageEvent);
            entity.AddHitPoints(_hitpoints);
            entity.AddIsAlive(new ReactiveVariable<bool>(IsAlive.Value));
        }
    }
}
