using System;
using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    [Serializable]
    public class ShootController: IContextInit, IContextDispose
    {
        private SceneEntity _sceneEntity;
        private ShootInput _shootInput;
        
        public void Init(IContext context)
        {
            _sceneEntity = context.GetServiceLocator().Player;
            _shootInput = context.GetShootInput();
            
            _shootInput.OnShoot += Shoot;
        }

        private void Idle()
        {
           
        }

        private void Shoot()
        {
            _sceneEntity.GetOnShootRequest()?.Invoke();
        }

        public void Dispose(IContext context)
        {
            _shootInput.OnShoot -= Shoot;
        }
    }
}