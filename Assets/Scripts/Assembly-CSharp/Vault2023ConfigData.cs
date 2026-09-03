using System.Collections.Generic;
using XLua;

public class Vault2023ConfigData
{
	public long startTime;

	public long endTime;

	public int keyID;

	public int keyCost;

	public List<Vault2023GameRewardItemConfigData> gameReward;

	public List<Vault2023GameShowRewardItemConfigData> showReward;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_ResetGame;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static Vault2023ConfigData Create(long startTime, long endTime, int keyID, int keyCost, List<Vault2023GameRewardItemConfigData> gameReward, List<Vault2023GameShowRewardItemConfigData> showReward)
	{
		return null;
	}

	public void ResetGame(int rewardIndex)
	{
	}
}
