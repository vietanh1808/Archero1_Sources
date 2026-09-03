using System;
using System.Collections.Generic;
using GameProtocol;
using homepage;

public class PlayerHomePageFacade
{
	private static PlayerHomePageFacade _instance;

	public Queue<SyncHeroVO> heroVOQueues;

	public bool IsSyncSpecialEquips;

	public PlayerNameCard NameCard;

	public bool HasNoCache { get; set; }

	public bool CanSyncEquips { get; private set; }

	public static PlayerHomePageFacade Instance => null;

	public SyncHeroVO CacheSyncHeroVO { get; private set; }

	public bool IsSyncAllEquips { get; private set; }

	public void Init()
	{
	}

	public void EnableSyncEquips()
	{
	}

	public void OnSwitchAccount()
	{
	}

	public void SetSyncHeroVO(SyncHeroVO vo)
	{
	}

	public void SetNameCardVisible(bool show)
	{
	}

	public int GetSyncCardVisible()
	{
		return 0;
	}

	public SyncHeroVO CreateSyncHeroVO()
	{
		return null;
	}

	public SyncHeroVO CompareSyncHeroVO(SyncHeroVO oldHero, SyncHeroVO newHero)
	{
		return null;
	}

	public void GetUserInfo(ulong userId, Action<CRespQueryOtherUser, ulong> onSuccess = null)
	{
	}

	private void showEmptyTip()
	{
	}

	public void SyncEquips(SyncEquipsEnum syncEquipsEnum, Action<CRespEquipWear> successCallback = null, params object[] info)
	{
	}

	public void TryShowPlayerHomePage(CRespQueryOtherUser data, ulong userId)
	{
	}

	public void TrySync2Client(CRespQueryOtherUser data, ulong userId)
	{
	}

	public ServerHeroVO createServerHeroVO(CRespQueryOtherUser data, ulong userId)
	{
		return null;
	}

	public void SyncAll()
	{
	}
}
