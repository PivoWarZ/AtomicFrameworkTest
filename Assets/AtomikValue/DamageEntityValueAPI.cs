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
    public static class DamageEntityValueAPI
    {
        ///Keys
        public const int Damage = 24; // float
        public const int HitPowerForDamage = 34; // float


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GetDamage(this IEntity obj) => obj.GetValue<float>(Damage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDamage(this IEntity obj, out float value) => obj.TryGetValue(Damage, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDamage(this IEntity obj, float value) => obj.AddValue(Damage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDamage(this IEntity obj) => obj.HasValue(Damage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDamage(this IEntity obj) => obj.DelValue(Damage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDamage(this IEntity obj, float value) => obj.SetValue(Damage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GetHitPowerForDamage(this IEntity obj) => obj.GetValue<float>(HitPowerForDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetHitPowerForDamage(this IEntity obj, out float value) => obj.TryGetValue(HitPowerForDamage, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddHitPowerForDamage(this IEntity obj, float value) => obj.AddValue(HitPowerForDamage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasHitPowerForDamage(this IEntity obj) => obj.HasValue(HitPowerForDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelHitPowerForDamage(this IEntity obj) => obj.DelValue(HitPowerForDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetHitPowerForDamage(this IEntity obj, float value) => obj.SetValue(HitPowerForDamage, value);
    }
}
