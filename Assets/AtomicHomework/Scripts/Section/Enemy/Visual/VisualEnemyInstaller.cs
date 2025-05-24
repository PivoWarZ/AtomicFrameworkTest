using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class VisualEnemyInstaller: SceneEntityInstallerBase

    {
        [SerializeField] Animator _animator;
        [SerializeField] AnimationEventDispatcher _animationEventDispatcher;
        [SerializeField] ParticlesContainer _particlesContainer;

        public override void Install(IEntity entity)
        {
            entity.AddAnimator(_animator);
            entity.AddAnimationEventDispatcher(_animationEventDispatcher);
            entity.AddParticlesContainer(_particlesContainer);

            entity.AddBehaviour(new VisualEnemyBehavior());
        }
    }
}