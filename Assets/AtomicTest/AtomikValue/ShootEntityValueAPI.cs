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
    public static class ShootEntityValueAPI
    {
        ///Keys
        public const int BulletPrefab = 9; // SceneEntity
        public const int ShootPoint = 10; // Transform
        public const int CanShoot = 13; // ReactiveVariable<bool>
        public const int OnShootRequest = 15; // IEvent
        public const int OnShootFired = 19; // IEvent
        public const int BulletContainer = 28; // Transform


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
        public static ReactiveVariable<bool> GetCanShoot(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanShoot(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(CanShoot, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanShoot(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(CanShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanShoot(this IEntity obj) => obj.HasValue(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanShoot(this IEntity obj) => obj.DelValue(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanShoot(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(CanShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetOnShootRequest(this IEntity obj) => obj.GetValue<IEvent>(OnShootRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnShootRequest(this IEntity obj, out IEvent value) => obj.TryGetValue(OnShootRequest, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnShootRequest(this IEntity obj, IEvent value) => obj.AddValue(OnShootRequest, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnShootRequest(this IEntity obj) => obj.HasValue(OnShootRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnShootRequest(this IEntity obj) => obj.DelValue(OnShootRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnShootRequest(this IEntity obj, IEvent value) => obj.SetValue(OnShootRequest, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetOnShootFired(this IEntity obj) => obj.GetValue<IEvent>(OnShootFired);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnShootFired(this IEntity obj, out IEvent value) => obj.TryGetValue(OnShootFired, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnShootFired(this IEntity obj, IEvent value) => obj.AddValue(OnShootFired, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnShootFired(this IEntity obj) => obj.HasValue(OnShootFired);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnShootFired(this IEntity obj) => obj.DelValue(OnShootFired);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnShootFired(this IEntity obj, IEvent value) => obj.SetValue(OnShootFired, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetBulletContainer(this IEntity obj) => obj.GetValue<Transform>(BulletContainer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBulletContainer(this IEntity obj, out Transform value) => obj.TryGetValue(BulletContainer, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBulletContainer(this IEntity obj, Transform value) => obj.AddValue(BulletContainer, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBulletContainer(this IEntity obj) => obj.HasValue(BulletContainer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBulletContainer(this IEntity obj) => obj.DelValue(BulletContainer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBulletContainer(this IEntity obj, Transform value) => obj.SetValue(BulletContainer, value);
    }
}
