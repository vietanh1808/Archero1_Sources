using System.Collections.Generic;
using TableTool;
using XLua;

public class SkinAbilityResetSuccessData
{
	private static DelegateBridge __Hotfix0_get_SkinID;

	private static DelegateBridge __Hotfix0_set_SkinID;

	private static DelegateBridge __Hotfix0_get_SkinStartLevel;

	private static DelegateBridge __Hotfix0_set_SkinStartLevel;

	private static DelegateBridge __Hotfix0_get_SkinEndLevel;

	private static DelegateBridge __Hotfix0_set_SkinEndLevel;

	private static DelegateBridge __Hotfix0_get_DropData;

	private static DelegateBridge __Hotfix0_set_DropData;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int SkinID { get; set; }

	public int SkinStartLevel { get; set; }

	public int SkinEndLevel { get; set; }

	public List<Drop_DropModel.DropData> DropData { get; set; }

	public static SkinAbilityResetSuccessData Create(int skinID, int skinStartLevel, int skinEndLevel, List<Drop_DropModel.DropData> dropData)
	{
		return null;
	}
}
