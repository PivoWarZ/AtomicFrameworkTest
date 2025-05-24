/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Contexts;
using System.Runtime.CompilerServices;
using Atomic.Entities;
using Atomic.Elements;
using System.Collections.Generic;
using ZombieShooter;

namespace ZombieShooter
{
	public static class GameContextAPI
	{
		///Keys
		public const int MoveInput = 1; // MoveInput
		public const int ServiceLocator = 2; // ServiceLocator
		public const int ShootInput = 3; // ShootInput
		public const int SpawnPoints = 4; // Transform[]


		///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static MoveInput GetMoveInput(this IContext obj) => obj.ResolveValue<MoveInput>(MoveInput);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveInput(this IContext obj, out MoveInput value) => obj.TryResolveValue(MoveInput, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveInput(this IContext obj, MoveInput value) => obj.AddValue(MoveInput, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveInput(this IContext obj) => obj.DelValue(MoveInput);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveInput(this IContext obj, MoveInput value) => obj.SetValue(MoveInput, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveInput(this IContext obj) => obj.HasValue(MoveInput);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ServiceLocator GetServiceLocator(this IContext obj) => obj.ResolveValue<ServiceLocator>(ServiceLocator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetServiceLocator(this IContext obj, out ServiceLocator value) => obj.TryResolveValue(ServiceLocator, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddServiceLocator(this IContext obj, ServiceLocator value) => obj.AddValue(ServiceLocator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelServiceLocator(this IContext obj) => obj.DelValue(ServiceLocator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetServiceLocator(this IContext obj, ServiceLocator value) => obj.SetValue(ServiceLocator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasServiceLocator(this IContext obj) => obj.HasValue(ServiceLocator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ShootInput GetShootInput(this IContext obj) => obj.ResolveValue<ShootInput>(ShootInput);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetShootInput(this IContext obj, out ShootInput value) => obj.TryResolveValue(ShootInput, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddShootInput(this IContext obj, ShootInput value) => obj.AddValue(ShootInput, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelShootInput(this IContext obj) => obj.DelValue(ShootInput);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetShootInput(this IContext obj, ShootInput value) => obj.SetValue(ShootInput, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasShootInput(this IContext obj) => obj.HasValue(ShootInput);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform[] GetSpawnPoints(this IContext obj) => obj.ResolveValue<Transform[]>(SpawnPoints);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetSpawnPoints(this IContext obj, out Transform[] value) => obj.TryResolveValue(SpawnPoints, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddSpawnPoints(this IContext obj, Transform[] value) => obj.AddValue(SpawnPoints, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelSpawnPoints(this IContext obj) => obj.DelValue(SpawnPoints);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetSpawnPoints(this IContext obj, Transform[] value) => obj.SetValue(SpawnPoints, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasSpawnPoints(this IContext obj) => obj.HasValue(SpawnPoints);
    }
}
