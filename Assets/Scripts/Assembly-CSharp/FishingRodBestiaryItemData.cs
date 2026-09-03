using System.Collections.Generic;
using TableTool;

public class FishingRodBestiaryItemData
{
	private FishingRodBestiaryItemConfigData ConfigData { get; set; }

	public Drop_DropModel.DropData RodProp => null;

	public int RodID => 0;

	public int Quality => 0;

	public int SourceType => 0;

	public List<string> EffectDesc => null;

	public bool HaveEffect => false;

	public bool IsUnlock => false;

	public int UnLockWeight => 0;

	public static FishingRodBestiaryItemData Create(FishingRodBestiaryItemConfigData configData)
	{
		return null;
	}

	private List<string> GetEffectDesc()
	{
		return null;
	}

	private int GetUnlockWeight()
	{
		return 0;
	}
}
