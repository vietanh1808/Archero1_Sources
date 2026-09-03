using System.Collections.Generic;
using TableTool;
using XLua;

public class Exchange2023ItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_LeftCount;

	private static DelegateBridge __Hotfix0_get_MaxCount;

	private static DelegateBridge __Hotfix0_get_NeedCondID;

	private static DelegateBridge __Hotfix0_get_NeedCondCount;

	private static DelegateBridge __Hotfix0_get_HaveNeedEnoughCondCount;

	private static DelegateBridge __Hotfix0_get_Reward;

	private static DelegateBridge __Hotfix0_get_NeedCond;

	private static DelegateBridge __Hotfix0_get_Position;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_UpdateLeftExchangeCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Exchange2023ItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public int LeftCount => 0;

	public int MaxCount => 0;

	public int NeedCondID => 0;

	public int NeedCondCount => 0;

	public bool HaveNeedEnoughCondCount => false;

	public List<Drop_DropModel.DropData> Reward => null;

	public List<Drop_DropModel.DropData> NeedCond => null;

	public int Position => 0;

	public static Exchange2023ItemData Create(Exchange2023ItemConfigData configData)
	{
		return null;
	}

	public void UpdateLeftExchangeCount(int leftExchangeCount)
	{
	}
}
