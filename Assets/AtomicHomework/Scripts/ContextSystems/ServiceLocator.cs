using System;
using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    [Serializable]
    public class ServiceLocator
    {
        [Header("Player")]
        [SerializeField] SceneEntity _player;
        [Header("Containers")]
        [SerializeField] private Transform _enemyContainer;
        
        public SceneEntity Player => _player;
        public Transform EnemyContainer => _enemyContainer;
    }
}