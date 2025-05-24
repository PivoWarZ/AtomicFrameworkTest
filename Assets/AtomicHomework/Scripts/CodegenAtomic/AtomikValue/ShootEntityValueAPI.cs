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
        public const int EnemyAttackDistance = 39; // ReactiveVariable<float>
        public const int IsAttackDistance = 40; // ReactiveVariable<bool>
        public const int DamageColdown = 41; // ReactiveVariable<float>
        public const int DealTickDamage = 42; // IEvent
        public const int CanDamagePerSecond = 43; // AndExpression
        public const int EnemyTarget = 44; // SceneEntity


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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetEnemyAttackDistance(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(EnemyAttackDistance);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetEnemyAttackDistance(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(EnemyAttackDistance, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddEnemyAttackDistance(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(EnemyAttackDistance, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasEnemyAttackDistance(this IEntity obj) => obj.HasValue(EnemyAttackDistance);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelEnemyAttackDistance(this IEntity obj) => obj.DelValue(EnemyAttackDistance);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetEnemyAttackDistance(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(EnemyAttackDistance, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<bool> GetIsAttackDistance(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsAttackDistance);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsAttackDistance(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsAttackDistance, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsAttackDistance(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsAttackDistance, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsAttackDistance(this IEntity obj) => obj.HasValue(IsAttackDistance);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsAttackDistance(this IEntity obj) => obj.DelValue(IsAttackDistance);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsAttackDistance(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsAttackDistance, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetDamageColdown(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(DamageColdown);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDamageColdown(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(DamageColdown, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDamageColdown(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(DamageColdown, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDamageColdown(this IEntity obj) => obj.HasValue(DamageColdown);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDamageColdown(this IEntity obj) => obj.DelValue(DamageColdown);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDamageColdown(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(DamageColdown, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetDealTickDamage(this IEntity obj) => obj.GetValue<IEvent>(DealTickDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDealTickDamage(this IEntity obj, out IEvent value) => obj.TryGetValue(DealTickDamage, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDealTickDamage(this IEntity obj, IEvent value) => obj.AddValue(DealTickDamage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDealTickDamage(this IEntity obj) => obj.HasValue(DealTickDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDealTickDamage(this IEntity obj) => obj.DelValue(DealTickDamage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDealTickDamage(this IEntity obj, IEvent value) => obj.SetValue(DealTickDamage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AndExpression GetCanDamagePerSecond(this IEntity obj) => obj.GetValue<AndExpression>(CanDamagePerSecond);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanDamagePerSecond(this IEntity obj, out AndExpression value) => obj.TryGetValue(CanDamagePerSecond, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanDamagePerSecond(this IEntity obj, AndExpression value) => obj.AddValue(CanDamagePerSecond, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanDamagePerSecond(this IEntity obj) => obj.HasValue(CanDamagePerSecond);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanDamagePerSecond(this IEntity obj) => obj.DelValue(CanDamagePerSecond);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanDamagePerSecond(this IEntity obj, AndExpression value) => obj.SetValue(CanDamagePerSecond, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SceneEntity GetEnemyTarget(this IEntity obj) => obj.GetValue<SceneEntity>(EnemyTarget);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetEnemyTarget(this IEntity obj, out SceneEntity value) => obj.TryGetValue(EnemyTarget, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddEnemyTarget(this IEntity obj, SceneEntity value) => obj.AddValue(EnemyTarget, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasEnemyTarget(this IEntity obj) => obj.HasValue(EnemyTarget);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelEnemyTarget(this IEntity obj) => obj.DelValue(EnemyTarget);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetEnemyTarget(this IEntity obj, SceneEntity value) => obj.SetValue(EnemyTarget, value);
    }
}
