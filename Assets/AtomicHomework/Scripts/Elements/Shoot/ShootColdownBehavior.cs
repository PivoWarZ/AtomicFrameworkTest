using System;
using Atomic.Elements;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ZombieShooter
{
    [Serializable]
    public class ShootColdownBehavior: IEntityInstaller, IEntityInit, IEntityEnable, IEntityUpdate, IEntityDispose
    {
        [SerializeField] private float _shootColdown = 1f;
        [SerializeField] private Timer _shootColdownTimer;
        
        [ShowInInspector] private ReactiveVariable<bool> _isShootReady = new(true);

        public void Install(IEntity entity)
        {
            entity.AddIsShootReady(_isShootReady);
        }

        void IEntityInit.Init(IEntity entity)
        {
            _shootColdownTimer.Loop = false;
            _shootColdownTimer.Duration = _shootColdown;
        }

        void IEntityEnable.Enable(IEntity entity)
        {
            entity.GetOnShootEvent().Subscribe(StartColdown);
            _shootColdownTimer.OnEnded += ColdownOver;
        }

        private void ColdownOver()
        {
            _isShootReady.Value = true;
        }

        private void StartColdown()
        {
            _shootColdownTimer.Start();
            _isShootReady.Value = false;
        }

        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            _shootColdownTimer.Tick(deltaTime);
        }

        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetOnShootEvent().Unsubscribe(StartColdown);
            _shootColdownTimer.OnEnded -= ColdownOver;
        }
    }
}