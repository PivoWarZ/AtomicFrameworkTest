using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{

    public class BulletInstaller : SceneEntityInstallerBase
    {
        public Event<IEntity> OnEntityTriggerEnter;

        public float Damage;
        [SerializeField] private TransformInstall _bulletTransform;
        [SerializeField] private MoveInstall _moveInstall;

        public override void Install(IEntity entity)
        {
            entity.AddOnEntityTriggerEnter(OnEntityTriggerEnter);
            entity.AddBulletDamage(Damage);
            
            Debug.Log(entity.GetBulletDamage());
            
            _bulletTransform.Install(entity);
            _moveInstall.Install(entity);

            entity.AddBehaviour(new MoveBehavior());
            entity.AddBehaviour(new BulletBehavior());
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetEntity(out IEntity entity))
            {
                Debug.Log("OnTriggerEnter");
                OnEntityTriggerEnter.Invoke(entity);
            }
        }
    }
}
