using System;
using System.Collections.Generic;
using GameProtocol;

public class LoginGiftMgr : CInstance<LoginGiftMgr>
{
	public CRespLoginGift giftdata;

	public List<LoginGiftOne> glist;

	public List<SigninRewardOne> slist;

	public void SetGiftData(CRespLoginGift gift)
	{
	}

	public List<LoginGiftOne> GetGiftList()
	{
		return null;
	}

	private List<LoginGiftOne> GetGiftOne(CRespLoginGift gift)
	{
		return null;
	}

	public void InformNextOne(int next)
	{
	}

	public bool GetDate()
	{
		return false;
	}

	public void ClearList()
	{
	}

	public void requestDailyGift(Action<bool> callback = null)
	{
	}

	public bool isShowDailyGift()
	{
		return false;
	}

	public bool CanGetReward()
	{
		return false;
	}
}
