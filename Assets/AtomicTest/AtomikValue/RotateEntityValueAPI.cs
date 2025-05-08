/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using Atomic.Extensions;
using Unity.Mathematics;

namespace testAtomic
{
    public static class RotateEntityValueAPI
    {
        ///Keys
        public const int RotateSpeed = 8; // ReactiveVariable<float>
        public const int RotateDirection = 6; // ReactiveVariable<Vector3>
        public const int LoockAtTransform = 17; // ReactiveVariable<Transform>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetRotateSpeed(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(RotateSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetRotateSpeed(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(RotateSpeed, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddRotateSpeed(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(RotateSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasRotateSpeed(this IEntity obj) => obj.HasValue(RotateSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelRotateSpeed(this IEntity obj) => obj.DelValue(RotateSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetRotateSpeed(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(RotateSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<Vector3> GetRotateDirection(this IEntity obj) => obj.GetValue<ReactiveVariable<Vector3>>(RotateDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetRotateDirection(this IEntity obj, out ReactiveVariable<Vector3> value) => obj.TryGetValue(RotateDirection, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddRotateDirection(this IEntity obj, ReactiveVariable<Vector3> value) => obj.AddValue(RotateDirection, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasRotateDirection(this IEntity obj) => obj.HasValue(RotateDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelRotateDirection(this IEntity obj) => obj.DelValue(RotateDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetRotateDirection(this IEntity obj, ReactiveVariable<Vector3> value) => obj.SetValue(RotateDirection, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<Transform> GetLoockAtTransform(this IEntity obj) => obj.GetValue<ReactiveVariable<Transform>>(LoockAtTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetLoockAtTransform(this IEntity obj, out ReactiveVariable<Transform> value) => obj.TryGetValue(LoockAtTransform, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddLoockAtTransform(this IEntity obj, ReactiveVariable<Transform> value) => obj.AddValue(LoockAtTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasLoockAtTransform(this IEntity obj) => obj.HasValue(LoockAtTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelLoockAtTransform(this IEntity obj) => obj.DelValue(LoockAtTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetLoockAtTransform(this IEntity obj, ReactiveVariable<Transform> value) => obj.SetValue(LoockAtTransform, value);
    }
}
