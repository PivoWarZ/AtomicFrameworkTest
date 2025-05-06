using Atomic.Elements;
using Atomic.Entities;
using System;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class ShootInputInstall : IEntityInit
    {
        [SerializeField] private KeyCode _shootInput;
        public Event<IEntity> OnShoot;

        public void Init(IEntity entity)
        {
            entity.AddShootInput(_shootInput);
            entity.AddOnShoot(OnShoot);
        }
    }
}
