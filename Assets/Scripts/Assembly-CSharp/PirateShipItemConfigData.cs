using GameProtocol;

public class PirateShipItemConfigData
{
	public int id;

	public string productID;

	public CRewardItem[] reward;

	public int isBuy;

	public int discount;

	public bool isDailyReset;

	public int buyLimit;

	public static PirateShipItemConfigData Create(int id, string productID, CRewardItem[] reward, int isBuy, int discount, bool dailyReset, int buyLimit)
	{
		return null;
	}

	public void UpdateBuyStatus(int isBuy)
	{
	}
}
