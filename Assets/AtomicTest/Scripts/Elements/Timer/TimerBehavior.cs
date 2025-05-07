using System;
using Atomic.Elements;
using Atomic.Entities;

namespace testAtomic
{
    public class TimerBehavior: IEntityUpdate, IEntityInit, IEntityDispose
    {
        private float _timer;
        private bool _isCountdown = false;

        void IEntityInit.Init(IEntity entity)
        {
            entity.GetOnTimerStart().Subscribe(StartCountdown);
        }

        private void StartCountdown(float time)
        {
            _timer = time;
            _isCountdown = true;
        }

        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            if (!_isCountdown)
            {
                return;
            }

            _timer -= deltaTime;
            
            if (_timer <= 0)
            {
                entity.GetOnTimerEnd()?.Invoke();
                _isCountdown = false;
            }
        }

        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetOnTimerStart().Unsubscribe(StartCountdown);
        }
    }
}