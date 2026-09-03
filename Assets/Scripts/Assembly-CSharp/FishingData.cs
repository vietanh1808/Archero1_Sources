using XLua;

public class FishingData : RecycleData<FishingConfigData>
{
	private static DelegateBridge __Hotfix0_get_Tag;

	private static DelegateBridge __Hotfix0_get_IsOpen;

	private static DelegateBridge __Hotfix0_get_IsFishingOpen;

	private static DelegateBridge __Hotfix0_get_IsShoppingOpen;

	private static DelegateBridge __Hotfix0_get_LeftTime;

	private static DelegateBridge __Hotfix0_get_FishingLeftTime;

	private static DelegateBridge __Hotfix0_get_ShopLeftTime;

	private static DelegateBridge __Hotfix0_get_FishingTotalWeight;

	private static DelegateBridge __Hotfix0_get_FishingScoreCount;

	private static DelegateBridge __Hotfix0_get_FishLineCount;

	private static DelegateBridge __Hotfix0_get_FishKingScaleCount;

	private static DelegateBridge __Hotfix0_UpdateTotalWeight;

	private static DelegateBridge __Hotfix0_GetCurrencyCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int Tag => 0;

	public bool IsOpen => false;

	public bool IsFishingOpen => false;

	public bool IsShoppingOpen => false;

	public long LeftTime => 0L;

	public long FishingLeftTime => 0L;

	public long ShopLeftTime => 0L;

	public long FishingTotalWeight => 0L;

	public int FishingScoreCount => 0;

	public int FishLineCount => 0;

	public int FishKingScaleCount => 0;

	public void UpdateTotalWeight(long weight)
	{
	}

	public int GetCurrencyCount(int id)
	{
		return 0;
	}
}
