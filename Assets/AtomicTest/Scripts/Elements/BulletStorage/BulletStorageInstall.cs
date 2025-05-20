using System;
using Atomic.Elements;
using Atomic.Entities;
using testAtomic;
using UnityEngine;

namespace AtomicTest.Scripts.Elements.BulletStorage
{
    [Serializable]
    public class BulletStorageInstall: IEntityInstaller
    {
        [SerializeField] int _maxBullets = 10;
        [SerializeField] private float _reloadTime = 2f;
        private ReactiveVariable<bool> _shootReady = new (true);

        public void Install(IEntity entity)
        {
            entity.AddMaxBullet(_maxBullets);
            entity.AddShootReady(_shootReady);
        }
        
        public float ReloadTime => _reloadTime;
    }
}