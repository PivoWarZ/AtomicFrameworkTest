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
    public static class EntityEntityValueAPI
    {
        ///Keys
        public const int EntityTransform = 16; // Transform
        public const int OnEntityTriggerEnter = 18; // IEvent<IEntity>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetEntityTransform(this IEntity obj) => obj.GetValue<Transform>(EntityTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetEntityTransform(this IEntity obj, out Transform value) => obj.TryGetValue(EntityTransform, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddEntityTransform(this IEntity obj, Transform value) => obj.AddValue(EntityTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasEntityTransform(this IEntity obj) => obj.HasValue(EntityTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelEntityTransform(this IEntity obj) => obj.DelValue(EntityTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetEntityTransform(this IEntity obj, Transform value) => obj.SetValue(EntityTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent<IEntity> GetOnEntityTriggerEnter(this IEntity obj) => obj.GetValue<IEvent<IEntity>>(OnEntityTriggerEnter);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnEntityTriggerEnter(this IEntity obj, out IEvent<IEntity> value) => obj.TryGetValue(OnEntityTriggerEnter, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnEntityTriggerEnter(this IEntity obj, IEvent<IEntity> value) => obj.AddValue(OnEntityTriggerEnter, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnEntityTriggerEnter(this IEntity obj) => obj.HasValue(OnEntityTriggerEnter);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnEntityTriggerEnter(this IEntity obj) => obj.DelValue(OnEntityTriggerEnter);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnEntityTriggerEnter(this IEntity obj, IEvent<IEntity> value) => obj.SetValue(OnEntityTriggerEnter, value);
    }
}
