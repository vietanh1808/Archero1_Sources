using TableTool;

public class ThemeSupplyBoxGem : ThemeSupplyBox
{
	public Drop_DropModel.DropData mainReward;

	public override Type GetBoxType()
	{
		return Type.HERO;
	}

	public override Drop_DropModel.DropData GetMainReward()
	{
		return null;
	}
}
