using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using Event = Atomic.Elements.Event;

namespace testAtomic
{
    [Serializable]
    public class TimerInstall: IEntityInstaller
    {
        public Event<float> OnTimerStart;
        public Event OnTimerEnd;

        [SerializeField] private ReactiveVariable<float> _cooldown = 5f;
        
        public void Install(IEntity entity)
        {
            entity.AddCooldown(_cooldown);
            entity.AddOnTimerStart(OnTimerStart);
            entity.AddOnTimerEnd(OnTimerEnd);
        }
    }
}