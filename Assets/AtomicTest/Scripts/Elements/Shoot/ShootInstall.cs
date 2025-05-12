using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using Sirenix.OdinInspector;
using Event = Atomic.Elements.Event;

namespace testAtomic
{
    [Serializable]
    public class ShootInstall: IEntityInstaller
    {
        public Event OnShootRequest;
        public Event OnShootFired;
        
        [SerializeField] private SceneEntity _bulletPrefab;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private Transform _bulletContainer;
        [SerializeField] private AndExpression _canShoot;

        public void Install(IEntity entity)
        {
            entity.AddBulletPrefab(_bulletPrefab);
            entity.AddShootPoint(_shootPoint);
            entity.AddCanShoot(_canShoot);
            entity.AddOnShootFired(OnShootFired);
            entity.AddOnShootRequest(OnShootRequest);
            entity.AddBulletContainer(_bulletContainer);
        }

        [Button]
        private void Shoot()
        {
            OnShootRequest.Invoke();
        }
    }
}
