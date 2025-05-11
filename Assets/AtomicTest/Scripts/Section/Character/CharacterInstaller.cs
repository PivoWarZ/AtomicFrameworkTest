using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class CharacterInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private TransformInstall _entityTransform;
        [SerializeField] private MoveInstall _moveInstall;
        [SerializeField] private LoockAtInstall _loockAtInstall;
        [SerializeField] private ShootInstall _shootInstaller;
        [SerializeField] private HitPointsInstall _hitPointsInstall;

        public override void Install(IEntity entity)
        {
            _hitPointsInstall.Install(entity);
            _entityTransform.Install(entity);
            _moveInstall.Install(entity);
            _loockAtInstall.Install(entity);
            _shootInstaller.Install(entity);

            entity.AddBehaviour(new TransformPositionMoveBehavior());
            entity.AddBehaviour(new LoockAtBehavior());
            entity.AddBehaviour(new ShootBehavior());
            entity.AddBehaviour(new HitPointsBehavior());
        }
    }
}
