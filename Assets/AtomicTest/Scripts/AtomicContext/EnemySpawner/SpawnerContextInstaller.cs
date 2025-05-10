using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class SpawnerContextInstaller: SceneContextInstallerBase
    {
        [SerializeField] SpawnerLocator _spawnerLocator;
        [SerializeField] TimerInstall _timerInstall;
        
        public override void Install(IContext context)
        {
            context.AddSpawnerLocator(_spawnerLocator);
            context.AddTimerContext(_timerInstall);
            TimerBehavior behavior = new TimerBehavior();
            
            context.AddSystem(new EnemySpawnerContextBehavior());
            context.AddSystem(new TimerBehavior());
        }
    }
}