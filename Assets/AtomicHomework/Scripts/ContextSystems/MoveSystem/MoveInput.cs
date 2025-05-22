using System;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.Serialization;

namespace ZombieShooter    
{
    [Serializable]
    public class MoveInput: IContextUpdate
    {
        public ReactiveVariable<Vector3> MoveDirection = Vector3.zero;

        
        [SerializeField] private KeyCode _forward;
        [SerializeField] private KeyCode _left;
        [SerializeField] private KeyCode _right;
        [SerializeField] private KeyCode _down;

        public void Update(IContext context, float deltaTime)
        {
            MoveDirection.Value = Vector3.zero;
            
            if (Input.GetKey(_forward))
            {
                MoveDirection.Value = Vector3.forward;
            }
            else if (Input.GetKey(_left))
            {
                MoveDirection.Value = -Vector3.right;
            }
            else if (Input.GetKey(_right))
            {
                MoveDirection.Value = Vector3.right;
            }
            else if (Input.GetKey(_down))
            {
                MoveDirection.Value = -Vector3.forward;
            }
            
        }
    }
}