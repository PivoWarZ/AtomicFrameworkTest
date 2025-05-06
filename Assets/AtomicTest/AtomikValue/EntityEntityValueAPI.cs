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
    }
}
