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
        private Event<float> OnTimerStart;
        private Event OnTimerEnd;

        [SerializeField] private ReactiveVariable<float> _cooldown = 5f;
        
        public void Install(IEntity entity)
        {
            entity.AddCooldown(_cooldown);
            entity.AddOnTimerStart(OnTimerStart);
            entity.AddOnTimerEnd(OnTimerEnd);
        }
    }
}