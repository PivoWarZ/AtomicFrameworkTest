using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class TowerInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private TransformInstall _rootTransform;
        [SerializeField] private LoockAtInstall _loockAtInstall;
        [SerializeField] private TimerInstall _timerInstall;
        [SerializeField] private ShootInstall _shootInstall;
        public override void Install(IEntity entity)
        {
            _rootTransform.Install(entity);
            _loockAtInstall.Install(entity);
            _timerInstall.Install(entity);
            _shootInstall.Install(entity);
            
            entity.AddBehaviour(new RotateBehavior());
            entity.AddBehaviour(new LoockAtBehavior());
            entity.AddBehaviour(new LoockAtBehavior());
            entity.AddBehaviour(new TimerBehavior());
            entity.AddBehaviour(new ShootBehavior());
        }
    }
}
