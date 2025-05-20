using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class DeathMechanicsBehavior: IEntityInit, IEntityEnable, IEntityDispose
    {
        private GameObject _gameObject;
        private DeathSettings _deathSettings;
        private Transform _poolTransform;
        private Transform _entityTransform;
        
        public void Init(IEntity entity)
        {
            _deathSettings = entity.GetDeathSettings();
            _entityTransform = entity.GetEntityTransform();
            _gameObject = entity.GetEntityTransform().gameObject;
            _poolTransform = _deathSettings.PoolTransform;
        }

        void IEntityEnable.Enable(IEntity entity)
        {
            entity.GetOnHitPointsEmpty().Subscribe(DeathMechanics);
        }

        private void DeathMechanics()
        {
            if (_deathSettings.IsDestroyObject)
            {
                SceneEntity.Destroy(_entityTransform.gameObject);
                return;
            }
            
            SetGameObject(_gameObject);

            if (_deathSettings.IsComponentHided)
            {
                _deathSettings.HidedComponentTransform.gameObject.SetActive(false);
            }
            
            
            var collider = GetCollider(_gameObject);

            if (collider)
            {
                SetCollider(collider);
            }
            
            var rigidBody = GetRigidbody(_gameObject);

            if (rigidBody)
            {
                SetRigidbody(rigidBody);
            }

        }

        private void SetRigidbody(Rigidbody rigidBody)
        {
            rigidBody.isKinematic = _deathSettings.IsKinematic;
            rigidBody.useGravity = _deathSettings.IsUseGravity;
        }

        private void SetGameObject(GameObject gameObject)
        {
            gameObject.SetActive(_deathSettings.IsSetActive);

            if (_deathSettings.IsReturnToPool)
            {
                gameObject.transform.SetParent(_poolTransform);
            }
        }

        private void SetCollider(Collider collider)
        {
            collider.enabled = _deathSettings.IsColliderEnabled;

            collider.isTrigger = _deathSettings.IsTrigger;
        }

        private Collider GetCollider(GameObject gameObject)
        {
            var isCollider = gameObject.TryGetComponent<Collider>(out Collider collider);

            if (isCollider)
            {
                return collider;
            }

            return null;
        }
        
        private Rigidbody GetRigidbody(GameObject gameObject)
        {
            var isRigidBody = gameObject.TryGetComponent<Rigidbody>(out Rigidbody rigidbody);

            if (isRigidBody)
            {
                return rigidbody;
            }

            return null;
        }

        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetOnHitPointsEmpty().Unsubscribe(DeathMechanics);
        }
    }
}