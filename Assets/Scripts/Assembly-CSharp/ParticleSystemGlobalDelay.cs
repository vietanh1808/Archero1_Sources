using System;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[AddComponentMenu("Particles/Particle System Global Delay")]
[ExecuteAlways]
public class ParticleSystemGlobalDelay : MonoBehaviour
{
	[Serializable]
	private class DelayCache
	{
		public ParticleSystem ps;

		public ParticleSystemCurveMode mode;

		public float originalConstant;

		public float originalConstantMin;

		public float originalConstantMax;

		public float originalMultiplier;
	}

	[Header("延迟设置")]
	[Tooltip("要增加的整体延迟时间（秒）。随时修改，实时生效。")]
	[Min(0f)]
	public float globalDelayAmount;

	[Tooltip("是否包含处理未激活(Inactive)的子节点上的粒子系统")]
	public bool includeInactiveChildren;

	[SerializeField]
	[HideInInspector]
	private List<DelayCache> psCache;

	[SerializeField]
	[HideInInspector]
	private float lastAppliedDelay;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnValidate()
	{
	}

	public void SetGlobalDelay(float newDelay)
	{
	}

	private void SyncAndApply()
	{
	}

	private void DetectHierarchyAndManualChanges()
	{
	}

	private bool HasHierarchyChanged(ParticleSystem[] currentSystems)
	{
		return false;
	}

	private void RebuildCache(ParticleSystem[] currentSystems)
	{
	}

	private void DetectManualOverrides()
	{
	}

	private void ApplyGlobalDelay()
	{
	}

	private void RevertKnownDelays()
	{
	}
}
