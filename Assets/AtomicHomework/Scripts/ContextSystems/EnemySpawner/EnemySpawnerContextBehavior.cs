using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class EnemySpawnerContextBehavior: IContextInit, IContextEnable, IContextUpdate, IContextDispose
    {
        private SceneEntity _enemyPrefab;
        private Transform[] _spawnPoints;
        private Transform _character;
        private Transform _container;
        private TimerInstall _timer;
        private float _countdown;
        private float _spawnSpread;
        
        public void Init(IContext context)
        {
            //_enemyPrefab = context.GetSpawnerLocator().Enemy;
            //_spawnPoints = context.GetSpawnerLocator().SpawnPoints;
            //_character = context.GetSpawnerLocator().Character;
            //_timer = context.GetTimerContext();
            //_container = context.GetSpawnerLocator().Container;
            _countdown = Random.Range(_timer.Cooldown, _timer.Cooldown + _spawnSpread);
            _spawnSpread = _timer.Cooldown;
        }
        
        public void Enable(IContext context)
        {
            _timer.OnTimerEnd.Subscribe(SpawnEnemy);
            _timer.OnTimerStart.Invoke(_countdown);
        }

        private void SpawnEnemy()
        {
            Transform randomPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            var enemy = SceneEntity.Instantiate(_enemyPrefab, randomPoint);
            enemy.GetEntityTransform().SetParent(_container);
            //enemy.GetLoockAtTransform() = _character;
            _timer.OnTimerStart.Invoke(_timer.Cooldown);
            _countdown = Random.Range(_timer.Cooldown, _timer.Cooldown + _spawnSpread);
            _spawnSpread = _timer.Cooldown;
        }

        public void Update(IContext context, float deltaTime)
        {
            if (_countdown <= 0)
            {
                return;
            }

            _countdown -= deltaTime;
            
            if (_countdown <= 0)
            {
                _timer.OnTimerEnd.Invoke();
            }
        }

        public void Dispose(IContext context)
        {
            _timer.OnTimerEnd.Unsubscribe(SpawnEnemy);
        }
    }
}