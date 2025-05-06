using Atomic.Entities;
using System;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class MoveInstall: IEntityInit
    {
        [SerializeField] private float _moveSpeed = 10f;
        [SerializeField] private Vector3 _moveDirection = Vector3.zero;

        public void Init(IEntity entity)
        {
            entity.AddMoveDirection(_moveDirection);
            entity.AddMoveSpeed(_moveSpeed);
        }
    }
}
