using System;
using System.Collections.Generic;
using UnityEngine;

public class AdsRequestHelper : MonoBehaviour
{
	protected class RequestLoop
	{
		private enum Status
		{
			UNINITIALIZED = 0,
			REQUESTING = 1,
			FAILED = 2,
			LOADED = 3,
			SHOWING = 4
		}

		public delegate void DoRequest();

		public delegate bool CheckLoaded();

		public delegate void ReportError(string error);

		private float lastRequestTime;

		private float lastLoadedTime;

		private const int MIN_REQUEST_INTERVAL = 10;

		private const int MAX_REQUEST_INTERVAL = 600;

		private const int MAX_LOADED_INTERVAL = 600;

		private const int MAX_SHOW_INTERVAL = 300;

		protected int retryCount;

		private Status status;

		private DoRequest doRequest;

		private CheckLoaded checkLoaded;

		private ReportError reportError;

		public RequestLoop(DoRequest doRequest, CheckLoaded checkLoaded, ReportError reportError)
		{
		}

		public void Init()
		{
		}

		private void Request(bool isRetry = false)
		{
		}

		public void checkRequest(AdsItemConfigData slotCfg, bool ignoreRetryLimit = false)
		{
		}

		protected void failCheck(AdsItemConfigData slotCfg, float time)
		{
		}

		public void onLoad()
		{
		}

		public void onFail()
		{
		}

		public void onOpen()
		{
		}

		public void onClose()
		{
		}

		public bool isLoaded()
		{
			return false;
		}
	}

	protected class MsgQueue
	{
		private readonly Queue<Action> _executionQueue;

		public void Update()
		{
		}

		public void Run(Action action)
		{
		}
	}

	public interface AdsDriver
	{
		bool isLoaded();

		bool isBusy();

		bool isPlaying();

		bool Show();
	}

	protected abstract class BaseDriver : AdsDriver
	{
		protected string adUnitId;

		protected AdsCallback callback;

		public abstract void Init(AdsCallback callback);

		public abstract bool isLoaded();

		public abstract bool isBusy();

		public abstract bool isPlaying();

		public abstract bool Show();

		public abstract void doRequest();

		public abstract string getName();

		public virtual void updateConfig(string config)
		{
		}

		public virtual AdsCallback getCallback()
		{
			return null;
		}

		public virtual void setCallback(AdsCallback callback)
		{
		}

		public void LogFunc(string log)
		{
		}
	}

	protected class ALMaxInterstitialDriver : BaseDriver
	{
		private bool playing;

		private bool busy;

		private bool loaded;

		public override string getName()
		{
			return null;
		}

		public ALMaxInterstitialDriver(string adUnitId)
		{
		}

		public override void Init(AdsCallback callback)
		{
		}

		public override void doRequest()
		{
		}

		public override bool isLoaded()
		{
			return false;
		}

		public override bool isBusy()
		{
			return false;
		}

		public override bool isPlaying()
		{
			return false;
		}

		public override bool Show()
		{
			return false;
		}
	}

	protected class ALMaxRewardedDriver : BaseDriver
	{
		private bool playing;

		private bool busy;

		private bool loaded;

		public override string getName()
		{
			return null;
		}

		public ALMaxRewardedDriver(string adUnitId)
		{
		}

		public override void Init(AdsCallback callback)
		{
		}

		public override void doRequest()
		{
		}

		public override bool isLoaded()
		{
			return false;
		}

		public override bool Show()
		{
			return false;
		}

		public override bool isBusy()
		{
			return false;
		}

		public override bool isPlaying()
		{
			return false;
		}
	}

	public interface AdsCallback
	{
		void onRequest(AdsDriver sender, string networkName);

		void onLoad(AdsDriver sender, string networkName);

		void onFail(AdsDriver sender, string msg);

		void onOpen(AdsDriver sender, string networkName);

		void onClose(AdsDriver sender, string networkName);

		void onClick(AdsDriver sender, string networkName);

		void onReward(AdsDriver sender, string networkName);
	}

	protected class WrappedDriver : BaseDriver, AdsCallback
	{
		private BaseDriver driver;

		private RequestLoop loop;

		private MsgQueue queue;

		private char loopId;

		public override string getName()
		{
			return null;
		}

		public WrappedDriver(char loopId, BaseDriver driver)
		{
		}

		public override void Init(AdsCallback callback)
		{
		}

		protected void reportError(string error)
		{
		}

		public override void doRequest()
		{
		}

		public override bool isLoaded()
		{
			return false;
		}

		public override bool isBusy()
		{
			return false;
		}

		public override bool isPlaying()
		{
			return false;
		}

		public override bool Show()
		{
			return false;
		}

		public void onRequest(AdsDriver sender, string networkName)
		{
		}

		public void onLoad(AdsDriver sender, string networkName)
		{
		}

		public void onFail(AdsDriver sender, string msg)
		{
		}

		public void onOpen(AdsDriver sender, string networkName)
		{
		}

		public void onClose(AdsDriver sender, string networkName)
		{
		}

		public void onClick(AdsDriver sender, string networkName)
		{
		}

		public void onReward(AdsDriver sender, string networkName)
		{
		}
	}

	protected class CombinedDriver : BaseDriver, AdsCallback
	{
		private enum Strategy
		{
			PRIORITIZED = 0,
			RANDOM = 1
		}

		private BaseDriver[] drivers;

		private int[] rates;

		private Dictionary<char, BaseDriver> driverList;

		private bool loaded;

		private Strategy strategy;

		public override string getName()
		{
			return null;
		}

		public override void updateConfig(string config)
		{
		}

		public CombinedDriver(Dictionary<char, BaseDriver> driverList, string defaultConfig)
		{
		}

		public override void Init(AdsCallback callback)
		{
		}

		public override void doRequest()
		{
		}

		public override bool isLoaded()
		{
			return false;
		}

		public override bool isBusy()
		{
			return false;
		}

		public override bool isPlaying()
		{
			return false;
		}

		public override bool Show()
		{
			return false;
		}

		public void onRequest(AdsDriver sender, string networkName)
		{
		}

		public void onLoad(AdsDriver sender, string networkName)
		{
		}

		public void onFail(AdsDriver sender, string msg)
		{
		}

		public void onOpen(AdsDriver sender, string networkName)
		{
		}

		public void onClose(AdsDriver sender, string networkName)
		{
		}

		public void onClick(AdsDriver sender, string networkName)
		{
		}

		public void onReward(AdsDriver sender, string networkName)
		{
		}
	}

	public interface CallbackManager
	{
		void AddCallback(AdsCallback callback);

		void RemoveCallback(AdsCallback callback);
	}

	protected class CallbackRouter : CallbackManager, AdsCallback
	{
		private List<AdsCallback> callbacks;

		private AdsCallback exclusiveCallback;

		public void AddCallback(AdsCallback callback)
		{
		}

		public void RemoveCallback(AdsCallback callback)
		{
		}

		public void SetExclusiveCallback(AdsCallback callback)
		{
		}

		public void onRequest(AdsDriver sender, string networkName)
		{
		}

		public void onLoad(AdsDriver sender, string networkName)
		{
		}

		public void onFail(AdsDriver sender, string msg)
		{
		}

		public void onOpen(AdsDriver sender, string networkName)
		{
		}

		public void onClose(AdsDriver sender, string networkName)
		{
		}

		public void onClick(AdsDriver sender, string networkName)
		{
		}

		public void onReward(AdsDriver sender, string networkName)
		{
		}
	}

	public interface AdsAdapter : AdsDriver, CallbackManager
	{
		bool Show(AdsCallback enabledCallback);

		bool Show(AdsCallback enabledCallback, ADSource source);

		void UpdateConfig(string config);
	}

	protected class WrappedAdapter : AdsAdapter, AdsDriver, CallbackManager
	{
		private CallbackRouter callbacks;

		private BaseDriver driver;

		public WrappedAdapter(BaseDriver driver)
		{
		}

		public bool isLoaded()
		{
			return false;
		}

		public bool isBusy()
		{
			return false;
		}

		public bool isPlaying()
		{
			return false;
		}

		public bool Show()
		{
			return false;
		}

		public bool Show(AdsCallback enabledCallback)
		{
			return false;
		}

		public bool Show(AdsCallback enabledCallback, ADSource source)
		{
			return false;
		}

		public void UpdateConfig(string config)
		{
		}

		public void AddCallback(AdsCallback callback)
		{
		}

		public void RemoveCallback(AdsCallback callback)
		{
		}
	}

	protected class DummyAdapter : AdsAdapter, AdsDriver, CallbackManager
	{
		private List<AdsCallback> callbacks;

		private AdsAdapter adapter;

		private string config;

		public bool isLoaded()
		{
			return false;
		}

		public bool isBusy()
		{
			return false;
		}

		public bool isPlaying()
		{
			return false;
		}

		public bool Show()
		{
			return false;
		}

		public bool Show(AdsCallback enabledCallback)
		{
			return false;
		}

		public bool Show(AdsCallback enabledCallback, ADSource source)
		{
			return false;
		}

		public void UpdateConfig(string config)
		{
		}

		public void AddCallback(AdsCallback callback)
		{
		}

		public void RemoveCallback(AdsCallback callback)
		{
		}

		public void SetAdapter(AdsAdapter adapter)
		{
		}
	}

	public struct AdsConfiguration
	{
		public string almaxInterstitial;

		public string almaxRewarded_middle1;

		public string almaxRewarded_middle2;

		public string almaxRewarded_high1;

		public string almaxRewarded_high2;

		public string almaxRewarded_high3;
	}

	[Serializable]
	public class AdsItemConfigData
	{
		public bool disable_b2b;

		public int request_interval_min;

		public bool progressive_interval;

		public int request_interval_max;

		public bool is_high;

		public int request_limit;

		public bool enabled;
	}

	[Serializable]
	public class AdsConfigData
	{
		public bool disable_retry;

		public Dictionary<char, AdsItemConfigData> slots;

		public AdsItemConfigData get_slot_config(char slotId)
		{
			return null;
		}
	}

	protected static AdsRequestHelper inst;

	private AdsConfiguration config;

	private static bool needGDPR;

	protected MsgQueue queue;

	protected Dictionary<char, RequestLoop> loops;

	protected static readonly int INTERSTITIAL_ADAPTER_COUNT;

	protected static readonly int REWARDED_ADAPTER_COUNT;

	private Dictionary<char, BaseDriver> interstitialDrivers;

	private Dictionary<char, BaseDriver> rewardedDrivers;

	private AdsAdapter[] interstitialAdapters;

	private AdsAdapter[] rewardedAdapters;

	private static DummyAdapter[] interstitialAdaptersDummy;

	private static DummyAdapter[] rewardedAdaptersDummy;

	private int frame;

	public static bool send_high;

	private const bool _mopubtest = false;

	public static string pangle_app_id;

	public static ADSource ad_source;

	private static AdsConfigData default_ads_config;

	public static bool mopub_test => false;

	public static void DebugLog(string msg)
	{
	}

	public static bool isInitialized()
	{
		return false;
	}

	public static bool isActive()
	{
		return false;
	}

	public static bool needShowGDPRConsent()
	{
		return false;
	}

	public static void GrantGDPRConsent()
	{
	}

	public static void Init(AdsConfiguration config, Action onComplete = null)
	{
	}

	protected AdsAdapter getInterstitialAdapterInternal(int adapterId, string cfg)
	{
		return null;
	}

	public static AdsAdapter getInterstitialAdapter(int adapterId = 0, string cfg = null)
	{
		return null;
	}

	protected AdsAdapter getRewardedAdapterInternal(int adapterId, string cfg)
	{
		return null;
	}

	public static AdsAdapter getRewardedAdapter(int adapterId = 0, string cfg = null)
	{
		return null;
	}

	private void Update()
	{
	}

	private static void InitFacebook()
	{
	}

	public static void Init()
	{
	}

	private static void OnInitializedCompleted()
	{
	}

	public static void rewarded_addcallback(AdsCallback callback, int adapterId = 0)
	{
	}

	public static void rewarded_removecallback(AdsCallback callback, int adapterId = 0)
	{
	}

	public static bool rewarded_high_eCPM_isLoaded()
	{
		return false;
	}

	public static void rewarded_high_eCPM_show(AdsCallback callback, ADSource source)
	{
	}

	protected static AdsConfigData get_ext_config()
	{
		return null;
	}

	protected static string get_disable_b2b_ids(AdsConfiguration config)
	{
		return null;
	}
}
