using System;
using System.Collections.Generic;
using GameProtocol;
using XLua;

public static class CampTileUtils
{
	private static Random random;

	private static DelegateBridge __Hotfix0_ParseData;

	private static DelegateBridge __Hotfix0_GetHeroAdditionRate;

	private static DelegateBridge __Hotfix0_RandomDamages;

	private static DelegateBridge __Hotfix0_SelectValueInRange;

	public static CampTileParseData ParseData(int titleID, (int, int) pos, CRespCampBlock data)
	{
		return null;
	}

	public static float GetHeroAdditionRate(LocalSave.CharacterOne curTileHero, CampTileResourceType resourceType, int tileLevel)
	{
		return 0f;
	}

	public static List<int> RandomDamages(int totalDamage, int count, (float, float) arrowRangeDamage)
	{
		return null;
	}

	private static int SelectValueInRange(int minValue, int maxValue)
	{
		return 0;
	}
}
