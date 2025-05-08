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
    public static class TimerEntityValueAPI
    {
        ///Keys
        public const int OnTimerStart = 14; // IEvent<float>
        public const int OnTimerEnd = 23; // IEvent
        public const int Cooldown = 12; // IValue<float>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent<float> GetOnTimerStart(this IEntity obj) => obj.GetValue<IEvent<float>>(OnTimerStart);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnTimerStart(this IEntity obj, out IEvent<float> value) => obj.TryGetValue(OnTimerStart, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnTimerStart(this IEntity obj, IEvent<float> value) => obj.AddValue(OnTimerStart, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnTimerStart(this IEntity obj) => obj.HasValue(OnTimerStart);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnTimerStart(this IEntity obj) => obj.DelValue(OnTimerStart);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnTimerStart(this IEntity obj, IEvent<float> value) => obj.SetValue(OnTimerStart, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetOnTimerEnd(this IEntity obj) => obj.GetValue<IEvent>(OnTimerEnd);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnTimerEnd(this IEntity obj, out IEvent value) => obj.TryGetValue(OnTimerEnd, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnTimerEnd(this IEntity obj, IEvent value) => obj.AddValue(OnTimerEnd, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnTimerEnd(this IEntity obj) => obj.HasValue(OnTimerEnd);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnTimerEnd(this IEntity obj) => obj.DelValue(OnTimerEnd);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnTimerEnd(this IEntity obj, IEvent value) => obj.SetValue(OnTimerEnd, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IValue<float> GetCooldown(this IEntity obj) => obj.GetValue<IValue<float>>(Cooldown);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCooldown(this IEntity obj, out IValue<float> value) => obj.TryGetValue(Cooldown, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCooldown(this IEntity obj, IValue<float> value) => obj.AddValue(Cooldown, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCooldown(this IEntity obj) => obj.HasValue(Cooldown);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCooldown(this IEntity obj) => obj.DelValue(Cooldown);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCooldown(this IEntity obj, IValue<float> value) => obj.SetValue(Cooldown, value);
    }
}
