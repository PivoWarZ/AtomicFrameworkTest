using System;
using Atomic.Contexts;
using UnityEngine;
using ZombieShooter;

namespace ZombieShooter
{
    [Serializable]
    public class ZombieShooterContext: SceneContextInstallerBase
    {
        [SerializeField] ServiceLocator _serviceLocator;
        [SerializeField] MoveInput _moveInput;
        public override void Install(IContext context)
        {
            context.AddServiceLocator(_serviceLocator);

            context.AddMoveInput(_moveInput);
            
            context.AddSystem(_moveInput);
            context.AddSystem(new PlayerMoveBehavior());

        }
    }
}