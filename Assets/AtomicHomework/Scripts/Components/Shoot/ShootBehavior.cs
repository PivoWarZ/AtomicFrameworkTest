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
        private IEvent _onShootEvent;
        

        void IEntityInit.Init(IEntity entity)
        {
            _sceneEntity = entity;
            _bulletPrefab = entity.GetBulletPrefab();
            _shootPoint = entity.GetShootPoint();
            _canShoot = entity.GetCanShoot();
            _onShootEvent = entity.GetOnShootEvent();

        }
        
        void IEntityEnable.Enable(IEntity entity)
        {
            entity.GetOnShootAction().Subscribe(Shoot);
        }

        private void Shoot()
        {
            if (_canShoot.Value)
            {
                var bullet = SceneEntity.Instantiate(_bulletPrefab, _shootPoint.position, Quaternion.identity, _sceneEntity.GetBulletContainer());

                bullet.GetMoveDirection().Value = _shootPoint.forward;
                
                _onShootEvent.Invoke();
            }
        }
        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetOnShootRequest().Unsubscribe(Shoot);
        }

    }
}
