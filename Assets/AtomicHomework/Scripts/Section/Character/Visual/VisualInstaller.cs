using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class VisualInstaller: SceneEntityInstallerBase
    {
        [SerializeField] Animator _animator;
        [SerializeField] AnimationEventDispatcher _animationEventDispatcher;
        public override void Install(IEntity entity)
        {
            entity.AddAnimator(_animator);
            entity.AddAnimationEventDispatcher(_animationEventDispatcher);

            entity.AddBehaviour(new VisualCharacterBehavior());
        }
    }
}