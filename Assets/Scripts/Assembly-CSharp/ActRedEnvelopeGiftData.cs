using System.Collections.Generic;
using TableTool;

public class ActRedEnvelopeGiftData
{
	public ActRedEnvelopeMgr.RedEnvelopeGiftConfig Config;

	public int hasBuyCount;

	public int LeftBuyCount => 0;

	public int ID => 0;

	public string ProductID => null;

	public bool IsAdvertising => false;

	public int Discount => 0;

	public int MaxBuyCount => 0;

	public bool IsDailyReset => false;

	public List<Drop_DropModel.DropData> Rewards => null;
}
