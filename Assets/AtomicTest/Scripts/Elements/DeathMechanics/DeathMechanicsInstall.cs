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
        [SerializeField] private bool _isDestroyObject = true;
        [SerializeField] private bool _isSetActive = false;
        [SerializeField] private bool _isReturnToPool = false;
        [SerializeField] private Transform _poolTransform;

        [FormerlySerializedAs("_isComponentDestroy")]
        [Header("Hide component")]
        [SerializeField] bool _isComponentHided = false;
        [SerializeField] private Transform _hidedComponent;

        [FormerlySerializedAs("_colliderEnabled")]
        [Header("Collider Settings")]
        [SerializeField] private bool _isColliderEnabled = true;
        [SerializeField] private bool _isTrigger = false;
        
        [Header("RigidBody Settings")]
        [SerializeField] private bool _isKinematic = false;
        [SerializeField] private bool _isUseGravity = false;
        
        public void Install(IEntity entity)
        {
            DeathSettings = SetDeathSettings();
            entity.AddDeathSettings(DeathSettings);
        }

        private DeathSettings SetDeathSettings()
        {
            var DeathSettings = new DeathSettings();
            DeathSettings.PoolTransform = _poolTransform;
            DeathSettings.HidedComponentTransform = _hidedComponent;
            DeathSettings.IsDestroyObject = _isDestroyObject;
            DeathSettings.IsComponentHided = _isComponentHided;
            DeathSettings.IsSetActive = _isSetActive;
            DeathSettings.IsReturnToPool = _isReturnToPool;
            DeathSettings.IsColliderEnabled = _isColliderEnabled;
            DeathSettings.IsTrigger = _isTrigger;
            DeathSettings.IsUseGravity = _isUseGravity;
            DeathSettings.IsKinematic = _isKinematic;
            
            return DeathSettings;
        }
    }
}