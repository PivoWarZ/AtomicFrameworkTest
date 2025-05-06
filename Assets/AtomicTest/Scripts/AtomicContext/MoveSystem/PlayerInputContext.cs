using Atomic.Contexts;
using testAtomic;
using UnityEngine;

namespace testAtomic
{
    public class PlayerInputContext: SceneContextInstallerBase
    {
        [SerializeField] private MoveInput _moveInput;
        [SerializeField] private PlayerInputController _playerInputController;
        public override void Install(IContext context)
        {
            context.AddPlayerInput(_moveInput);
            
            _playerInputController.Init(context);
            
            context.AddSystem(_moveInput);
        }
    }
}