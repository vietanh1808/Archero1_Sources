using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

public static class Act5thHuntingUtils
{
	public static (Vector2, Vector2) GetArrowTopPoint(Vector2 arrowCenter, Vector2 direction, float width, float length)
	{
		return default;
	}

	public static Act5thHuntingTalentAttributeData ParseHuntingTalentAttributeData(string attr, float value)
	{
		return null;
	}

	public static (string, float) ParseHuntingAttribute(string attributeAllDesc)
	{
		return default;
	}

	public static Act5thHuntingTalentAttributeType ParseHuntingTalentAttributeType(string attribute)
	{
		return Act5thHuntingTalentAttributeType.None;
	}

	public static Act5thHuntingBaseSourceData ParseHuntingBaseSourceData(int tag, int totalScore)
	{
		return null;
	}

	public static Act5thHuntingSceneSourceData ParseHuntingSceneSourceData(Dictionary<int, int> sceneMaxKillScore, Dictionary<int, int> sceneAllKillScore)
	{
		return null;
	}

	public static Act5thHuntingPreviewSourceData ParseHuntingPreviewSourceData(Dictionary<uint, uint> killAnimal)
	{
		return null;
	}

	public static Act5thHuntingTalentSourceData ParseHuntingTalentSourceData(Dictionary<ushort, ushort> talentData)
	{
		return null;
	}

	public static Act5thHuntingRankingSourceData ParseHuntingRankingSourceData(int rewardIndex, STActivityHuntingRank rankData)
	{
		return null;
	}

	public static Act5thHuntingRankingRewardSourceData ParseHuntingRankingRewardSourceData(int curGroup)
	{
		return null;
	}

	public static Act5thHuntingGameData ParseHuntingGameData(int selectGameSceneID, STActivityHuntingPreyInfo[] preyInfo)
	{
		return null;
	}

	public static Act5thHuntingArrowCreatorData ParseArrowCreatorData(int bowID, int arrowOriginCount)
	{
		return null;
	}

	public static Act5thHuntingAnimalCreatorData ParseAnimalCreatorData(int selectGameSceneID, STActivityHuntingPreyInfo[] preyInfo)
	{
		return null;
	}
}
