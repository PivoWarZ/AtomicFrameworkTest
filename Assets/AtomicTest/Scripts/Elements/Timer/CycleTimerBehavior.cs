using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class CycleTimerBehavior: IEntityUpdate, IEntityInit, IEntityEnable
    {
        private float _timer;

        void IEntityInit.Init(IEntity entity)
        {
            SetSpreadTimer(entity);
        }

        public void Enable(IEntity entity)
        {
            entity.GetOnTimerStart().Invoke(_timer);
        }

        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            if (_timer <= 0)
            {
                return;
            }

            _timer -= deltaTime;
            
            if (_timer <= 0)
            {
                entity.GetOnTimerEnd().Invoke();
                SetSpreadTimer(entity);
            }
        }

        private void SetSpreadTimer(IEntity entity)
        {
            _timer = Random.Range(entity.GetCooldown().Value - entity.GetTimeSpread().Value, entity.GetCooldown().Value + entity.GetTimeSpread().Value);
        }
    }
}