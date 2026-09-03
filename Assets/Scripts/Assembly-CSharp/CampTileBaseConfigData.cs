using XLua;

public class CampTileBaseConfigData
{
	public (int, int) pos;

	public int[] occupyValue;

	public int tileoccupyCamp;

	public bool isPass;

	public int attackCount;

	public CampTileModelData modelData;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix1_Create;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Create(CampTileParseData parseData)
	{
	}

	public static T Create<T>(CampTileParseData parseData) where T : CampTileBaseConfigData, new()
	{
		return null;
	}

	public void UpdateData(CampID occupyCamp, int[] occupyValue, int addAttackCount)
	{
	}
}
