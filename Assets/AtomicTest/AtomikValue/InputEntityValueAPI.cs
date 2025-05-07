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
    public static class InputEntityValueAPI
    {
        ///Keys
        public const int ForwardDirectionInput = 1; // UnityEngine.KeyCode
        public const int LeftDirectionInput = 2; // UnityEngine.KeyCode
        public const int RightDirectionInput = 3; // UnityEngine.KeyCode
        public const int DownDirectionInput = 4; // UnityEngine.KeyCode
        public const int MovableEntity = 5; // SceneEntity


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnityEngine.KeyCode GetForwardDirectionInput(this IEntity obj) => obj.GetValue<UnityEngine.KeyCode>(ForwardDirectionInput);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetForwardDirectionInput(this IEntity obj, out UnityEngine.KeyCode value) => obj.TryGetValue(ForwardDirectionInput, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddForwardDirectionInput(this IEntity obj, UnityEngine.KeyCode value) => obj.AddValue(ForwardDirectionInput, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasForwardDirectionInput(this IEntity obj) => obj.HasValue(ForwardDirectionInput);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelForwardDirectionInput(this IEntity obj) => obj.DelValue(ForwardDirectionInput);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetForwardDirectionInput(this IEntity obj, UnityEngine.KeyCode value) => obj.SetValue(ForwardDirectionInput, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnityEngine.KeyCode GetLeftDirectionInput(this IEntity obj) => obj.GetValue<UnityEngine.KeyCode>(LeftDirectionInput);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetLeftDirectionInput(this IEntity obj, out UnityEngine.KeyCode value) => obj.TryGetValue(LeftDirectionInput, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddLeftDirectionInput(this IEntity obj, UnityEngine.KeyCode value) => obj.AddValue(LeftDirectionInput, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasLeftDirectionInput(this IEntity obj) => obj.HasValue(LeftDirectionInput);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelLeftDirectionInput(this IEntity obj) => obj.DelValue(LeftDirectionInput);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetLeftDirectionInput(this IEntity obj, UnityEngine.KeyCode value) => obj.SetValue(LeftDirectionInput, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnityEngine.KeyCode GetRightDirectionInput(this IEntity obj) => obj.GetValue<UnityEngine.KeyCode>(RightDirectionInput);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetRightDirectionInput(this IEntity obj, out UnityEngine.KeyCode value) => obj.TryGetValue(RightDirectionInput, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddRightDirectionInput(this IEntity obj, UnityEngine.KeyCode value) => obj.AddValue(RightDirectionInput, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasRightDirectionInput(this IEntity obj) => obj.HasValue(RightDirectionInput);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelRightDirectionInput(this IEntity obj) => obj.DelValue(RightDirectionInput);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetRightDirectionInput(this IEntity obj, UnityEngine.KeyCode value) => obj.SetValue(RightDirectionInput, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnityEngine.KeyCode GetDownDirectionInput(this IEntity obj) => obj.GetValue<UnityEngine.KeyCode>(DownDirectionInput);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDownDirectionInput(this IEntity obj, out UnityEngine.KeyCode value) => obj.TryGetValue(DownDirectionInput, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDownDirectionInput(this IEntity obj, UnityEngine.KeyCode value) => obj.AddValue(DownDirectionInput, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDownDirectionInput(this IEntity obj) => obj.HasValue(DownDirectionInput);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDownDirectionInput(this IEntity obj) => obj.DelValue(DownDirectionInput);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDownDirectionInput(this IEntity obj, UnityEngine.KeyCode value) => obj.SetValue(DownDirectionInput, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SceneEntity GetMovableEntity(this IEntity obj) => obj.GetValue<SceneEntity>(MovableEntity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMovableEntity(this IEntity obj, out SceneEntity value) => obj.TryGetValue(MovableEntity, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMovableEntity(this IEntity obj, SceneEntity value) => obj.AddValue(MovableEntity, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMovableEntity(this IEntity obj) => obj.HasValue(MovableEntity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMovableEntity(this IEntity obj) => obj.DelValue(MovableEntity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMovableEntity(this IEntity obj, SceneEntity value) => obj.SetValue(MovableEntity, value);
    }
}
