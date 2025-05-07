using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class PlayerInputInstaller: SceneEntityInstallerBase
    {
        [SerializeField] private SceneEntity _sceneEntity;
        [SerializeField] private PlayerMoveInputInstall _moveInput;


        private IAction _action;

        // ReSharper disable Unity.PerformanceAnalysis
        public override void Install(IEntity entity)
        {
            entity.AddMovableEntity(_sceneEntity);

            entity.AddBehaviour(new PlayerInputBehavior()); 
            //entity.AddBehaviour(_moveInput);

            _moveInput.Install(entity);
        }
    }
}
