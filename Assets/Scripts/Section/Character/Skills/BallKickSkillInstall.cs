using System;
using Atomic.Entities;
using UnityEngine;
using Event = Atomic.Elements.Event;

namespace ZombieShooter
{
    [Serializable]
    public class BallKickSkillInstall: IEntityInstaller
    {
        public Event OnKick;

        [SerializeField] private float _kickForce;
        [SerializeField] private LayerMask _layerMaskToKick;
        [SerializeField] private float _rayOffset = 0.2f;
        [SerializeField] private float _distanceForKick = 3f;
        public void Install(IEntity entity)
        {
            entity.AddOnKick(OnKick);
        }

        public LayerMask LayerMaskToKick => _layerMaskToKick;
        public float RayOffset => _rayOffset;
        public float KickForce => _kickForce;
        public float DistanceForKick => _distanceForKick;
    }
}