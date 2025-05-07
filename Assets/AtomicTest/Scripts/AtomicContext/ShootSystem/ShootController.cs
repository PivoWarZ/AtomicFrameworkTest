using System;
using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class ShootController: IContextInit
    {
        [SerializeField] private SceneEntity _sceneEntity;
        private ShootInput _shootInput;
        
        public void Init(IContext context)
        {
            _shootInput = context.GetPlayerShoot();
            _shootInput.OnShoot += Shoot;
        }

        private void Shoot()
        {
            _sceneEntity.GetOnShootRequest()?.Invoke();
        }
    }
}