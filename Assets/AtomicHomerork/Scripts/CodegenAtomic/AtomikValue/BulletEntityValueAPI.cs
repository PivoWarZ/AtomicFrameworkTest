/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using Atomic.Extensions;
using Unity.Mathematics;

namespace ZombieShooter
{
    public static class BulletEntityValueAPI
    {
        ///Keys
        public const int BulletDamage = 24; // float


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GetBulletDamage(this IEntity obj) => obj.GetValue<float>(BulletDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBulletDamage(this IEntity obj, out float value) => obj.TryGetValue(BulletDamage, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBulletDamage(this IEntity obj, float value) => obj.AddValue(BulletDamage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBulletDamage(this IEntity obj) => obj.HasValue(BulletDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBulletDamage(this IEntity obj) => obj.DelValue(BulletDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBulletDamage(this IEntity obj, float value) => obj.SetValue(BulletDamage, value);
    }
}
