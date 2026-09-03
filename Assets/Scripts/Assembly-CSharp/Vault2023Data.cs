using System.Collections.Generic;
using XLua;

public class Vault2023Data : RecycleData<Vault2023ConfigData>
{
	private static DelegateBridge __Hotfix0_get_IsOpen;

	private static DelegateBridge __Hotfix0_get_KeyPropID;

	private static DelegateBridge __Hotfix0_get_KeyCount;

	private static DelegateBridge __Hotfix0_get_DrawCost;

	private static DelegateBridge __Hotfix0_get_HaveEnoughKey;

	private static DelegateBridge __Hotfix0_get_ShowReward;

	private static DelegateBridge __Hotfix0_get_GameReward;

	private static DelegateBridge __Hotfix0_AddGameResult;

	private static DelegateBridge __Hotfix0_ResetGame;

	private static DelegateBridge __Hotfix0_UseKey;

	private static DelegateBridge __Hotfix0_GetGameReward;

	private static DelegateBridge __Hotfix0_GetShowReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool IsOpen => false;

	public int KeyPropID => 0;

	public int KeyCount => 0;

	public int DrawCost => 0;

	public bool HaveEnoughKey => false;

	public List<Vault2023ShowRewardItemData> ShowReward => null;

	public List<Vault2023GameRewardItemData> GameReward => null;

	public void AddGameResult(int index, int rewardID)
	{
	}

	public void ResetGame(int rewardIndex)
	{
	}

	public void UseKey(int count)
	{
	}

	private List<Vault2023GameRewardItemData> GetGameReward()
	{
		return null;
	}

	private List<Vault2023ShowRewardItemData> GetShowReward()
	{
		return null;
	}
}
