using Atomic.Contexts;
using UnityEngine;
using UnityEngine.Serialization;

namespace testAtomic
{
    public class PlayerInputContext: SceneContextInstallerBase
    {
        [SerializeField] private MoveInput _moveInput;
        [FormerlySerializedAs("_playerInputController")] [SerializeField] private TransformPositionInputController _transformPositionInputController;
        public override void Install(IContext context)
        {
            context.AddPlayerInput(_moveInput);
            
            _transformPositionInputController.Init(context);
            
            context.AddSystem(_moveInput);
        }
    }
}