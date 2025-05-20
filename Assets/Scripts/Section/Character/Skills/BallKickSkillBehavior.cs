using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public sealed class BallKickSkillBehavior: IEntityInit, IEntityEnable, IEntityDispose
    {
        private readonly float _kickForce;
        private readonly float _rayOffset;
        private readonly float _distanceForKick;
        private readonly LayerMask _layerMask;
        private IEntity _entity;

        public BallKickSkillBehavior(float rayOffset,LayerMask layerMask, float kickForce, float distanceForKick)
        {
            _rayOffset = rayOffset;
            _layerMask = layerMask;
            _kickForce = kickForce;
            _distanceForKick = distanceForKick;
        }
        
        public void Init(IEntity entity)
        {
            _entity = entity;
        }

        void IEntityEnable.Enable(IEntity entity)
        {
            entity.GetOnKick().Subscribe(Kick);
        }

        private void Kick()
        {
            var entityPosition = _entity.GetEntityTransform().position;
            var rayPosition = new Vector3(entityPosition.x, entityPosition.y + _rayOffset, entityPosition.z);
            
            Ray ray = new Ray(rayPosition, _entity.GetEntityTransform().forward);
            
            if (Physics.Raycast(ray, out RaycastHit hit, _distanceForKick, _layerMask))
            {
                hit.rigidbody.AddForce(_entity.GetEntityTransform().forward.normalized * _kickForce, ForceMode.Impulse);
            }
        }

        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetOnKick().Unsubscribe(Kick);
        }
    }
}