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
    public static class ShootEntityValueAPI
    {
        ///Keys
        public const int BulletPrefab = 9; // SceneEntity
        public const int ShootPoint = 10; // Transform
        public const int Coldown = 12; // ReactiveVariable<float>
        public const int CanShoot = 13; // IVariable<bool>
        public const int OnShoot = 15; // IEvent<IEntity>
        public const int OnColdownEnded = 18; // IEvent<IEntity>
        public const int OnShootFired = 19; // System.Action


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SceneEntity GetBulletPrefab(this IEntity obj) => obj.GetValue<SceneEntity>(BulletPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBulletPrefab(this IEntity obj, out SceneEntity value) => obj.TryGetValue(BulletPrefab, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBulletPrefab(this IEntity obj, SceneEntity value) => obj.AddValue(BulletPrefab, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBulletPrefab(this IEntity obj) => obj.HasValue(BulletPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBulletPrefab(this IEntity obj) => obj.DelValue(BulletPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBulletPrefab(this IEntity obj, SceneEntity value) => obj.SetValue(BulletPrefab, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetShootPoint(this IEntity obj) => obj.GetValue<Transform>(ShootPoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetShootPoint(this IEntity obj, out Transform value) => obj.TryGetValue(ShootPoint, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddShootPoint(this IEntity obj, Transform value) => obj.AddValue(ShootPoint, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasShootPoint(this IEntity obj) => obj.HasValue(ShootPoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelShootPoint(this IEntity obj) => obj.DelValue(ShootPoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetShootPoint(this IEntity obj, Transform value) => obj.SetValue(ShootPoint, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetColdown(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(Coldown);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetColdown(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(Coldown, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddColdown(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(Coldown, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasColdown(this IEntity obj) => obj.HasValue(Coldown);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelColdown(this IEntity obj) => obj.DelValue(Coldown);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetColdown(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(Coldown, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IVariable<bool> GetCanShoot(this IEntity obj) => obj.GetValue<IVariable<bool>>(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanShoot(this IEntity obj, out IVariable<bool> value) => obj.TryGetValue(CanShoot, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanShoot(this IEntity obj, IVariable<bool> value) => obj.AddValue(CanShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanShoot(this IEntity obj) => obj.HasValue(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanShoot(this IEntity obj) => obj.DelValue(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanShoot(this IEntity obj, IVariable<bool> value) => obj.SetValue(CanShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent<IEntity> GetOnShoot(this IEntity obj) => obj.GetValue<IEvent<IEntity>>(OnShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnShoot(this IEntity obj, out IEvent<IEntity> value) => obj.TryGetValue(OnShoot, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnShoot(this IEntity obj, IEvent<IEntity> value) => obj.AddValue(OnShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnShoot(this IEntity obj) => obj.HasValue(OnShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnShoot(this IEntity obj) => obj.DelValue(OnShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnShoot(this IEntity obj, IEvent<IEntity> value) => obj.SetValue(OnShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent<IEntity> GetOnColdownEnded(this IEntity obj) => obj.GetValue<IEvent<IEntity>>(OnColdownEnded);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnColdownEnded(this IEntity obj, out IEvent<IEntity> value) => obj.TryGetValue(OnColdownEnded, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnColdownEnded(this IEntity obj, IEvent<IEntity> value) => obj.AddValue(OnColdownEnded, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnColdownEnded(this IEntity obj) => obj.HasValue(OnColdownEnded);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnColdownEnded(this IEntity obj) => obj.DelValue(OnColdownEnded);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnColdownEnded(this IEntity obj, IEvent<IEntity> value) => obj.SetValue(OnColdownEnded, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static System.Action GetOnShootFired(this IEntity obj) => obj.GetValue<System.Action>(OnShootFired);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnShootFired(this IEntity obj, out System.Action value) => obj.TryGetValue(OnShootFired, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnShootFired(this IEntity obj, System.Action value) => obj.AddValue(OnShootFired, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnShootFired(this IEntity obj) => obj.HasValue(OnShootFired);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnShootFired(this IEntity obj) => obj.DelValue(OnShootFired);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnShootFired(this IEntity obj, System.Action value) => obj.SetValue(OnShootFired, value);
    }
}
