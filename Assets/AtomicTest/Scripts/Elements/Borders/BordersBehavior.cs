using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class BordersBehavior: IEntityFixedUpdate, IEntityInit

    {
        private float _zoneRange;

        void IEntityInit.Init(IEntity entity)
        {
            _zoneRange = entity.GetBordersRange();
        }
        
        public void OnFixedUpdate(IEntity entity, float deltaTime)
        {
            var position = entity.GetEntityTransform().position;

            if (EntityOutScene(position))
            {
                SceneEntity.Destroy(entity.GetEntityTransform().gameObject);
            }
        }
        
        private bool EntityOutScene(Vector3 position)
        {
            var posX = Mathf.Abs(position.x);
            var posY = Mathf.Abs(position.y);
            var posZ = Mathf.Abs(position.z);

            bool outX = posX >= _zoneRange;
            bool outY = posY >= _zoneRange;
            bool outZ = posZ >= _zoneRange;

            if (outX || outY || outZ)
            {
                return true;
            }
            
            return false;
        }
    }
}