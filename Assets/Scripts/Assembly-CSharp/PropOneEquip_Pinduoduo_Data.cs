using TableTool;

public class PropOneEquip_Pinduoduo_Data : ViewCellData
{
	public enum Type
	{
		LowerPrices = 0,
		HideItem = 1,
		Item = 2
	}

	public Drop_DropModel.DropData dropData;

	public Type curType;

	public bool isAdd;

	public PropOneEquip_Pinduoduo_Data(int[] data)
	{
	}

	public PropOneEquip_Pinduoduo_Data()
	{
	}
}
