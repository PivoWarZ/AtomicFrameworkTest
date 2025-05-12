using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class TowerInstaller : SceneEntityInstallerBase
    {
        public Event<Collision> OnEntityCollisionEnter = new();
        
        [SerializeField] private TransformInstall _rootTransform;
        [SerializeField] private LoockAtInstall _loockAtInstall;
        [SerializeField] private TimerInstall _timerInstall;
        [SerializeField] private ShootInstall _shootInstall;
        [SerializeField] private HitPointsInstall _hitPointsInstall;
        [SerializeField] private float _hitPowerForDamage;
        [SerializeField] private DeathMechanicsInstall _deathMechanicsInstall;
        public override void Install(IEntity entity)
        {
            entity.AddOnEntityCollisionEnter(OnEntityCollisionEnter);
            entity.AddHitPowerForDamage(_hitPowerForDamage);
            
            _rootTransform.Install(entity);
            _loockAtInstall.Install(entity);
            _timerInstall.Install(entity);
            _shootInstall.Install(entity);
            _hitPointsInstall.Install(entity);
            _deathMechanicsInstall.Install(entity);
            
            entity.AddBehaviour(new CycleTimerBehavior());
            entity.AddBehaviour(new LoockAtBehavior());
            entity.AddBehaviour(new ShootBehavior());
            entity.AddBehaviour(new TowerBehavior());
            entity.AddBehaviour(new HitPointsBehavior());
            entity.AddBehaviour(new DeathMechanicsBehavior());

            SetCondition(entity);
        }

        private void SetCondition(IEntity entity)
        {
            entity.GetCanRotate().Append(entity.GetIsAlive());
            entity.GetCanShoot().Append(entity.GetIsAlive());
        }

        private void OnCollisionEnter(Collision collision)
        {
            OnEntityCollisionEnter?.Invoke(collision);
        }
    }
}
