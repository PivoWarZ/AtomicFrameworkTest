using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{

    public class CharacterInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private TransformInstall _entityTransform;
        [SerializeField] private MoveInstall _moveInstall;
        [SerializeField] private RotateInstall _rotateInstall;
        [SerializeField] private ShootInputInstall _shootInputInstall;
        [SerializeField] private ShootInstall _shootInstaller;
        [SerializeField] private HitPointsInstall _hitPointsInstall;

        public override void Install(IEntity entity)
        {
            _entityTransform.Init(entity);
            _moveInstall.Init(entity);
            _rotateInstall.Install(entity);
            _shootInstaller.Install(entity);
            _shootInputInstall.Init(entity);
            _hitPointsInstall.Install(entity);

            entity.AddBehaviour(new MoveBehavior());
            entity.AddBehaviour(new RotateBehavior());
            entity.AddBehaviour(new ShootInputBehavior());
            entity.AddBehaviour(new ShootBehavior());
            entity.AddBehaviour(new HitPointsBehavior());
        }
    }
}
