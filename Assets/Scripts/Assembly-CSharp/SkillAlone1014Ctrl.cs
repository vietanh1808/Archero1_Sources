using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1014Ctrl
{
	private const string Tag = "SkillAlone1014Ctrl";

	protected EntityBase m_Entity;

	private SkillAloneBase mSkillAlone;

	private float createdis;

	private float currentdis;

	private List<SkillAloneGoodCtrlBase> mList;

	private GameObject good;

	private Vector3 m_pos;

	private Action<GameObject> createSkillOne;

	private int m_nEffectId;

	private float m_fTime;

	private bool haveOriginEffectID;

	private Func<bool> mCanCreate;

	public void Init(EntityBase entity, SkillAloneBase alone, Action<GameObject> createSkillOne = null)
	{
	}

	public void Init(EntityBase entity, SkillAloneBase alone, float createdis, Func<bool> canCreate, int nEffectId = 0, float fTime = 0f)
	{
	}

	public void DeInit()
	{
	}

	private void CreateOne(Vector3 pos)
	{
	}

	protected virtual void InitGoodCtrl(SkillAlone1014GoodCtrl ctrl)
	{
	}

	private void OnGoodDeInit(SkillAloneGoodCtrlBase ctrl)
	{
	}

	public void RemoveGoods()
	{
	}

	public void UpdatePos(Vector3 pos)
	{
	}

	private void OnPositionBy(Vector3 p)
	{
	}

	public void OnUpdate(float delta)
	{
	}
}
