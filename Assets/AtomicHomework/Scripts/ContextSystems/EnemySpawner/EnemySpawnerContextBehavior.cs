using System.Collections.Generic;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class EnemySpawnerContextBehavior: IContextInit, IContextEnable, IContextUpdate, IContextDispose
    {
        private List<SceneEntity> _enemiesPrefabs;
        private ReactiveVariable<float> _spawnTime;
        private List<Transform> _spawnPoints;
        private Transform _container;
        private Timer _spawnTimer;
        private SpawnerContextInstaller _spawner;

        public EnemySpawnerContextBehavior(List<SceneEntity>  entities, ReactiveVariable<float> spawnTime, List<Transform> spawnPoints, Transform container)
        {
            _enemiesPrefabs = entities;
            _spawnTime = spawnTime;
            _spawnPoints = spawnPoints;
            _container = container;
        }

        void IContextInit.Init(IContext context)
        {
            _spawner = context.GetSpawner();
            _spawnTimer = new Timer();
            _spawnTimer.Loop = true;
            _spawnTimer.Duration = _spawnTime.Value;
        }

        void IContextEnable.Enable(IContext context)
        {
            _spawnTimer.OnEnded += SpawnEnemy;
            context.GetSpawner().OnSpawn.Subscribe(StartTimer);
        }

        private void StartTimer()
        {
            _spawnTimer.Start();
        }

        private void SpawnEnemy()
        {
            if (!_spawner.CanSpawn.Value)
            {
                return;
            }

            Transform randomPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];
            var prefab = _enemiesPrefabs[Random.Range(0, _enemiesPrefabs.Count-1)];
            Debug.Log($"Spawning {prefab.name}, {randomPoint.name}");
            SceneEntity enemy = SceneEntity.Instantiate(prefab, randomPoint);
            enemy.GetEntityTransform().SetParent(_container);
            
            _spawner.OnSpawnEvent.Invoke(enemy);
        }

        void IContextUpdate.Update(IContext context, float deltaTime)
        {
            _spawnTimer.Tick(deltaTime);
        }

        void IContextDispose.Dispose(IContext context)
        {
            _spawnTimer.OnEnded -= SpawnEnemy;
            context.GetSpawner().OnSpawn.Unsubscribe(StartTimer);
        }
    }
}