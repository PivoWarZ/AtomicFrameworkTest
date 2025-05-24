using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.Serialization;

namespace ZombieShooter
{
    [Serializable]
    public class BulletsLimitBehavior: IEntityInstaller, IEntityInit, IEntityEnable, IEntityUpdate, IEntityDispose
    {
        [SerializeField] private ReactiveVariable<int> _bulletsLimit = new(10);
        [SerializeField] private float _recoveryTime = 2f;
        [SerializeField] private Timer _bulletsLimitTimer;
        private int _limitFull;
        
        public void Install(IEntity entity)
        {
            entity.AddBulletsLimit(_bulletsLimit);
        }

        void IEntityInit.Init(IEntity entity)
        {
            _limitFull = _bulletsLimit.Value;
            _bulletsLimitTimer.Duration = _recoveryTime;
            _bulletsLimitTimer.Loop = true;
        }

        void IEntityEnable.Enable(IEntity entity)
        {
            _bulletsLimitTimer.OnEnded += BulletRecovery;
            _bulletsLimit.Subscribe(BulletsLimitChanged);
            entity.GetOnShootEvent().Subscribe(ShootEvent);
        }

        private void BulletsLimitChanged(int obj)
        {
            if (_bulletsLimit.Value < _limitFull)
            {
                _bulletsLimitTimer.Start();
            }
            else
            {
                _bulletsLimitTimer.Stop();
            }
        }

        private void ShootEvent()
        {
            _bulletsLimit.Value--;
        }

        private void BulletRecovery()
        {
            _bulletsLimit.Value++;
        }

        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            _bulletsLimitTimer.Tick(deltaTime);
        }

        void IEntityDispose.Dispose(IEntity entity)
        {
            _bulletsLimitTimer.OnStopped -= BulletRecovery;

            entity.GetOnShootEvent().Unsubscribe(ShootEvent);
        }
    }
}