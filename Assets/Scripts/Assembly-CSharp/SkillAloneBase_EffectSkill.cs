using System.Collections.Generic;
using TableTool;
using UnityEngine;

public abstract class SkillAloneBase_EffectSkill : SkillAloneBase
{
	protected enum BuildType
	{
		BuildType_None = 0,
		BuildType_Only = 1,
		BuildType_Or = 2,
		BuildType_And = 3
	}

	protected enum ConditionType
	{
		ConditionType_101 = 101,
		ConditionType_102 = 102,
		ConditionType_103 = 103,
		ConditionType_104 = 104,
		ConditionType_105 = 105
	}

	protected List<Goods_goods.GoodData> mAttrs;

	protected BuildType m_emBuildType;

	protected Dictionary<ConditionType, bool> conditions;

	protected int m_nKillCount;

	protected bool m_bTrigger101InWaveRoom;

	protected int Mhp;

	protected int MaxHp;

	protected int KillNum;

	protected float Condition101WaitTime;

	private ActionBasic baseAction;

	private Skill_effectskill effectSkill;

	private bool checkMhp;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void parseCondition(params object[] args)
	{
	}

	protected virtual void checkCondition()
	{
	}

	protected void OnWaveRoomPlayerMove(Vector3 pos)
	{
	}

	private void checkCondition101Wrapper()
	{
	}

	private void checkCondtion101()
	{
	}

	protected void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected virtual void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void handleMhp()
	{
	}

	protected void OnKillAction(EntityBase entity, Vector3 HittedDirection, HitStruct hs)
	{
	}

	protected abstract void OnTrigger(EntityBase entity);

	private Equip_equip GetBracelet()
	{
		return null;
	}

	private Equip_equip GetLocket()
	{
		return null;
	}

	private Equip_equip GetSpecificEquip(int type)
	{
		return null;
	}
}
