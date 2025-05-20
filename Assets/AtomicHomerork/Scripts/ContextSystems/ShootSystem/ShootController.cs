using System;
using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    [Serializable]
    public class ShootController: IContextInit, IContextDispose
    {
        [SerializeField] private SceneEntity _sceneEntity;
        private ShootInput _shootInput;
        
        public void Init(IContext context)
        {
            //_shootInput = context.GetPlayerShoot();
            _shootInput.OnShoot += Shoot;
            _shootInput.OnKick += Kick;
        }

        private void Kick()
        {
            _sceneEntity.GetOnKick().Invoke();
        }

        private void Shoot()
        {
            _sceneEntity.GetOnShootRequest()?.Invoke();
        }

        public void Dispose(IContext context)
        {
            _shootInput.OnShoot -= Shoot;
            _shootInput.OnKick -= Kick;
        }
    }
}