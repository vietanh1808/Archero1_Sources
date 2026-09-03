using System;
using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone2201GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform curSkill;

	[SerializeField]
	private Transform effectParent;

	[SerializeField]
	private AutoDespawn autoDespawn;

	[SerializeField]
	private SkillAlone2201GoodCtrlItem goodCtrlItem;

	[SerializeField]
	private Transform createSkillItemParent;

	[SerializeField]
	private ParticleSystem selfPar;

	[SerializeField]
	private ParticleSystem enemyPar;

	private List<SkillAlone2201GoodCtrlItem> allCreateSkillItem;

	private const float CheckSkillInterval = 0.1f;

	private const float CreateSkillItemOffsetScale = 0.9f;

	private SequencePool mSeqPool;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private float lastCheckTime;

	private Action<EntityBase> triggerEntityEnter;

	private Action<EntityBase> triggerEntityExit;

	private Vector3 pos;

	private EntityBase triggerEntity;

	private float radius;

	private float skillItemRadius;

	private int crystalFragmentCount;

	private int originShowCrystalFragmentCount;

	private float showCrystalFragmentMoreInterval;

	private float autoSendBulletInterval;

	private Action<BulletBase> onCreateBullet;

	private ArtifactType artifactType;

	private float bulletDmgScale;

	private bool isSelf;

	private int curIndex;

	private bool CanTriggerEntity => false;

	private List<EntityBase> AllEntity => null;

	private List<EntityBase> AllActiveEntity => null;

	private void Init()
	{
	}

	private void InitPool()
	{
	}

	public void Refresh(bool isSelf, ArtifactType artifactType, Vector3 pos, EntityBase triggerEntity, float radius, float skillItemRadius, int crystalFragmentCount, int originShowCrystalFragmentCount, float showCrystalFragmentMoreInterval, Action<EntityBase> triggerEntityEnter, Action<EntityBase> triggerEntityExit, float autoSendBulletInterval, Action<BulletBase> onCreateBullet, float bulletDmgScale)
	{
	}

	private void RefreshData()
	{
	}

	private void RefreshPar()
	{
	}

	public void RecycleCurSkill()
	{
	}

	public void SetSize(float size)
	{
	}

	private void RefreshSize()
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	private void Skill2201Update(float delta)
	{
	}

	private void StartCreateSKillItem()
	{
	}

	private void CreateSkillItemPer()
	{
	}

	private void CreateSkillItemReal()
	{
	}

	public void CreateSkillItem(Vector3 pos, int index)
	{
	}

	private void SendCreateSkillItemMsg(Vector3 pos, int index)
	{
	}

	private void SyncCreateSkillItemMsg(Vector3 pos, int index)
	{
	}

	public void SkillItemSendBullet(Vector3 pos, float rotate, int index)
	{
	}
}
