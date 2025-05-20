using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class FireEnemyInstaller: SceneEntityInstallerBase
    {
        public Event<IEntity> OnEntityTriggerEnter;
        public Event<Collision> OnEntityCollisionEnter;
        public float Damage;
        
        [SerializeField] private TransformInstall _enemyTransform;
        [SerializeField] private MoveInstall _moveInstall;
        [SerializeField] private LoockAtInstall _loockAtInstall;
        [SerializeField] private HitPointsInstall _hitPointsInstall;
        [SerializeField] private DeathMechanicsInstall _deathMechanicsInstall;
        [SerializeField] private BordersInstall _bordersInstall;

        public override void Install(IEntity entity)
        {
            entity.AddOnEntityTriggerEnter(OnEntityTriggerEnter);
            entity.AddOnEntityCollisionEnter(OnEntityCollisionEnter);
            entity.AddBulletDamage(Damage);
            
            _hitPointsInstall.Install(entity);
            _enemyTransform.Install(entity);
            _moveInstall.Install(entity);
            _loockAtInstall.Install(entity);
            _deathMechanicsInstall.Install(entity);
            _bordersInstall.Install(entity);

            entity.AddBehaviour(new TransformPositionMoveBehavior());
            entity.AddBehaviour(new LoockAtBehavior());
            entity.AddBehaviour(new FireEnemyBehavior());
            entity.AddBehaviour(new HitPointsBehavior());
            entity.AddBehaviour(new DeathMechanicsBehavior());
            entity.AddBehaviour(new BordersBehavior());

            SetCondition(entity);
        }

        private void SetCondition(IEntity entity)
        {
            entity.GetCanMove().Append(entity.GetIsAlive());
            entity.GetCanRotate().Append(entity.GetIsAlive());
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetEntity(out IEntity entity))
            {
                OnEntityTriggerEnter.Invoke(entity);
            }
        }
        
                
        private void OnCollisionEnter(Collision collision)
        {
                OnEntityCollisionEnter.Invoke(collision);
        }
    }
}