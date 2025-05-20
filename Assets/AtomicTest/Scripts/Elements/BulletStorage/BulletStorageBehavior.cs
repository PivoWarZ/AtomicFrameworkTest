using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class BulletStorageBehavior: IEntityUpdate, IEntityInit, IEntityDispose, IEntityEnable

    {
        private int _maxBullets;
        private float _reloadTime;
        private float _passedTime;

        public BulletStorageBehavior(float reloadTime)
        {
            _reloadTime = reloadTime;
        }

        public void Init(IEntity entity)
        {
            _maxBullets = entity.GetMaxBullet();
            _passedTime = _reloadTime;
        }

        void IEntityEnable.Enable(IEntity entity)
        {
            entity.GetOnShootFired().Subscribe(Shoot);
        }
        
        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            Debug.Log(_maxBullets);
            entity.GetShootReady().Value = _maxBullets > 0;
            
            _passedTime -= deltaTime;

            if (_passedTime <= 0)
            {
                _maxBullets++;
                if (_maxBullets > 10)
                    _maxBullets = 10;
                
                _passedTime = _reloadTime;
            }
        }


        private void Shoot()
        {
            _maxBullets--;
        }

        public void Dispose(IEntity entity)
        {
            entity.GetOnShootFired().Unsubscribe(Shoot);
        }

    }
}