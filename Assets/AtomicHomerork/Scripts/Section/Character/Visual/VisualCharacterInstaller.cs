using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class VisualCharacterInstaller: SceneEntityInstallerBase
    {
        [SerializeField] Animator _animator;
        public override void Install(IEntity entity)
        {
            entity.AddAnimator(_animator);

            entity.AddBehaviour(new VisualCharacterBehavior());
        }
    }
}