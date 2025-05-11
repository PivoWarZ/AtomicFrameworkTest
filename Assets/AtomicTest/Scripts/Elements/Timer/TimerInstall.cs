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
        [Header("For Cycle Behavior")]
        [SerializeField] private ReactiveVariable<float> _spread = 5f;
        
        public void Install(IEntity entity)
        {
            _spread = Mathf.Min(_cooldown.Value, _spread.Value);
            
            entity.AddTimeSpread(_spread);
            entity.AddCooldown(_cooldown);
            entity.AddOnTimerStart(OnTimerStart);
            entity.AddOnTimerEnd(OnTimerEnd);
        }
        
        public float Cooldown => _cooldown.Value;
    }
}