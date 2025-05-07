using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using Zenject.SpaceFighter;

namespace testAtomic
{

    public class BulletInstaller : SceneEntityInstallerBase
    {
        public Event<IEntity> OnEntityTriggerEnter;
        
        [SerializeField] private GameObject _gameObject;
        [SerializeField] private TransformInstall _bulletTransform;
        [SerializeField] private int _damage;
        [SerializeField] private MoveInstall _moveInstall;

        public override void Install(IEntity entity)
        {
            entity.AddOnEntityTriggerEnter(OnEntityTriggerEnter);
            entity.AddBulletDamage(_damage);
            
            _bulletTransform.Install(entity);
            _moveInstall.Install(entity);

            entity.AddBehaviour(new MoveBehavior());
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetEntity(out IEntity entity))
            {
                OnEntityTriggerEnter.Invoke(entity);
                Debug.Log("OnEntityTriggerEnter");
            }
        }
    }
}
