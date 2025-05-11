using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class TowerBehavior: IEntityInit, IEntityDisable
    {
        private IEvent _onShoot;
        
        void IEntityInit.Init(IEntity entity)
        {
            _onShoot = entity.GetOnShootRequest();
            
            entity.GetOnTimerEnd().Subscribe(Shoot);
        }

        private void Shoot()
        {
            _onShoot.Invoke();
        }

        void IEntityDisable.Disable(IEntity entity)
        {
            entity.GetOnTimerEnd().Unsubscribe(Shoot);
        }
    }
}