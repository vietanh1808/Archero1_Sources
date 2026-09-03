using System.Collections.Generic;
using GameProtocol;

public class DropUpPropData
{
	public DropUpPropType dropType;

	public ushort activityType;

	public float dropRate;

	public float weightsRate;

	public string dropEquips;

	public string strShow;

	public List<int> DropIDlist;

	public List<int> ShowIDList;

	public long endTime;

	public long beginTime;

	public int rewardLog;

	public string dropRateShow;

	public string rewardnum;

	public List<CActivityDropRateTask> RateTask;

	public List<CActivityDropRateTask> FinishTask;

	public List<CActivityDropRateTask> CanFinishTask;

	public List<CActivityDropRateTask> NotFinishTask;

	public float DropTotalRate;

	public float DropUpLimitRate;

	public static DropUpPropData Create()
	{
		return null;
	}

	public void GetRateTask(CActivityDropRateType ratedata)
	{
	}

	private void GetDropEquipsID(string strDropEquips)
	{
	}

	public void GetTaskStage()
	{
	}

	private void GetShowID(string strShow)
	{
	}

	public void BitConvert(int reward)
	{
	}

	public bool IfCanShow()
	{
		return false;
	}

	public bool CanShowRedPoint()
	{
		return false;
	}
}
