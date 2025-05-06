/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using Atomic.Extensions;
using GameExample.Engine;
using Unity.Mathematics;

namespace testAtomic
{
    public static class HitPointsEntityValueAPI
    {
        ///Keys
        public const int HitPoints = 20; // ReactiveVariable<float>
        public const int IsDead = 21; // ReactiveVariable<bool>
        public const int OnHitEvent = 22; // IEvent<IEntity, int>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetHitPoints(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(HitPoints);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetHitPoints(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(HitPoints, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddHitPoints(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(HitPoints, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasHitPoints(this IEntity obj) => obj.HasValue(HitPoints);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelHitPoints(this IEntity obj) => obj.DelValue(HitPoints);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetHitPoints(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(HitPoints, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<bool> GetIsDead(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsDead);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsDead(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsDead, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsDead(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsDead, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsDead(this IEntity obj) => obj.HasValue(IsDead);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsDead(this IEntity obj) => obj.DelValue(IsDead);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsDead(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsDead, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent<IEntity, int> GetOnHitEvent(this IEntity obj) => obj.GetValue<IEvent<IEntity, int>>(OnHitEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnHitEvent(this IEntity obj, out IEvent<IEntity, int> value) => obj.TryGetValue(OnHitEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnHitEvent(this IEntity obj, IEvent<IEntity, int> value) => obj.AddValue(OnHitEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnHitEvent(this IEntity obj) => obj.HasValue(OnHitEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnHitEvent(this IEntity obj) => obj.DelValue(OnHitEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnHitEvent(this IEntity obj, IEvent<IEntity, int> value) => obj.SetValue(OnHitEvent, value);
    }
}
