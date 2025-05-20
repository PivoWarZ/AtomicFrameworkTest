using Atomic.Elements;
using Atomic.Entities;
using AtomicTest.Scripts.Elements.BulletStorage;
using Sirenix.Serialization;
using UnityEngine;

namespace testAtomic
{
    public class CharacterInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private TransformInstall _entityTransform;
        [SerializeField] private MoveInstall _moveInstall;
        [SerializeField] private LoockAtInstall _loockAtInstall;
        [SerializeField] private ShootInstall _shootInstaller;
        [SerializeField] private BulletStorageInstall _bulletStorageInstall;
        [SerializeField] private TimerInstall _timerInstall;
        [SerializeField] private HitPointsInstall _hitPointsInstall;
        [SerializeField] private BallKickSkillInstall _ballKickInstall;

        public override void Install(IEntity entity)
        {
            _hitPointsInstall.Install(entity);
            _entityTransform.Install(entity);
            _moveInstall.Install(entity);
            _loockAtInstall.Install(entity);
            _shootInstaller.Install(entity);
            _bulletStorageInstall.Install(entity);
            _ballKickInstall.Install(entity);
            _timerInstall.Install(entity);

            entity.AddBehaviour(new RigidbodyVelocityMoveBehavior());
            entity.AddBehaviour(new LoockMouseCursorBehavior());
            entity.AddBehaviour(new ShootBehavior());
            entity.AddBehaviour(new BulletStorageBehavior(_bulletStorageInstall.ReloadTime));
            entity.AddBehaviour(new HitPointsBehavior());
            entity.AddBehaviour(new BallKickSkillBehavior(
                _ballKickInstall.RayOffset, _ballKickInstall.LayerMaskToKick, 
                _ballKickInstall.KickForce, _ballKickInstall.DistanceForKick));
            entity.AddBehaviour(new TimerBehavior());

            SetCondition(entity);
        }
        
        private void SetCondition(IEntity entity)
        {
            entity.GetCanMove().Append(entity.GetIsAlive());
            entity.GetCanRotate().Append(entity.GetIsAlive());
            entity.GetCanShoot().Append(entity.GetIsAlive());
            entity.GetCanShoot().Append(entity.GetShootReady());
        }
    }
}
