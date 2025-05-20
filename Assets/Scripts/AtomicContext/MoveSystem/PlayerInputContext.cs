using Atomic.Contexts;
using UnityEngine;

namespace ZombieShooter
{
    public class PlayerInputContext: SceneContextInstallerBase
    {
        [SerializeField] private MoveInput _moveInput;
        [SerializeField] private TransformPositionInputController _transformPositionInputController;
        public override void Install(IContext context)
        {
            context.AddPlayerInput(_moveInput);
            
            _transformPositionInputController.Init(context);
            
            context.AddSystem(_moveInput);
        }
    }
}