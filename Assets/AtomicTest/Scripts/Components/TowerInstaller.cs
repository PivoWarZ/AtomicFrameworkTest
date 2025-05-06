using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class TowerInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private TransformInstall _rootTransform;
        [SerializeField] private RotateInstall _rotateInstall;
        [SerializeField] private LoockAtInstall _loockAtInstall;
        [SerializeField] private ShootInstall _shootInstall;
        public override void Install(IEntity entity)
        {
            _rotateInstall.Install(entity);
            _rootTransform.Init(entity);
            _loockAtInstall.Init(entity);
            _shootInstall.Install(entity);
            
            entity.AddBehaviour(new RotateBehavior());
            entity.AddBehaviour(new LockAtBehavior());
            entity.AddBehaviour(new ShootBehavior());
        }
    }
}
