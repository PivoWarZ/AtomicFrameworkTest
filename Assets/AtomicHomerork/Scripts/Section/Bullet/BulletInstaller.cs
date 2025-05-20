using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{

    public class BulletInstaller : SceneEntityInstallerBase
    {
        public Event<IEntity> OnEntityTriggerEnter;

        public float Damage;
        [SerializeField] private TransformInstall _bulletTransform;
        [SerializeField] private MoveInstall _moveInstall;
        [SerializeField] private BordersInstall _bordersInstall;

        public override void Install(IEntity entity)
        {
            entity.AddOnEntityTriggerEnter(OnEntityTriggerEnter);
            entity.AddDamage(Damage);
            
            _bulletTransform.Install(entity);
            _moveInstall.Install(entity);
            _bordersInstall.Install(entity);

            entity.AddBehaviour(new TransformPositionMoveBehavior());
            entity.AddBehaviour(new BulletBehavior());
            entity.AddBehaviour(new BordersBehavior());
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetEntity(out IEntity entity))
            {
                OnEntityTriggerEnter.Invoke(entity);
            }
        }
    }
}
