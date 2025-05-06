using Atomic.Elements;
using Atomic.Entities;
using System;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class ShootInstall: IEntityInstaller
    {
        public Event<IEntity> OnShoot;
        public event Action OnShootFired;
        [SerializeField] private SceneEntity _bulletPrefab;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private IVariable<bool> _canShoot;

        public void Install(IEntity entity)
        {
            entity.AddBulletPrefab(_bulletPrefab);
            entity.AddShootPoint(_shootPoint);
            entity.AddCanShoot(new ReactiveVariable<bool>(true));
            entity.AddOnShootFired(OnShootFired);
        }
    }
}
