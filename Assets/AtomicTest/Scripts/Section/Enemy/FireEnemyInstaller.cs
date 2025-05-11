using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using System.Reflection;
using System;

namespace testAtomic
{
    public class FireEnemyInstaller: SceneEntityInstallerBase
    {
        public Event<IEntity> OnEntityTriggerEnter;

        public float Damage;
        [SerializeField] private TransformInstall _enemyTransform;
        [SerializeField] private MoveInstall _moveInstall;
        [SerializeField] private LoockAtInstall _loockAtInstall;
        [SerializeField] private HitPointsInstall _hitPointsInstall;
        [SerializeField] private DeathMechanicsInstall _deathMechanicsInstall;

        public override void Install(IEntity entity)
        {
            entity.AddOnEntityTriggerEnter(OnEntityTriggerEnter);
            entity.AddBulletDamage(Damage);
            
            _hitPointsInstall.Install(entity);
            _enemyTransform.Install(entity);
            _moveInstall.Install(entity);
            _loockAtInstall.Install(entity);
            _deathMechanicsInstall.Install(entity);

            entity.AddBehaviour(new TransformPositionMoveBehavior());
            entity.AddBehaviour(new LoockAtBehavior());
            entity.AddBehaviour(new FireEnemyBehavior());
            entity.AddBehaviour(new HitPointsBehavior());
            entity.AddBehaviour(new DeathMechanicsBehavior());
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