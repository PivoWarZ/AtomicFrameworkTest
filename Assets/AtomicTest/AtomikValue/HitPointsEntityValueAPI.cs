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
        public const int OnHit = 22; // IEvent<int>


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
        public static IEvent<int> GetOnHit(this IEntity obj) => obj.GetValue<IEvent<int>>(OnHit);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnHit(this IEntity obj, out IEvent<int> value) => obj.TryGetValue(OnHit, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnHit(this IEntity obj, IEvent<int> value) => obj.AddValue(OnHit, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnHit(this IEntity obj) => obj.HasValue(OnHit);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnHit(this IEntity obj) => obj.DelValue(OnHit);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnHit(this IEntity obj, IEvent<int> value) => obj.SetValue(OnHit, value);
    }
}
