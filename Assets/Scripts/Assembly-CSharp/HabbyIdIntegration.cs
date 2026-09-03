using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Habby.Account.Data;

public class HabbyIdIntegration : IHabbyIdIntegration, IHIDDataRequest, IHabbyIdActions
{
	public class Dataplex
	{
		public static bool IsRewarded;

		public static string HabbyID;

		public static string RewardCfg;

		public static uint OpenGameLevel;

		public static bool IsBinding => false;
	}

	[CompilerGenerated]
	private static Action m_OnStateChanged;

	[CompilerGenerated]
	private static Action<bool> m_OnLoginFinish;

	[CompilerGenerated]
	private static Action m_OnUIOpened;

	public Action OnHIDResponse;

	private static HabbyIdIntegration _instance;

	private string _language;

	public string GameId => null;

	public static HabbyIdIntegration Instance => null;

	public string Language => null;

	public bool ShouldShowRedDot => false;

	public bool ShouldShowBindReward => false;

	public static event Action OnStateChanged
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

	public static event Action<bool> OnLoginFinish
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

	public static event Action OnUIOpened
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

	public void TrackEvent(string eventName, Dictionary<string, object> eventProps)
	{
	}

	public void ShowLoading(bool show)
	{
	}

	public void OnStateChange()
	{
	}

	public void OnLoginComplete(bool success)
	{
	}

	public void OnUIOpen()
	{
	}

	public string GetGameAccountId()
	{
		return null;
	}

	public string GetGameUserId()
	{
		return null;
	}

	public bool CheckHabbyIdLogin()
	{
		return false;
	}

	public void RequestHID(Action<bool, int> callback)
	{
	}

	public void LoginHabbyId(string authCode, LoginMode mode, Action<bool, int> callback)
	{
	}

	public void RequestOrLoginHID(string authCode = null, LoginMode mode = LoginMode.BindOrLogin, Action<bool, int> callback = null)
	{
	}

	public void LogoutHabbyId(Action<bool, int> callback)
	{
	}

	public bool IsHabbyIdRootOpen()
	{
		return false;
	}

	public bool GetAccessTokenToken(out string accessToken)
	{
		accessToken = null;
		return false;
	}

	public void Init(HabbyIdServer server)
	{
	}

	private void LoadHabbyIdPrefab()
	{
	}

	private string GetServerUrl(HabbyIdServer server)
	{
		return null;
	}

	public void SetLanguage(string language)
	{
	}

	public void ClickLoginFromSetting()
	{
	}

	public void ClickLoginFromSelectProgress()
	{
	}

	public void ClickLoginFromStoreSilent()
	{
	}

	public void ClickLogout()
	{
	}

	public void SetEnabled(bool enable)
	{
	}

	public HabbyIdDriver.HabbyIdState GetState()
	{
		return null;
	}

	public void RefreshRedDot()
	{
	}
}
