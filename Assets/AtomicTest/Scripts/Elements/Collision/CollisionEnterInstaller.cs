using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using Event = Atomic.Elements.Event;

namespace testAtomic
{
    [Serializable]
    public class CollisionEnterInstaller: IEntityInstaller
    {
        public Event<Collision> OnEntityCollisionEnter = new();
        public void Install(IEntity entity)
        {
            entity.AddOnEntityCollisionEnter(OnEntityCollisionEnter);
            Debug.Log("Collision Install");
        }

        private void OnCollisionEnter(Collision collision)
        {
            OnEntityCollisionEnter?.Invoke(collision);
            Debug.Log("Collision Enter");
        }
    }
}