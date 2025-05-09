using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using Object = UnityEngine.Object;

namespace testAtomic
{
    [Serializable]
    public class MoveInstall: IEntityInstaller
    {
        [SerializeField] private float _moveSpeed = 10f;
        [SerializeField] ReactiveVariable<Vector3> _moveDirection = Vector3.zero;
        [SerializeField] public AndExpression CanMove;

        public void Install(IEntity entity)
        {
            SetCanMove(entity);
            
            entity.AddCanMove(CanMove);
            
            entity.AddMoveDirection(_moveDirection);
            entity.AddMoveSpeed(_moveSpeed);
        }

        private void SetCanMove(IEntity entity)
        {
            if (entity.TryGetIsAlive(out var isAlive))
            {
                CanMove.Append(isAlive);
            }
        }
    }
}
