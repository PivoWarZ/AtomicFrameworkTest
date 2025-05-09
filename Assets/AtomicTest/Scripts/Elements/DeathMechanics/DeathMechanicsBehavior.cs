using System.Net;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class DeathMechanicsBehavior: IEntityInit
    {
        private Transform _poolTransform;
        private Transform _entityTransform;
        private DeathSettings _deathSettings;
        
        public void Init(IEntity entity)
        {
            _poolTransform = entity.GetPoolTransform();
            _entityTransform = entity.GetEntityTransform();
            _deathSettings = entity.GetDeathSettings();
            entity.GetOnHitPointsEmpty().Subscribe(DeathMechanics);
        }

        private void DeathMechanics()
        {
            if (_deathSettings.DestroyObject)
            {
                SceneEntity.Destroy(_entityTransform.gameObject);
                return;
            }
            
            var gameObject = _entityTransform.gameObject;
            
            SetGameObject(gameObject);
            
            var collider = GetCollider(gameObject);
            
            SetCollider(collider);

            var rigidBody = GetRigidbody(gameObject);
            
            SetRigidbody(rigidBody);
        }

        private void SetRigidbody(Rigidbody rigidBody)
        {
            rigidBody.isKinematic = _deathSettings.IsKinematic;
            rigidBody.useGravity = _deathSettings.UseGravity;
        }

        private void SetGameObject(GameObject gameObject)
        {
            gameObject.SetActive(_deathSettings.SetActive);

            if (_deathSettings.ReturnToPool)
            {
                gameObject.transform.SetParent(_poolTransform);
            }
        }

        private void SetCollider(Collider collider)
        {
            collider.enabled = _deathSettings.ColliderEnabled;

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
    }
}