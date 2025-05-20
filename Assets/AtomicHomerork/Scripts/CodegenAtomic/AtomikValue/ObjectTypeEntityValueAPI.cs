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
    public static class ObjectTypeEntityValueAPI
    {
        ///Keys
        public const int ObjectType = 1; // string
        public const int HealingType = 2; // string


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string GetObjectType(this IEntity obj) => obj.GetValue<string>(ObjectType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetObjectType(this IEntity obj, out string value) => obj.TryGetValue(ObjectType, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddObjectType(this IEntity obj, string value) => obj.AddValue(ObjectType, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasObjectType(this IEntity obj) => obj.HasValue(ObjectType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelObjectType(this IEntity obj) => obj.DelValue(ObjectType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetObjectType(this IEntity obj, string value) => obj.SetValue(ObjectType, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string GetHealingType(this IEntity obj) => obj.GetValue<string>(HealingType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetHealingType(this IEntity obj, out string value) => obj.TryGetValue(HealingType, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddHealingType(this IEntity obj, string value) => obj.AddValue(HealingType, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasHealingType(this IEntity obj) => obj.HasValue(HealingType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelHealingType(this IEntity obj) => obj.DelValue(HealingType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetHealingType(this IEntity obj, string value) => obj.SetValue(HealingType, value);
    }
}
