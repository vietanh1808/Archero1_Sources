using System;
using GameProtocol;

public class TradingHouseLogData
{
	public long unixTime;

	public int commodityId;

	public int count;

	public TradingHouseBehavior behavior;

	public int price;

	public DateTime DateTime => default;

	public long UnixDayTime => 0L;

	public TradingHouseLogData(STActivityTradingPostRecord severData)
	{
	}
}
