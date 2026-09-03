using System.Collections.Generic;
using TableTool;

public class GameModeSanta2023 : GameModeBase
{
	public override IStageLayerManager StageChapterMgr => null;

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
