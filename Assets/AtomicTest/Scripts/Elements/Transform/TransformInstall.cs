using System;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class TransformInstall : IEntityInstaller
    {
        [SerializeField] private Transform _transform;

        public void Install(IEntity entity)
        {
            entity?.AddEntityTransform(_transform);
        }
    }
}
