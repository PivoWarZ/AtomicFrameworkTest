using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class ShootInputBehavior : IEntityUpdate
    {
        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            var _shootInput = entity.GetShootInput();

            if (Input.GetKeyDown(_shootInput))
            {
                var OnShoot = entity.GetOnShoot();
                OnShoot.Invoke(entity);
            }
        }
    }
}
