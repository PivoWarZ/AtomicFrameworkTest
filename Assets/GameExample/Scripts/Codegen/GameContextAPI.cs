/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Contexts;
using System.Runtime.CompilerServices;
using Atomic.Entities;
using Atomic.Elements;
using System.Collections.Generic;
using GameExample.Engine;
using testAtomic;

namespace testAtomic
{
	public static class GameContextAPI
	{
		///Keys
		public const int PlayerInput = 1; // MoveInput
		public const int PlayerShoot = 5; // ShootInput


		///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static MoveInput GetPlayerInput(this IContext obj) => obj.ResolveValue<MoveInput>(PlayerInput);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlayerInput(this IContext obj, out MoveInput value) => obj.TryResolveValue(PlayerInput, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerInput(this IContext obj, MoveInput value) => obj.AddValue(PlayerInput, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerInput(this IContext obj) => obj.DelValue(PlayerInput);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlayerInput(this IContext obj, MoveInput value) => obj.SetValue(PlayerInput, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerInput(this IContext obj) => obj.HasValue(PlayerInput);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ShootInput GetPlayerShoot(this IContext obj) => obj.ResolveValue<ShootInput>(PlayerShoot);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlayerShoot(this IContext obj, out ShootInput value) => obj.TryResolveValue(PlayerShoot, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerShoot(this IContext obj, ShootInput value) => obj.AddValue(PlayerShoot, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerShoot(this IContext obj) => obj.DelValue(PlayerShoot);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlayerShoot(this IContext obj, ShootInput value) => obj.SetValue(PlayerShoot, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerShoot(this IContext obj) => obj.HasValue(PlayerShoot);
    }
}
