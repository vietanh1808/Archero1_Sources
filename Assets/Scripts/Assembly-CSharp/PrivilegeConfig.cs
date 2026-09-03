using System;

[Serializable]
public class PrivilegeConfig
{
	public int ID;

	public long StartTime;

	public long EndTime;

	public string ProductId;

	public int DiamondNum;

	public int[][] PurchaseReward;

	public int[][] DailyReward;

	public int[] PowerList;

	public static PrivilegeConfig Create(int id, long startTime, long endTime, string productId, int diamondNum, int[][] purchaseReward, int[][] dailyReward, int[] powerList)
	{
		return null;
	}
}
