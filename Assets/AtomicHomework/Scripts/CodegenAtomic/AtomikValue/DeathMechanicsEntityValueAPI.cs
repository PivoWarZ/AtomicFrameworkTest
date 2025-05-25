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
        public const int OnDeathAction = 47; // IEvent
        public const int OnDeathEvent = 48; // IEvent


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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetOnDeathAction(this IEntity obj) => obj.GetValue<IEvent>(OnDeathAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnDeathAction(this IEntity obj, out IEvent value) => obj.TryGetValue(OnDeathAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnDeathAction(this IEntity obj, IEvent value) => obj.AddValue(OnDeathAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnDeathAction(this IEntity obj) => obj.HasValue(OnDeathAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnDeathAction(this IEntity obj) => obj.DelValue(OnDeathAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnDeathAction(this IEntity obj, IEvent value) => obj.SetValue(OnDeathAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetOnDeathEvent(this IEntity obj) => obj.GetValue<IEvent>(OnDeathEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnDeathEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(OnDeathEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnDeathEvent(this IEntity obj, IEvent value) => obj.AddValue(OnDeathEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnDeathEvent(this IEntity obj) => obj.HasValue(OnDeathEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnDeathEvent(this IEntity obj) => obj.DelValue(OnDeathEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnDeathEvent(this IEntity obj, IEvent value) => obj.SetValue(OnDeathEvent, value);
    }
}
