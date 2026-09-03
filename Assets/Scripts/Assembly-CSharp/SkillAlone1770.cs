using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone1770 : SkillAloneGachaEgg
{
	private const int PART_ID = 1801;

	private const float DELAY_TIME = 5f;

	private const int EFFECT_ATTACK_UP = 1;

	private const int EFFECT_CREATE_PARTS = 2;

	private const int EFFECT_RANDOM_SKILL = 3;

	private const int EFFECT_RANDOM_DEMON_SKILL = 4;

	private const int EFFECT_DROP_HP = 5;

	private const int EFFECT_ENEMY_UP = 6;

	private int atkBuffId;

	private int minPartCount;

	private int maxPartCount;

	private float partAliveTime;

	private string partAttr;

	private int minHPDrop;

	private int maxHPDrop;

	private int enemyBuffId;

	private bool isMonsterCreated;

	private int curEffectId;

	private int openGachaEggCount;

	private float curTime;

	private WeightRandom randomWeight;

	private RoomGenerateBase.Room curRoom;

	private int roomSkillId;

	private List<int> blockedSlotinSkills;

	private List<int> demonSkills;

	private List<int> blockedDemonSkills;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void initSkills()
	{
	}

	private int GetRandomSkillId(List<int> skillIds)
	{
		return 0;
	}

	private int GetRandomDemonSkillId()
	{
		return 0;
	}

	private void onLevelUpBefore()
	{
	}

	private void onOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void clearGachaBuffs()
	{
	}

	private void tryKillRoomSkillId()
	{
	}

	private void onChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private bool IsHurtEffect()
	{
		return false;
	}

	private void onMonsterCreated(EntityBase entity)
	{
	}

	private void resetState()
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void updateEffect()
	{
	}

	private void updateGachaEgg()
	{
	}

	protected override void OnUpdateInternal(float delta)
	{
	}

	private void OpenGachaEgg()
	{
	}

	private void parseArgs1(string[] args)
	{
	}

	private void parseArgs2(string[] args)
	{
	}

	private void parseArgs3(string[] args)
	{
	}

	private void parseArgs4(string[] args)
	{
	}

	private void parseArgs5(string[] args)
	{
	}

	protected override void OnGachaEggCreated(Vector3 birthPos)
	{
	}

	protected override void OnGachaEggCleared()
	{
	}
}
