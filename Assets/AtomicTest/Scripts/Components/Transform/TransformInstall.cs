using Atomic.Entities;
using System;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class TransformInstall : IEntityInit
    {
        [SerializeField] private Transform _transform;

        public void Init(IEntity entity)
        {
            entity?.AddEntityTransform(_transform);
        }
    }
}
