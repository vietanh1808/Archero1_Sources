using System.Collections.Generic;
using TableTool;

public class PirateShipItemData
{
	private PirateShipItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public string ProductID => null;

	public List<Drop_DropModel.DropData> Reward => null;

	public bool IsBuy => false;

	public int Discount => 0;

	public bool IsAdvertising => false;

	public bool IsDailyReset => false;

	public int BuyCount => 0;

	public int BuyLimit => 0;

	public static PirateShipItemData Create(PirateShipItemConfigData configData)
	{
		return null;
	}

	public void UpdateBuyStatus(int isBuy)
	{
	}
}
