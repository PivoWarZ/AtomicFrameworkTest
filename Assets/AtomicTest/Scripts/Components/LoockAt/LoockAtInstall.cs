using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class LoockAtInstall : IEntityInstaller
    {
        [SerializeField] private ReactiveVariable<Transform> _loockTransform;
        [SerializeField] private RotateInstall _rotateInstall;
        
        public void Install(IEntity entity)
        {
            entity.AddLoockAtTransform(_loockTransform);
            
            _rotateInstall.Install(entity);

            entity.AddBehaviour(new RotateBehavior());
        }
    }
}
