using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BattleSystemProfileConfig", menuName = "Dxx/Battle System Profile Config", order = 1)]
public class BattleSystemProfileConfig : ScriptableObject
{
	public const string AssetPath = "Assets/Resources/BattleSystemProfile/BattleSystemProfileConfig.asset";

	public const string ResourcesPath = "BattleSystemProfile/BattleSystemProfileConfig";

	public List<BattleSystemProfile> Profiles;

	public BattleSystemProfile FindByProfileId(int profileId)
	{
		return null;
	}

	public BattleSystemProfile FindByDailyId(int dailyId)
	{
		return null;
	}

	public BattleSystemProfile FindByStageChapterId(int stageChapterId)
	{
		return null;
	}
}
