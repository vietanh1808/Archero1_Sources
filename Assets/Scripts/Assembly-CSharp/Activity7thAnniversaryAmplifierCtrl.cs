using System;
using System.Collections.Generic;
using UnityEngine;

public class Activity7thAnniversaryAmplifierCtrl : MonoBehaviour
{
	private sealed class TrackedBulletInfo
	{
		public BulletBase Bullet;

		public Vector2 PrevPosition;

		public Action<BulletBase> CacheHandler;
	}

	private const float DefaultLineHalfHeight = 1.5f;

	private const float DefaultLineHalfWidth = 0.3f;

	private const float DebugLineWidth = 0.06f;

	private const float ArriveDistance = 0.05f;

	private static readonly HashSet<int> EnhancedBulletGuids;

	private readonly Dictionary<int, TrackedBulletInfo> trackedBulletMap;

	private EntityBase owner;

	private Activity7thAnniversaryDaily130RuleHelper.CircleRuleEntry ruleEntry;

	private Action<Activity7thAnniversaryAmplifierCtrl> onRecycle;

	private GameObject visual;

	private BoxCollider shieldCollider;

	private GameObject debugLineRoot;

	private GameObject debugBoundaryRoot;

	private LineRenderer debugLineRenderer;

	private LineRenderer debugBoundaryRenderer;

	private Material debugLineMaterial;

	private Material debugBoundaryMaterial;

	private float critRateAdd;

	private float critValueAdd;

	private float hitAddPercentAdd;

	private float waitStartTime;

	private float fixedZ;

	private float minX;

	private float maxX;

	private float lineHalfHeight;

	private float lineHalfWidth;

	private Vector3 currentTargetPos;

	private bool hasTargetPos;

	private bool recycled;

	public void Init(EntityBase owner, Activity7thAnniversaryDaily130RuleHelper.CircleRuleEntry ruleEntry, Vector3 initPos, float critRateAdd, float critValueAdd, float hitAddPercentAdd, Action<Activity7thAnniversaryAmplifierCtrl> onRecycle, float scale)
	{
	}

	private void Update()
	{
	}

	public void Recycle()
	{
	}

	private void CreateVisual(float scale)
	{
	}

	private void CreateDebugLine()
	{
	}

	private void UpdateDebugLine()
	{
	}

	private void DestroyDebugLine()
	{
	}

	private void RefreshLineBounds()
	{
	}

	private void RefreshMoveBounds()
	{
	}

	private void UpdateMove()
	{
	}

	private void OnOwnerCreateBullet(BulletBase bullet)
	{
	}

	private void SyncActivePlayerBullets()
	{
	}

	private void TryTrackBullet(BulletBase bullet)
	{
	}

	private void UpdateTrackedBullets()
	{
	}

	private void EnhanceBullet(BulletBase bullet, int bulletGuid)
	{
	}

	private bool CheckBulletCrossAmplifier(Vector2 bulletStart, Vector2 bulletEnd, Vector2 lineStart, Vector2 lineEnd, float bulletRadius)
	{
		return false;
	}

	private static bool CheckSegmentIntersectsAABB(Vector2 segStart, Vector2 segEnd, Vector2 boxMin, Vector2 boxMax, float radius)
	{
		return false;
	}

	private static bool PointInsideAABB(Vector2 p, Vector2 min, Vector2 max)
	{
		return false;
	}

	private static bool ClipSegment(float denom, float numer, ref float tMin, ref float tMax)
	{
		return false;
	}

	private void OnTrackedBulletCache(BulletBase bullet)
	{
	}

	private void RemoveTrackedBullet(int bulletGuid, bool removeEnhancedFlag = false)
	{
	}

	private void ClearTrackedBullets()
	{
	}

	private Vector2 BuildBulletPositionXY(BulletBase bullet)
	{
		return default;
	}

	private float GetBulletRadiusXY(BulletBase bullet)
	{
		return 0f;
	}

	private void TryPickNextTarget()
	{
	}

	private Vector3 BuildWorldPosFromGrid(Vector2Int gridPosition)
	{
		return default;
	}

	private void ClampSelfInsideMap()
	{
	}

	private Vector3 ClampPosInsideMap(Vector3 position)
	{
		return default;
	}

	private static float DistanceSegmentToSegmentSq(Vector2 p1, Vector2 q1, Vector2 p2, Vector2 q2)
	{
		return 0f;
	}
}
