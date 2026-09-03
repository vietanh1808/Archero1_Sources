using System;
using System.Collections.Generic;
using UnityEngine;

public class AndroidAdapterManager : MonoBehaviour
{
	protected class AccountProxy : AndroidJavaProxy
	{
		public AccountProxy()
			: base((string)null)
		{
		}

		public void OnInit_Success()
		{
		}

		public void OnInit_Fail(int code)
		{
		}

		public void OnLogin_Success(string uid, string uname)
		{
		}

		public void OnLogin_Fail(int code)
		{
		}

		public void OnLogout()
		{
		}
	}

	protected class IAPProxy : AndroidJavaProxy
	{
		public IAPProxy()
			: base((string)null)
		{
		}

		public void OnInit_Success()
		{
		}

		public void OnInit_Fail(int code)
		{
		}

		public void OnPurchase_Success(string productId, string orderId, string json)
		{
		}

		public void OnPurchase_Fail(int errCode)
		{
		}
	}

	protected class AdsProxy : AndroidJavaProxy
	{
		public AdsProxy()
			: base((string)null)
		{
		}

		public void onLoad(string ad_id)
		{
		}

		public void onLoadFail(string ad_id, int errorCode)
		{
		}

		public void onAdOpen(string ad_id)
		{
		}

		public void onAdShowFail(string ad_id, int errorCode)
		{
		}

		public void onAdClosed(string ad_id)
		{
		}

		public void onRewarded(string ad_id)
		{
		}
	}

	private static Action<SdkManager.LoginData> OnLoginSuccess;

	public Action<string, string, string> OnPurchaseSuccess;

	public Action<int> OnPurchaseFailed;

	protected static AndroidAdapterManager _instance;

	private AndroidJavaClass adapterManagerClass;

	private AndroidJavaObject adapterManagerObj;

	private bool isAccountInit;

	private bool isIAPInit;

	private bool isDoLogin;

	private bool isLogin;

	private Queue<Action> _queue;

	private const string ANDROID_ACCOUNT_LISTENER_CLASS = "com.habby.base.callback.IAccountListener";

	private const string ANDROID_IAP_LISTENER_CLASS = "com.habby.base.callback.IIAPListener";

	public static Action<string> OnRewardAdLoad;

	public static Action<string, int> OnRewardAdLoadFail;

	public static Action<string> OnRewardAdOpen;

	public static Action<string, int> OnRewardAdShowFail;

	public static Action<string> OnRewardAdClosed;

	public static Action<string> OnRewardAdRewarded;

	private AndroidJavaClass adsAdapterManagerClass;

	private AndroidJavaObject adsAdapterManagerObj;

	private const string ANDROID_ADS_LISTENER_CLASS = "com.habby.base.callback.IAdsListener";

	public static AndroidAdapterManager Instance => null;

	public bool CanLogin => false;

	public bool IsLogin => false;

	public bool IsAccountInit => false;

	public void Init()
	{
	}

	public void Login(Action<SdkManager.LoginData> callback)
	{
	}

	private void Login()
	{
	}

	public void Logout()
	{
	}

	public void SetUserId(string userId)
	{
	}

	public void Purchase(string productId, int priceType)
	{
	}

	public void Consume(string orderId)
	{
	}

	public void AddLoginAction(SdkManager.LoginData data)
	{
	}

	public void AddPurchaseAction(string productId, string orderId, string json)
	{
	}

	public void AddPurchaseAction(int errCode)
	{
	}

	private void Update()
	{
	}

	public void Ads_Init(string ad_id)
	{
	}

	public void Ads_Load()
	{
	}

	public bool Ads_IsLoaded()
	{
		return false;
	}

	public void Ads_Show()
	{
	}
}
