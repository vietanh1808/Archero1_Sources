using System;
using UnityEngine;

public class SkillAlone2325EffectCtrl : MonoBehaviour
{
	private int ClassID;

	private int _buffId;

	private int _skillLv;

	private GameObject _trailEffect;

	private bool _isFlying;

	private EntityBase _targetEntity;

	private float _flySpeed;

	private float _arriveDistance;

	private Action<SkillAlone2325EffectCtrl> _onArriveCallback;

	public void Init(int classId, int buffId, int skillLv)
	{
	}

	public void FlyToTarget(EntityBase target, float flySpeed, Action<SkillAlone2325EffectCtrl> onArrive)
	{
	}

	private void AttachTrailEffect()
	{
	}

	private void Update()
	{
	}

	private void OnArrive()
	{
	}

	public void RecycleAll()
	{
	}
}
