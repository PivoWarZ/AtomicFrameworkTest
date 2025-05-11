using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class RotateInstall: IEntityInstaller
    {
        [SerializeField] private ReactiveVariable<Vector3> _rotateDirection = Vector3.zero;
        [SerializeField] private AndExpression CanRotate = new();
        [SerializeField] private float _rotateSpeed;

        public void Install(IEntity entity)
        {
            entity.AddCanRotate(CanRotate);
            entity.AddRotateDirection(_rotateDirection);
            entity.AddRotateSpeed(_rotateSpeed);
        }
    }
}
