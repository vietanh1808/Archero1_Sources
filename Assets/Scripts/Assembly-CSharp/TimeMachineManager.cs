using System;
using GameProtocol;

public class TimeMachineManager : CInstance<TimeMachineManager>
{
	public bool isHavePullData;

	public TimeMachineData timeData;

	public bool canShowTimeEnvelope => false;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public void requestData(Action<STRespActivityAnniversaryCard, int> action = null)
	{
	}

	public void requestRewardGet(Action<STRespActivityAnniversaryCard, int> action = null)
	{
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}

	public void showTimeEnvelopeUI()
	{
	}

	public bool canGetReward()
	{
		return false;
	}
}
