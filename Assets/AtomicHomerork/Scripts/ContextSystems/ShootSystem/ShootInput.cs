using System;
using Atomic.Contexts;
using UnityEngine;

namespace ZombieShooter
{
    [Serializable]
    public class ShootInput: IContextUpdate
    {
        public event Action OnShoot;
        public event Action OnKick;
        
        [SerializeField] private KeyCode _shootKey;
        [SerializeField] private KeyCode _kickKey;
        void IContextUpdate.Update(IContext context, float deltaTime)
        {
            if (Input.GetKeyDown(_shootKey))
            {
                OnShoot?.Invoke();
                Debug.Log("Shoot Input");
            }
            else if (Input.GetKey(_kickKey))
            {
                OnKick?.Invoke();
            }
        }
    }
}