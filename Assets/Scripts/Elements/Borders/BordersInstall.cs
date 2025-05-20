using System;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    [Serializable]
    public class BordersInstall: IEntityInstaller

    {
        [SerializeField] private float _zoneRange = 20f;

        public void Install(IEntity entity)
        {
            entity.AddBordersRange(_zoneRange);
        }
    }
}