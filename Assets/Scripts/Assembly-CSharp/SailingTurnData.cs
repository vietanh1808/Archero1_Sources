using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

public class SailingTurnData
{
	public CWheelData SeverData;

	private WheelItemConfig[] wheelItemConfigs;

	private List<SailingTurnPreviewItemData> PreviewItems;

	private List<SailingTurnItemData> wheelItems;

	public int WheelType => 0;

	public int MaxDailyRefreshFreeCount => 0;

	public int CurDailyRefreshCount => 0;

	public bool isFreeFresh => false;

	public int MaxDailWheelCount => 0;

	public int CurDailyWheelCount => 0;

	public int CurReFreshPrice => 0;

	public int RemainWheelCount => 0;

	public int NeedWheelId => 0;

	public Sprite NeedWheelIcon => null;

	public int HaveWheelMatCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool isEnough => false;

	public bool isCanWheel => false;

	public int GameLevel => 0;

	public uint[] vecInnerWheel => null;

	public void RefreshData(CWheelData _SeverData, WheelItemConfig[] _wheelItemConfigs)
	{
	}

	public List<SailingTurnPreviewItemData> GetPreviewDatas()
	{
		return null;
	}

	public List<SailingTurnItemData> GetWheelItems()
	{
		return null;
	}

	public uint[] GetWheelRate()
	{
		return null;
	}

	public int GetRatePos(int rate)
	{
		return 0;
	}

	public int GetRewardPos(int RewardId)
	{
		return 0;
	}

	public bool GetRewardIsBig(int RewardId)
	{
		return false;
	}

	public int GetBigRewardId()
	{
		return 0;
	}

	public int GetBigRewardPropId()
	{
		return 0;
	}

	private WheelItemConfig GetConfigById(int id)
	{
		return null;
	}
}
