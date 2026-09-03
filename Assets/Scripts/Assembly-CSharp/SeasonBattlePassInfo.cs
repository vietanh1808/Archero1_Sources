using System;
using System.Runtime.CompilerServices;
using GameProtocol;
using Newtonsoft.Json;

public class SeasonBattlePassInfo
{
	[JsonIgnore]
	private bool isGetting;

	[CompilerGenerated]
	private Action<int, CRespPveBattlepass> m_onGetSeasonBattlePass;

	public int[] mask { get; private set; }

	[JsonIgnore]
	public CRespPveBattlepass data { get; private set; }

	private event Action<int, CRespPveBattlepass> onGetSeasonBattlePass
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void GetSeasonBattlePass(Action<int, CRespPveBattlepass> onComplete)
	{
	}

	public int CheckRedPoint()
	{
		return 0;
	}

	private void CallBattlePassEvent(int code)
	{
	}

	public void GetReward(int index, int type, Action<int, CRespPveBattlepass> onComplete)
	{
	}

	public void GetEndBoxReward(Action<int, CRespPveBattlepass> onComplete)
	{
	}

	public void BuySeasonBPToken(string iapId, Action<bool> onComplete)
	{
	}

	public bool IsSeasonEnd()
	{
		return false;
	}

	private int[] GetMaskData(CRespPveBattlepass d)
	{
		return null;
	}
}
