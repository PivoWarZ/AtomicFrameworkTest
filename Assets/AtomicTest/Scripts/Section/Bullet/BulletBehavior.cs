using System;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class BulletBehavior : IEntityInit
    {
        [SerializeField] private float _timeToDestroy = 5f;
        [SerializeField] private GameObject _gameObject;
        void IEntityInit.Init(IEntity entity)
        {
           SceneEntity.Destroy(_gameObject, _timeToDestroy);
        }
    }
}
