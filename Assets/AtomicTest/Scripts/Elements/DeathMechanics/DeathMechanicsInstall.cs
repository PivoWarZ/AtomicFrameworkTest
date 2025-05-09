using System;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.Serialization;

namespace testAtomic
{
    [Serializable]
    public class DeathMechanicsInstall: IEntityInstaller
    {
        [NonSerialized] public DeathSettings DeathSettings;
        
        [Header("Destroy object settings")]
        [SerializeField] private bool _destroyObject = true;
        [SerializeField] private bool _setActive = false;
        [SerializeField] private bool _returnToPool = false;
        public Transform PoolTransform;
        
        [FormerlySerializedAs("_colliderDisabled")]
        [Header("Collider Settings")]
        [SerializeField] private bool _colliderEnabled = true;
        [SerializeField] private bool _isTrigger = false;
        
        [Header("RigidBody Settings")]
        [SerializeField] private bool _isKinematic = false;
        [SerializeField] private bool _useGravity = false;
        
        public void Install(IEntity entity)
        {
            DeathSettings = SetDeathSettings();
            entity.AddDeathSettings(DeathSettings);
            entity.AddPoolTransform(PoolTransform);
            
        }

        private DeathSettings SetDeathSettings()
        {
            var DeathSettings = new DeathSettings();
            DeathSettings.DestroyObject = _destroyObject;
            DeathSettings.SetActive = _setActive;
            DeathSettings.ReturnToPool = _returnToPool;
            DeathSettings.ColliderEnabled = _colliderEnabled;
            DeathSettings.IsTrigger = _isTrigger;
            DeathSettings.UseGravity = _useGravity;
            DeathSettings.IsKinematic = _isKinematic;
            
            return DeathSettings;
        }
    }
}