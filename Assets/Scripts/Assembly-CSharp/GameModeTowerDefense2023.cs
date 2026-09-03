using System.Collections.Generic;
using TableTool;

public class GameModeTowerDefense2023 : GameModeBase
{
	public override IStageLayerManager StageChapterMgr => null;

	private float getAddedValue(float[] factorArr)
	{
		return 0f;
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

	public override bool CanLearnSkills(in SkillType type, out List<int> ids, EntityHero hero)
	{
		ids = null;
		return false;
	}

	protected override void OnAfterSetPlayerPos(EntityHero player)
	{
	}

	protected override void OnSetHeroDropCtrl(EntityHero player)
	{
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
