using System;
using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter    
{
    [Serializable]
    public class MoveInput: IContextUpdate
    {
        [NonSerialized] public Event<Vector3> OnMove = new();

        
        [SerializeField] private KeyCode _forward;
        [SerializeField] private KeyCode _left;
        [SerializeField] private KeyCode _right;
        [SerializeField] private KeyCode _down;

        public void Update(IContext context, float deltaTime)
        {
            OnStay.Invoke();
            
            if (Input.GetKey(_forward))
            {
                OnForward?.Invoke();
            }
            else if (Input.GetKey(_left))
            {
                OnLeft?.Invoke();
            }
            else if (Input.GetKey(_right))
            {
                OnRight?.Invoke();
            }
            else if (Input.GetKey(_down))
            {
                OnBack?.Invoke();
            }
            
        }
    }
}