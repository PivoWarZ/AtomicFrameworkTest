using System;
using Atomic.Elements;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;
using Event = Atomic.Elements.Event;

namespace testAtomic
{
    [Serializable]
    public class ShootInstall: IEntityInstaller
    {
        private Event OnShootRequest;
        private Event OnShootFired;
        
        [SerializeField] private SceneEntity _bulletPrefab;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private ReactiveVariable<bool> _canShoot;

        public void Install(IEntity entity)
        {
            entity.AddBulletPrefab(_bulletPrefab);
            entity.AddShootPoint(_shootPoint);
            entity.AddCanShoot(_canShoot);
            entity.AddOnShootFired(OnShootFired);
            entity.AddOnShootRequest(OnShootRequest);
        }
    }
}
