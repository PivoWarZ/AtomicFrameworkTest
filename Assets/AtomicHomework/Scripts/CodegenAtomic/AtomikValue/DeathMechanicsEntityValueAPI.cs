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
    public static class DeathMechanicsEntityValueAPI
    {
        ///Keys
        public const int DeathSettings = 4; // DeathSettings
        public const int PoolTransform = 5; // Transform


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DeathSettings GetDeathSettings(this IEntity obj) => obj.GetValue<DeathSettings>(DeathSettings);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDeathSettings(this IEntity obj, out DeathSettings value) => obj.TryGetValue(DeathSettings, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDeathSettings(this IEntity obj, DeathSettings value) => obj.AddValue(DeathSettings, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDeathSettings(this IEntity obj) => obj.HasValue(DeathSettings);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDeathSettings(this IEntity obj) => obj.DelValue(DeathSettings);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDeathSettings(this IEntity obj, DeathSettings value) => obj.SetValue(DeathSettings, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetPoolTransform(this IEntity obj) => obj.GetValue<Transform>(PoolTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetPoolTransform(this IEntity obj, out Transform value) => obj.TryGetValue(PoolTransform, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddPoolTransform(this IEntity obj, Transform value) => obj.AddValue(PoolTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasPoolTransform(this IEntity obj) => obj.HasValue(PoolTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelPoolTransform(this IEntity obj) => obj.DelValue(PoolTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetPoolTransform(this IEntity obj, Transform value) => obj.SetValue(PoolTransform, value);
    }
}
