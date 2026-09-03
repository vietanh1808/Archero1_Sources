using System;
using System.Collections.Generic;
using GameProtocol;

public class Act6thSignManager : CInstance<Act6thSignManager>
{
	public int currentDay;

	public List<Act6thSignItemData> signDataList;

	public void parseSignData(STRespActivitySixthAnniversary data)
	{
	}

	private void parseSignItemData(STRespActivitySixthAnniversary data)
	{
	}

	public void requestSignGet(int sid, Action<STRespActivitySixthAnniversary, int> action = null)
	{
	}

	public List<Act6thSignItemData> GetSignDataList()
	{
		return null;
	}

	private Act6thSignItemData GetSignItemData(int sid)
	{
		return null;
	}

	public bool isHaveRewardCanGet()
	{
		return false;
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}
}
