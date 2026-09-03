using System;
using System.Collections.Generic;
using TableTool;

public class GameModeMainChallenge : GameModeBase
{
	private Stage_Level_challenge challengedata;

	public override IStageLayerManager StageChapterMgr => null;

	public override long GetMapStandardDefence()
	{
		return 0L;
	}

	public override string[] GetMapAttributes()
	{
		return null;
	}

	public override string[] GetTmxIds(int roomid, int roomcount)
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

	public override List<Shop_MysticShop> GetMysticShopData(int shoptype)
	{
		return null;
	}

	public override int GetAdMysticShopType()
	{
		return 0;
	}

	public override string[] GetAdTurns()
	{
		return null;
	}

	public override float GetGoldRatio()
	{
		return 0f;
	}

	public override int GetExp()
	{
		return 0;
	}

	public override int GetEquipMaxDrop()
	{
		return 0;
	}

	public override int GetScrollMaxDrop()
	{
		return 0;
	}

	public override int GetStoneMaxDrop()
	{
		return 0;
	}

	public override int GetRuneStoneMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetAdventureCoin(EntityType type)
	{
		return null;
	}

	public override int GetAdventureCoinMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetLoupe(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetLoupe(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetLoupeMaxDrop()
	{
		return 0;
	}

	public override int GetHonorStoneMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetCookie(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetCookie(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetCookieMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetSoulStone(EntityType type)
	{
		return null;
	}

	public override int GetSoulStoneMaxDrop()
	{
		return 0;
	}

	public override int GetJewelDropID()
	{
		return 0;
	}

	public override int GetJewelRate()
	{
		return 0;
	}

	public override int GetJewelDropRateRateMax()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetScroll(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetStone(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetRuneStone(EntityType type)
	{
		return null;
	}

	public override int GetMaxLayer()
	{
		return 0;
	}

	public override string[] GetMonsterTmxAttributes()
	{
		return null;
	}

	public override DropManager.DropData GetDropData()
	{
		return null;
	}

	public override int GetEquipDropID(int stage)
	{
		return 0;
	}

	public override int GetDropDataGold(Soldier_soldier data)
	{
		return 0;
	}

	public override int GetDropDataEquipExp(Soldier_soldier data)
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetActivityProp(EntityType type)
	{
		return null;
	}

	public override int GetActivityPropMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetBloodStone(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetBloodStone(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetBloodStoneMaxDrop()
	{
		return 0;
	}
}
