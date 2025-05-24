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
    public static class HitPointsEntityValueAPI
    {
        ///Keys
        public const int HitPoints = 20; // ReactiveVariable<float>
        public const int IsAlive = 21; // ReactiveVariable<bool>
        public const int OnTakeDamageAction = 22; // IEvent<float>
        public const int OnHitPointsEmpty = 3; // IEvent
        public const int OnTakeDamageEvent = 46; // IEvent


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
        public static ReactiveVariable<bool> GetIsAlive(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsAlive);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsAlive(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsAlive, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsAlive(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsAlive, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsAlive(this IEntity obj) => obj.HasValue(IsAlive);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsAlive(this IEntity obj) => obj.DelValue(IsAlive);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsAlive(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsAlive, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent<float> GetOnTakeDamageAction(this IEntity obj) => obj.GetValue<IEvent<float>>(OnTakeDamageAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnTakeDamageAction(this IEntity obj, out IEvent<float> value) => obj.TryGetValue(OnTakeDamageAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnTakeDamageAction(this IEntity obj, IEvent<float> value) => obj.AddValue(OnTakeDamageAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnTakeDamageAction(this IEntity obj) => obj.HasValue(OnTakeDamageAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnTakeDamageAction(this IEntity obj) => obj.DelValue(OnTakeDamageAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnTakeDamageAction(this IEntity obj, IEvent<float> value) => obj.SetValue(OnTakeDamageAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetOnHitPointsEmpty(this IEntity obj) => obj.GetValue<IEvent>(OnHitPointsEmpty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnHitPointsEmpty(this IEntity obj, out IEvent value) => obj.TryGetValue(OnHitPointsEmpty, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnHitPointsEmpty(this IEntity obj, IEvent value) => obj.AddValue(OnHitPointsEmpty, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnHitPointsEmpty(this IEntity obj) => obj.HasValue(OnHitPointsEmpty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnHitPointsEmpty(this IEntity obj) => obj.DelValue(OnHitPointsEmpty);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnHitPointsEmpty(this IEntity obj, IEvent value) => obj.SetValue(OnHitPointsEmpty, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetOnTakeDamageEvent(this IEntity obj) => obj.GetValue<IEvent>(OnTakeDamageEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnTakeDamageEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(OnTakeDamageEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnTakeDamageEvent(this IEntity obj, IEvent value) => obj.AddValue(OnTakeDamageEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnTakeDamageEvent(this IEntity obj) => obj.HasValue(OnTakeDamageEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnTakeDamageEvent(this IEntity obj) => obj.DelValue(OnTakeDamageEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnTakeDamageEvent(this IEntity obj, IEvent value) => obj.SetValue(OnTakeDamageEvent, value);
    }
}
