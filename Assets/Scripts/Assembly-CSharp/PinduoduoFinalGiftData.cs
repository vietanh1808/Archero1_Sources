public class PinduoduoFinalGiftData : PinduoduoBaseGiftData
{
	public int maxPrice;

	public int minPrice;

	public bool isBaseBuyed;

	public bool isReached;

	public override bool isOpen => false;

	public bool isInSellTime => false;

	public PinduoduoFinalGiftData(int id, int _price, long _startTime, long _endTime, int[][] reward, bool _isLast, int _minPrice)
		: base(0, 0, 0L, 0L, null, _isLast: false)
	{
	}

	public void AddDrops(PropOneEquip_Pinduoduo_Data drop)
	{
	}
}
