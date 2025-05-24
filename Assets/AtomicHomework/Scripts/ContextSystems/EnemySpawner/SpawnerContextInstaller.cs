using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class SpawnerContextInstaller: SceneContextInstallerBase
    {
        [SerializeField] private SceneEntity[] _enemies;
        [SerializeField] private float  _spawnTime;
        [SerializeField] private Transform[] _spawnPoints;
        
        public override void Install(IContext context)
        {
            context.AddSpawnPoints(_spawnPoints);
            
            context.AddSystem(new EnemySpawnerContextBehavior());
        }
    }
}