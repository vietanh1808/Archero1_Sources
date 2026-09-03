using System.Collections.Generic;
using CampBattle;
using TableTool;
using UnityEngine;

public class GameModeCampBattle : GameModeBase
{
	public const string LOG_TAG = "[CampBattle]";

	public bool RoundStarted;

	public RoundController roundController;

	public override IStageLayerManager StageChapterMgr => null;

	protected override void OnCreatePlayer(EntityBase entity)
	{
	}

	public void DeInit()
	{
	}

	public override bool CanLearnSkills(in SkillType type, out List<int> ids, EntityHero hero)
	{
		ids = null;
		return false;
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onPlayerMove(Vector3 vector)
	{
	}

	public override float GetActivityHPRatio()
	{
		return 0f;
	}

	public override float GetActivityAttackRatio()
	{
		return 0f;
	}

	public override float GetActivityBodyHitRatio()
	{
		return 0f;
	}

	public override float GetActivityTrapHitRatio()
	{
		return 0f;
	}

	public override int GetAdMysticShopType()
	{
		return 0;
	}

	public override string[] GetAdTurns()
	{
		return null;
	}

	public override string[] GetMapAttributes()
	{
		return null;
	}

	public override long GetMapStandardDefence()
	{
		return 0L;
	}

	public override int GetMaxLayer()
	{
		return 0;
	}

	public override string[] GetMonsterTmxAttributes()
	{
		return null;
	}

	public override List<Shop_MysticShop> GetMysticShopData(int shoptype)
	{
		return null;
	}

	public override Shop_MysticShopShow GetMysticShopShow(int stage)
	{
		return null;
	}

	public override int GetMysticShopType()
	{
		return 0;
	}

	public override string[] GetTmxIds(int roomid, int roomcount)
	{
		return null;
	}
}
