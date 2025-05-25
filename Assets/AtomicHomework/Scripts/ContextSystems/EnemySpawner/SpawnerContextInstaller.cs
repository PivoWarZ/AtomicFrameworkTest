using System;
using System.Collections.Generic;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using Event = Atomic.Elements.Event;


namespace ZombieShooter
{
    [Serializable]
    public class SpawnerContextInstaller: IContextInstaller
    {
        public Event OnSpawn;
        public Event<IEntity> OnSpawnEvent;
        public AndExpression CanSpawn = new(true);
        
        [SerializeField] private List<SceneEntity> _enemies;
        [SerializeField] private ReactiveVariable<float> _spawnTime;
        [SerializeField] private List<Transform> _spawnPoints;
        public void Install(IContext context)
        {
            var container = context.GetServiceLocator().EnemyContainer;
            context.AddSystem(new EnemySpawnerContextBehavior(_enemies, _spawnTime, _spawnPoints, container));
        }
        
        public ReactiveVariable<float> SpawnTime => _spawnTime;
    }
}