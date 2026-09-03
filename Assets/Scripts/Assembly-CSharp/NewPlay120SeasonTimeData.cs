using System;

[Serializable]
public class NewPlay120SeasonTimeData
{
	public int ID;

	public long StartTime;

	public long EndTime;

	public int RewardId;

	public bool IsInThisSeason => false;

	private bool CheckInThisSeason()
	{
		return false;
	}
}
