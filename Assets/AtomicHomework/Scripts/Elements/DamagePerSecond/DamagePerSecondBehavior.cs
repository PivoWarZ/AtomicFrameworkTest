using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class DamagePerSecondBehavior: IEntityInit, IEntityEnable, IEntityUpdate, IEntityDispose
    {
        private Timer _timer;
        private IEvent _dealDamage;
        private float _coolDown;
        
        void IEntityInit.Init(IEntity entity)
        {
            _dealDamage = entity.GetDealTickDamage();
            _coolDown = entity.GetDamageColdown().Value;
            _timer = new Timer();
            _timer.Duration = _coolDown;
            _timer.Loop = true;
        }

        void IEntityEnable.Enable(IEntity entity)
        {
            _timer.OnEnded += DealDamage;
        }
        
        private void DealDamage()
        {
            _dealDamage.Invoke();
        }

        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            var canDamage = entity.GetCanDamagePerSecond().Value;

            if (_timer.CurrentState != Timer.State.PLAYING && canDamage)
            {
                DealDamage();
                _timer.Start();
            }

            if (canDamage)
            {
                _timer.Tick(deltaTime);
                return;
            }

            _timer.Stop();
        }

        void IEntityDispose.Dispose(IEntity entity)
        {
            _timer.OnEnded -= DealDamage;
        }
    }
}