using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ActionFirePath
{
	private const string UPDATE_NAME = "ActionFirePath";

	public int EFFECT_ID;

	private const int SKILL_ALONE_ID = 1014;

	public float TIME_INTERVAL;

	private float m_fTime;

	private Vector3 originalFirePos;

	private GameObject fireEffect;

	private ParticleSystem mParticle;

	private Vector3 lastPos;

	public Transform FireTargetTrans;

	public EntityBase m_Entity;

	public int FireBuffId;

	public float FireAliveTime;

	public float FireColliderAliveTime;

	public float MinRadius;

	public bool UseDelayDelete;

	private Vector3 fireTargetPosXZ;

	public List<GameObject> fireColliderList;

	protected Transform mStart;

	protected Transform mEnd;

	protected Vector3 mStartPosXZ;

	protected Vector3 mEndPosXZ;

	private bool CanFollow;

	private Tweener fireTweener;

	private string updateName;

	public ActionFirePath(Transform _FireTargetTrans, EntityBase _m_Entity)
	{
	}

	public ActionFirePath(Transform _mStart, Transform _mEnd)
	{
	}

	public void GenerateFirePath(float fireDuration = 0.1f)
	{
	}

	public void Init()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room obj)
	{
	}

	public void DeInit()
	{
	}

	public void Clear()
	{
	}

	private void OnUpdate(float obj)
	{
	}

	public void Start()
	{
	}

	public void Stop()
	{
	}

	private GameObject createFireEffect()
	{
		return null;
	}

	private void updateFireEffectPos()
	{
	}

	private void checkIfCreateFireCollider()
	{
	}

	private void createFireCollider(Vector3 pos)
	{
	}
}
