using System;
using System.Collections.Generic;
using TableTool;

public class GameModeSailingBagBattle : GameModeBase
{
	private SailingBagBattleStageLayerManager _sailingBagBattleStageLayerManager;

	private LocalModelManager _tableMgr;

	private HoldManager _holdMgr;

	private ReleaseManager _releaseMgr;

	private BattleModuleData _battleData;

	private MapCreator _mapCreator;

	public override IStageLayerManager StageChapterMgr => null;

	public override string[] GetMonsterTmxAttributes()
	{
		return null;
	}

	public override Dictionary<string, Goods_goods.GoodData> GetHellMonsterAttributes()
	{
		return null;
	}

	public override string[] GetMapAttributes()
	{
		return null;
	}

	public override string[] GetTmxIds(int roomid, int roomcount)
	{
		return null;
	}

	public override string[] GetTmxIds(int line, int roomid, int roomcount)
	{
		return null;
	}

	public override int GetMaxLayer()
	{
		return 0;
	}

	public override long GetMapStandardDefence()
	{
		return 0L;
	}

	public override string[] GetAdTurns()
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

	public override int GetAdMysticShopType()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetNewPlay125BagCoinItem(EntityType type)
	{
		return null;
	}

	public override int GetNewPlay125BagCoinMaxDrop()
	{
		return 0;
	}

	public override int GetExp()
	{
		return 0;
	}

	public override bool CanLearnSkills(in SkillType type, out List<int> ids, EntityHero hero)
	{
		ids = null;
		return false;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetDropById(int id, EntityType type, Func<float> func = null)
	{
		return null;
	}

	public override int GetMaxDropById(int id)
	{
		return 0;
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

	public override string GetMappingMapPrefix(string prefix, string name = null)
	{
		return null;
	}

	public override void CheckHeroPos()
	{
	}
}
