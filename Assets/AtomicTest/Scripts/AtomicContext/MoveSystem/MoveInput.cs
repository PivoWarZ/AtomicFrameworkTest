using System;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic    
{
    [Serializable]
    public class MoveInput: IContextUpdate
    {
        public ReactiveVariable<Vector3> Move;
        
        [SerializeField] private KeyCode _forward;
        [SerializeField] private KeyCode _left;
        [SerializeField] private KeyCode _right;
        [SerializeField] private KeyCode _down;

        public void Update(IContext context, float deltaTime)
        {
            Move.Value = Vector3.zero;

            if (Input.GetKey(_forward))
            {
                Move.Value = Vector3.forward;
            }
            else if (Input.GetKey(_left))
            {
                Move.Value = Vector3.left;
            }
            else if (Input.GetKey(_right))
            {
                Move.Value = Vector3.right;
            }
            else if (Input.GetKey(_down))
            {
                Move.Value = -Vector3.forward;
            }
        }
    }
}