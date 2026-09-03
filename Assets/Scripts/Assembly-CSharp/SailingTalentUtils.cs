using System;
using System.Collections.Generic;
using GameProtocol;

public static class SailingTalentUtils
{
	private static Random random;

	public static CampTalentPersonalConfigData ParsePersonalData(CShipBattleTalent[] talentData)
	{
		return null;
	}

	public static SailingTalentProgressConfigData ParsePersonalProgressData(CShipBattleTalent[] talentData)
	{
		return null;
	}

	public static CampTalentLineDir GetLineDir(int id, bool isUpgradeLine)
	{
		return CampTalentLineDir.None;
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
