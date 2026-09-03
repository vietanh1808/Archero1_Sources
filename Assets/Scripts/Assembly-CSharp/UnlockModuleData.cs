using System;

public class UnlockModuleData
{
	public enum ModuleName
	{
		Talents = 0,
		Equipments = 1,
		DailyActivities = 2,
		HeroUpgrade = 3,
		MonsterEggs = 4,
		HeroMode = 5,
		Harvest = 6,
		Altar = 7,
		Gems = 8,
		Tower = 9,
		AltarHero = 10,
		PveSeason = 11,
		Dragon = 12,
		AltarHeroEx = 13,
		Refine = 14,
		Relics = 15,
		Medal = 16,
		MeadowBattle = 17,
		Manor = 18,
		Pet = 19,
		Imprint = 20,
		Wing = 21,
		HellMode = 22,
		Artifact = 23,
		Totem = 24,
		AltarRelics = 25,
		Badge = 26
	}

	public ModuleName moduleName;

	public Action showTip;

	public Action goToModule;

	private static readonly string[] nameStrs;

	private static readonly string[] infoStrs;

	private static readonly (string, string)[] iconStrs;

	private static readonly string[] notifyStrs;

	public string NameStr => null;

	public string InfoStr => null;

	public string IconAtlas => null;

	public string IconName => null;

	public string NotificationName => null;
}
