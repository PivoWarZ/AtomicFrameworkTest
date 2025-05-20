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
    public static class BordersEntityValueAPI
    {
        ///Keys
        public const int BordersRange = 31; // float


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GetBordersRange(this IEntity obj) => obj.GetValue<float>(BordersRange);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBordersRange(this IEntity obj, out float value) => obj.TryGetValue(BordersRange, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBordersRange(this IEntity obj, float value) => obj.AddValue(BordersRange, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBordersRange(this IEntity obj) => obj.HasValue(BordersRange);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBordersRange(this IEntity obj) => obj.DelValue(BordersRange);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBordersRange(this IEntity obj, float value) => obj.SetValue(BordersRange, value);
    }
}
