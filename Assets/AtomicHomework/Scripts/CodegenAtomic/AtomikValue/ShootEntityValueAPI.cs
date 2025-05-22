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
    public static class ShootEntityValueAPI
    {
        ///Keys
        public const int BulletPrefab = 9; // SceneEntity
        public const int ShootPoint = 10; // Transform
        public const int CanShoot = 13; // AndExpression
        public const int OnShootRequest = 15; // IEvent
        public const int OnShootAction = 19; // IEvent
        public const int BulletContainer = 28; // Transform
        public const int OnShootEvent = 35; // IEvent
        public const int BulletsLimit = 37; // ReactiveVariable<int>
        public const int IsShootReady = 38; // ReactiveVariable<bool>


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
        public static AndExpression GetCanShoot(this IEntity obj) => obj.GetValue<AndExpression>(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanShoot(this IEntity obj, out AndExpression value) => obj.TryGetValue(CanShoot, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanShoot(this IEntity obj, AndExpression value) => obj.AddValue(CanShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanShoot(this IEntity obj) => obj.HasValue(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanShoot(this IEntity obj) => obj.DelValue(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanShoot(this IEntity obj, AndExpression value) => obj.SetValue(CanShoot, value);

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
        public static IEvent GetOnShootAction(this IEntity obj) => obj.GetValue<IEvent>(OnShootAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnShootAction(this IEntity obj, out IEvent value) => obj.TryGetValue(OnShootAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnShootAction(this IEntity obj, IEvent value) => obj.AddValue(OnShootAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnShootAction(this IEntity obj) => obj.HasValue(OnShootAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnShootAction(this IEntity obj) => obj.DelValue(OnShootAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnShootAction(this IEntity obj, IEvent value) => obj.SetValue(OnShootAction, value);

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetOnShootEvent(this IEntity obj) => obj.GetValue<IEvent>(OnShootEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnShootEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(OnShootEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnShootEvent(this IEntity obj, IEvent value) => obj.AddValue(OnShootEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnShootEvent(this IEntity obj) => obj.HasValue(OnShootEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnShootEvent(this IEntity obj) => obj.DelValue(OnShootEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnShootEvent(this IEntity obj, IEvent value) => obj.SetValue(OnShootEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<int> GetBulletsLimit(this IEntity obj) => obj.GetValue<ReactiveVariable<int>>(BulletsLimit);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBulletsLimit(this IEntity obj, out ReactiveVariable<int> value) => obj.TryGetValue(BulletsLimit, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBulletsLimit(this IEntity obj, ReactiveVariable<int> value) => obj.AddValue(BulletsLimit, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBulletsLimit(this IEntity obj) => obj.HasValue(BulletsLimit);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBulletsLimit(this IEntity obj) => obj.DelValue(BulletsLimit);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBulletsLimit(this IEntity obj, ReactiveVariable<int> value) => obj.SetValue(BulletsLimit, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<bool> GetIsShootReady(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsShootReady);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsShootReady(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsShootReady, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsShootReady(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsShootReady, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsShootReady(this IEntity obj) => obj.HasValue(IsShootReady);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsShootReady(this IEntity obj) => obj.DelValue(IsShootReady);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsShootReady(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsShootReady, value);
    }
}
