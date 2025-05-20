using System;
using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    [Serializable]
    public class SpawnerLocator
    {
        [SerializeField] private Transform[] _spawnPoints;
        [SerializeField] private SceneEntity _enemy;
        [SerializeField] private Transform _character;
        [SerializeField] private Transform _enemyContainer;

        public Transform[] SpawnPoints => _spawnPoints;
        public Transform Character => _character;
        public SceneEntity Enemy => _enemy;
        
        public Transform Container => _enemyContainer;
    }
}