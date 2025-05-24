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
    public static class SkillsEntityValueAPI
    {
        ///Keys
        public const int OnKick = 32; // IEvent


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetOnKick(this IEntity obj) => obj.GetValue<IEvent>(OnKick);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnKick(this IEntity obj, out IEvent value) => obj.TryGetValue(OnKick, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnKick(this IEntity obj, IEvent value) => obj.AddValue(OnKick, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnKick(this IEntity obj) => obj.HasValue(OnKick);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnKick(this IEntity obj) => obj.DelValue(OnKick);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnKick(this IEntity obj, IEvent value) => obj.SetValue(OnKick, value);
    }
}
