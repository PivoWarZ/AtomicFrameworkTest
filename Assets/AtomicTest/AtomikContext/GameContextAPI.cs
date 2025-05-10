/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Contexts;
using System.Runtime.CompilerServices;
using Atomic.Entities;
using Atomic.Elements;
using System.Collections.Generic;
using testAtomic;

namespace testAtomic
{
	public static class GameContextAPI
	{
		///Keys
		public const int PlayerInput = 1; // MoveInput
		public const int PlayerShoot = 5; // ShootInput
		public const int TimerContext = 2; // TimerInstall
		public const int SpawnerLocator = 3; // SpawnerLocator


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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TimerInstall GetTimerContext(this IContext obj) => obj.ResolveValue<TimerInstall>(TimerContext);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTimerContext(this IContext obj, out TimerInstall value) => obj.TryResolveValue(TimerContext, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTimerContext(this IContext obj, TimerInstall value) => obj.AddValue(TimerContext, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTimerContext(this IContext obj) => obj.DelValue(TimerContext);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTimerContext(this IContext obj, TimerInstall value) => obj.SetValue(TimerContext, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTimerContext(this IContext obj) => obj.HasValue(TimerContext);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static SpawnerLocator GetSpawnerLocator(this IContext obj) => obj.ResolveValue<SpawnerLocator>(SpawnerLocator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetSpawnerLocator(this IContext obj, out SpawnerLocator value) => obj.TryResolveValue(SpawnerLocator, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddSpawnerLocator(this IContext obj, SpawnerLocator value) => obj.AddValue(SpawnerLocator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelSpawnerLocator(this IContext obj) => obj.DelValue(SpawnerLocator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetSpawnerLocator(this IContext obj, SpawnerLocator value) => obj.SetValue(SpawnerLocator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasSpawnerLocator(this IContext obj) => obj.HasValue(SpawnerLocator);
    }
}
