using Atomic.Elements;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ZombieShooter
{
    public class HunterEnemyInstaller: SceneEntityInstallerBase
    {
        [SerializeField] private float Damage;
        [SerializeField] private DamagePerSecondInstaller _damagePerSecond;
        [SerializeField] private AttackRangeInstaller _attackRange;
        
        [SerializeField] private TransformInstall _enemyTransform;
        [SerializeField] private MoveInstall _moveInstall;
        [SerializeField] private LoockAtInstall _loockAtInstall;
        [SerializeField] private HitPointsInstall _hitPointsInstall;
        [SerializeField] private DeathMechanicsInstaller deathMechanicsInstaller;
        [SerializeField] private BordersInstall _bordersInstall;

        public override void Install(IEntity entity)
        {
            entity.AddDamage(Damage);
            
            _hitPointsInstall.Install(entity);
            _enemyTransform.Install(entity);
            _moveInstall.Install(entity);
            _loockAtInstall.Install(entity);
            deathMechanicsInstaller.Install(entity);
            _bordersInstall.Install(entity);
            _attackRange.Install(entity);
            _damagePerSecond.Install(entity);
            
            entity.AddBehaviour(new DamagePerSecondBehavior());
            entity.AddBehaviour(new TransformPositionMoveBehavior());
            entity.AddBehaviour(new LoockAtBehavior());
            entity.AddBehaviour(new HunterEnemyBehavior());
            entity.AddBehaviour(new HitPointsBehavior());
            entity.AddBehaviour(new DeathMechanicsBehavior());
            entity.AddBehaviour(new BordersBehavior());
            entity.AddBehaviour(new AttackRangeBehavior());
            
            SetCondition(entity);
        }

        private void SetCondition(IEntity entity)
        {
            entity.GetCanMove().Append(entity.GetIsAlive());
            entity.GetCanMove().Append(() => !entity.GetIsAttackDistance().Value);
            
            entity.GetCanRotate().Append(entity.GetIsAlive());
            
            entity.GetCanDamagePerSecond().Append(() => entity.GetIsAttackDistance().Value);
            entity.GetCanDamagePerSecond().Append(() => entity.GetLoockAtTransform().gameObject.GetComponent<IEntity>().GetHitPoints().Value > 0f);
        }
    }
}