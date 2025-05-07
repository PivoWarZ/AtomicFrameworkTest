using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class TowerBehavior: IEntityInit, IEntityEnable, IEntityDisable
    {
        private float _cooldown;
        private IEvent<float> _onTimerStart;
        private IEvent _onShoot;
        
        void IEntityInit.Init(IEntity entity)
        {
            _cooldown = entity.GetCooldown().Value;
            _onTimerStart = entity.GetOnTimerStart();
            _onShoot = entity.GetOnShootRequest();
            
            entity.GetOnTimerEnd().Subscribe(Reload);
        }

        void IEntityEnable.Enable(IEntity entity)
        {
           _onTimerStart.Invoke(_cooldown);
        }

        private void Reload()
        {
            _onShoot.Invoke();
            _onTimerStart.Invoke(_cooldown); 
        }

        void IEntityDisable.Disable(IEntity entity)
        {
            entity.GetOnTimerEnd().Unsubscribe(Reload);
        }
    }
}