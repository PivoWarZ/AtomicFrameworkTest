using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ZombieShooter
{
    [Serializable]
    public class MoveInstall: IEntityInstaller
    {
        [SerializeField] private float _moveSpeed = 10f;
        [SerializeField] private ReactiveVariable<Vector3> _moveDirection = Vector3.zero;
        [SerializeField] private AndExpression CanMove = new();

        public void Install(IEntity entity)
        {
            entity.AddCanMove(CanMove);
            
            entity.AddMoveDirection(_moveDirection);
            entity.AddMoveSpeed(_moveSpeed);
        }
    }
}
