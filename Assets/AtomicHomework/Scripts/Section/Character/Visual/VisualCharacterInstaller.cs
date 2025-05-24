using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class VisualCharacterInstaller: SceneEntityInstallerBase
    {
        [SerializeField] Animator _animator;
        [SerializeField] AnimationEventDispatcher _animationEventDispatcher;
        [SerializeField] ParticlesContainer _particleContainer;
        public override void Install(IEntity entity)
        {
            entity.AddAnimator(_animator);
            entity.AddAnimationEventDispatcher(_animationEventDispatcher);
            entity.AddParticlesContainer(_particleContainer);

            entity.AddBehaviour(new VisualCharacterBehavior());
        }
    }
}