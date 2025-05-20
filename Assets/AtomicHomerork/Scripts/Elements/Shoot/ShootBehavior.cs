using Atomic.Entities;
using Atomic.Elements;
using UnityEngine;

namespace ZombieShooter
{
    public class ShootBehavior : IEntityInit, IEntityDispose, IEntityEnable
    {
        private IEntity _sceneEntity;
        private SceneEntity _bulletPrefab;
        private Transform _shootPoint;
        private AndExpression _canShoot;

        void IEntityInit.Init(IEntity entity)
        {
            _sceneEntity = entity;
            _bulletPrefab = entity.GetBulletPrefab();
            _shootPoint = entity.GetShootPoint();
            _canShoot = entity.GetCanShoot();
        }
        
        void IEntityEnable.Enable(IEntity entity)
        {
            entity.GetOnShootRequest().Subscribe(Shoot);
        }
        
        private void Shoot()
        {
            if (_canShoot.Value)
            {
                var bullet = SceneEntity.Instantiate(_bulletPrefab, _shootPoint.position, Quaternion.identity, _sceneEntity.GetBulletContainer());

                bullet.GetMoveDirection().Value = _shootPoint.forward;

                _sceneEntity.GetOnShootFired()?.Invoke();
            }
        }
        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetOnShootRequest().Unsubscribe(Shoot);
        }

    }
}
