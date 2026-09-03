using System;
using System.Collections.Generic;
using GameProtocol;

public class Act7thSignManager : CInstance<Act7thSignManager>
{
	public int currentDay;

	public List<Act7thSignItemData> signDataList;

	public void parseSignData(STRespActivity7thAnniversary data)
	{
	}

	private void parseSignItemData(STRespActivity7thAnniversary data)
	{
	}

	public void requestSignGet(int sid, Action<STRespActivity7thAnniversary, int> action = null)
	{
	}

	public List<Act7thSignItemData> GetSignDataList()
	{
		return null;
	}

	private Act7thSignItemData GetSignItemData(int sid)
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
