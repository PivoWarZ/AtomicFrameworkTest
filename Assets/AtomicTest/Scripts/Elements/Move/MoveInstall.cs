using System;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class MoveInstall: IEntityInstaller
    {
        [SerializeField] private float _moveSpeed = 10f;
        [SerializeField] private Vector3 _moveDirection = Vector3.zero;

        public void Install(IEntity entity)
        {
            entity.AddMoveDirection(_moveDirection);
            entity.AddMoveSpeed(_moveSpeed);
        }
    }
}
