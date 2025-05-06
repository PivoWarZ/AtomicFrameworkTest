using System;
using Atomic.Contexts;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class ShootInput: IContextUpdate
    {
        public event Action OnShoot;
        
        [SerializeField] private KeyCode _shootKey;
        void IContextUpdate.Update(IContext context, float deltaTime)
        {
            if (Input.GetKey(_shootKey))
            {
                OnShoot?.Invoke();
            }
        }
    }
}