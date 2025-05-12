using UnityEngine;

namespace testAtomic
{
    public struct DeathSettings
    {
        public Transform HidedComponentTransform;
        public Transform PoolTransform;
        public bool IsDestroyObject;
        public bool IsComponentHided;
        public bool IsSetActive;
        public bool IsReturnToPool;
        public bool IsColliderEnabled;
        public bool IsTrigger;
        public bool IsUseGravity;
        public bool IsKinematic;
    }
}