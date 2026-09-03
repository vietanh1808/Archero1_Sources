using System.Collections.Generic;
using GameProtocol;

public static class SailingShipUtils
{
	public static SailingShipGameData ParseGameData(STRespShipBattleSeasonFight response, SailingShipBattleRequestType requestType)
	{
		return null;
	}

	public static SailingShipEntityData ParseEntityData(STShipBattleSeasonFightInfoData[] playerInfo, Dictionary<string, long> originAttr, Dictionary<string, STShipBattleSeasonFightBuff> originBuff)
	{
		return null;
	}

	public static SailingShipBattleMsgData ParseBattleMsgData(STShipBattleSeasonFightFrame[] battleMsg)
	{
		return null;
	}

	public static SailingShipWarningData ParseWarningData(STShipBattleSeasonFightInfoData[] playerInfo)
	{
		return null;
	}

	public static SailingShipBattleResultData ParseBattleResultData(STRespShipBattleSeasonFight response)
	{
		return null;
	}

	public static SailingShipBattleAttributeData ParseBattleAttributeData(Dictionary<string, long> mapAttr)
	{
		return null;
	}

	public static SailingShipBattleBuffData ParseBattleBuffData(Dictionary<string, STShipBattleSeasonFightBuff> mapBuff)
	{
		return null;
	}

	public static void SendBattleSDK()
	{
	}

	private static string GetAllAttr(SailingShipEntityItemData entityData)
	{
		return null;
	}

	public static void SendBattlePvpSDK(ulong enemyID)
	{
	}

	public static void SendBattleBossSDK()
	{
	}

	public static bool HaveShipSkinData(int skinID)
	{
		return false;
	}
}
