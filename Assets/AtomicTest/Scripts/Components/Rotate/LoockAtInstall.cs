using Atomic.Elements;
using Atomic.Entities;
using System;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class LoockAtInstall : IEntityInit
    {
        [SerializeField] private ReactiveVariable<Transform> _loockTransform;
        public void Init(IEntity entity)
        {
            entity.AddLoockAtTransform(_loockTransform);
        }
    }
}
