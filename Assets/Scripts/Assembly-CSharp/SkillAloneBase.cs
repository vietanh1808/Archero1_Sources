using System;
using TableTool;
using UnityEngine;

public class SkillAloneBase : AttributeCtrlBase
{
	public string Tag => null;

	protected EntityBabyBase CreateBaby(int babyID)
	{
		return null;
	}

	protected void Log(string log)
	{
	}

	protected void LogError(string info)
	{
	}

	protected void LogException(string info, Exception e)
	{
	}

	public ActionBasic.ActionDelegate GetActionDelegate(Action action)
	{
		return null;
	}

	protected ActionBasic.ActionBase GetActionWaitDelegate(int time, Action action)
	{
		return null;
	}

	public ActionBasic.ActionWait GetActionWait(string name, int waitTime)
	{
		return null;
	}

	protected void AddMultiOnlineCallback()
	{
	}

	protected void RemoveMultiOnlineCallback()
	{
	}

	protected virtual void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	protected virtual void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	protected void OnDropHP(CustomJsonDataCommand cmd)
	{
	}

	protected void OnDropPVPHp(CustomJsonDataCommand cmd)
	{
	}

	protected int GetDropPVPHp(EntityBase entity, float m_fHpAddPercent)
	{
		return 0;
	}

	protected void CreateDropPVPHp(int hp, EntityHero hero, EntityBase entity)
	{
	}

	protected void CreateDropPVPHp(int hp, EntityHero hero, Vector3 dropPos)
	{
	}

	protected virtual void CreateDropHP(Vector3 dropHPPos, int count = 1, int radius = 1)
	{
	}

	protected virtual void CreateDropMP(Vector3 dropPos)
	{
	}

	protected void SyncDropHP(Vector3 pos, int count = 1, int hpDropRadius = 1)
	{
	}

	protected void SyncDropMP(Vector3 pos)
	{
	}

	protected void SyncDropPVPHP(int guid, int hp, int count = 1)
	{
	}

	protected void SyncDropPVPHP(int guid, int hp, Vector3 dropPos, int count = 1)
	{
	}

	protected void SyncHPCommand(EntityBase source, long hp)
	{
	}

	public static long GetAttack(EntityBase entity, string att)
	{
		return 0L;
	}

	private static long GetAttack(EntityBase entity, Goods_goods.GoodData data)
	{
		return 0L;
	}
}
