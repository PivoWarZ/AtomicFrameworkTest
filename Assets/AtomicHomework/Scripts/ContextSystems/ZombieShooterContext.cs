using System;
using Atomic.Contexts;
using UnityEngine;
using ZombieShooter;

namespace ZombieShooter
{
    [Serializable]
    public class ZombieShooterContext: SceneContextInstallerBase
    {
        [SerializeField] private ServiceLocator _serviceLocator;
        [SerializeField] private MoveInput _moveInput;
        [SerializeField] private ShootInput _shootInput;
        public override void Install(IContext context)
        {
            context.AddServiceLocator(_serviceLocator);

            context.AddMoveInput(_moveInput);
            context.AddShootInput(_shootInput);
            
            context.AddSystem(_moveInput);
            context.AddSystem(_shootInput);
            context.AddSystem(new PlayerMoveBehavior());
            context.AddSystem(new ShootController());
        }
    }
}