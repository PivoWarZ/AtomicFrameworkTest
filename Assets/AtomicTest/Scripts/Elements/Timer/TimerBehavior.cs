using System;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class TimerBehavior: IEntityUpdate, IEntityInit, IEntityDispose, IContextSystem
    {
        private float _timer;

        void IEntityInit.Init(IEntity entity)
        {
            entity.GetOnTimerStart().Subscribe(StartCountdown);
        }

        private void StartCountdown(float time)
        {
            _timer = time;
        }

        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            if (_timer <= 0)
            {
                return;
            }

            _timer -= deltaTime;
            
            if (_timer <= 0)
            {
                entity.GetOnTimerEnd().Invoke();
            }
        }

        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetOnTimerStart().Unsubscribe(StartCountdown);
        }
    }
}