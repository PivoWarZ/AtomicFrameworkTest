using System;
using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    [Serializable]
    public class ServiceLocator
    {
        [SerializeField] SceneEntity _player;
        
        public SceneEntity Player => _player;
    }
}