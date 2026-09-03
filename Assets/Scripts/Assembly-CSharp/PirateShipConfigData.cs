using System.Collections.Generic;

public class PirateShipConfigData
{
	public int tag;

	public long startTime;

	public long endTime;

	public List<PirateShipItemConfigData> itemConfigData;

	public static PirateShipConfigData Create(int tag, long startTime, long endTime, List<PirateShipItemConfigData> itemConfigData)
	{
		return null;
	}
}
