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
    public static class VisualEntityValueAPI
    {
        ///Keys
        public const int Animator = 27; // Animator
        public const int AnimationEventDispatcher = 36; // AnimationEventDispatcher
        public const int ParticlesContainer = 45; // ParticlesContainer


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Animator GetAnimator(this IEntity obj) => obj.GetValue<Animator>(Animator);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAnimator(this IEntity obj, out Animator value) => obj.TryGetValue(Animator, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAnimator(this IEntity obj, Animator value) => obj.AddValue(Animator, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAnimator(this IEntity obj) => obj.HasValue(Animator);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAnimator(this IEntity obj) => obj.DelValue(Animator);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAnimator(this IEntity obj, Animator value) => obj.SetValue(Animator, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AnimationEventDispatcher GetAnimationEventDispatcher(this IEntity obj) => obj.GetValue<AnimationEventDispatcher>(AnimationEventDispatcher);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAnimationEventDispatcher(this IEntity obj, out AnimationEventDispatcher value) => obj.TryGetValue(AnimationEventDispatcher, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAnimationEventDispatcher(this IEntity obj, AnimationEventDispatcher value) => obj.AddValue(AnimationEventDispatcher, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAnimationEventDispatcher(this IEntity obj) => obj.HasValue(AnimationEventDispatcher);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAnimationEventDispatcher(this IEntity obj) => obj.DelValue(AnimationEventDispatcher);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAnimationEventDispatcher(this IEntity obj, AnimationEventDispatcher value) => obj.SetValue(AnimationEventDispatcher, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticlesContainer GetParticlesContainer(this IEntity obj) => obj.GetValue<ParticlesContainer>(ParticlesContainer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetParticlesContainer(this IEntity obj, out ParticlesContainer value) => obj.TryGetValue(ParticlesContainer, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddParticlesContainer(this IEntity obj, ParticlesContainer value) => obj.AddValue(ParticlesContainer, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasParticlesContainer(this IEntity obj) => obj.HasValue(ParticlesContainer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelParticlesContainer(this IEntity obj) => obj.DelValue(ParticlesContainer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetParticlesContainer(this IEntity obj, ParticlesContainer value) => obj.SetValue(ParticlesContainer, value);
    }
}
