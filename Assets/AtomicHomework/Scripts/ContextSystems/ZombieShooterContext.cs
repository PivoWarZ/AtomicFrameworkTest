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
        [SerializeField] private SpawnerContextInstaller _spawner;
        public override void Install(IContext context)
        {
            context.AddServiceLocator(_serviceLocator);

            context.AddMoveInput(_moveInput);
            context.AddShootInput(_shootInput);
            context.AddSpawner(_spawner);
            
            _spawner.Install(context);
            
            context.AddSystem(_moveInput);
            context.AddSystem(_shootInput);
            context.AddSystem(new PlayerMoveBehavior());
            context.AddSystem(new ShootController());
            context.AddSystem(new SetEnemyBehavior());
        }
    }
}