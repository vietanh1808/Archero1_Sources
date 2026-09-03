using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using RichDialog;
using TableTool;

public class WindowUI
{
	public class UIData
	{
		public WindowID id;

		public int order;
	}

	public struct PopData
	{
		public WindowID id;

		public object data;

		public PopData(WindowID id, object data)
		{
			this.id = WindowID.WindowID_Invaild;
			this.data = null;
		}
	}

	[CompilerGenerated]
	private static Action<WindowID, List<WindowID>> m_OnInGameWindowClose;

	[CompilerGenerated]
	private static Action<WindowID, List<WindowID>> m_OnInGameWindowOpen;

	[CompilerGenerated]
	private static Action<WindowID> m_OnShowWindowAction;

	[CompilerGenerated]
	private static Action<WindowID> m_OnShowWindowEndAction;

	[CompilerGenerated]
	private static Action<WindowID> m_OnCloseWindowAction;

	public static Action OnAllPopWinodwClose;

	private static List<UIData> mUIDatas;

	private static List<WindowID> currencies;

	private static int mMaskCount;

	private static int mNetDoingCount;

	private static List<WindowID> mInGameList;

	private static List<WindowID> mOutGameList;

	private static List<WindowID> mAllList;

	public static bool bUsePopMgr;

	private static List<PopData> mPopOut;

	public static event Action<WindowID, List<WindowID>> OnInGameWindowClose
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

	public static event Action<WindowID, List<WindowID>> OnInGameWindowOpen
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

	public static event Action<WindowID> OnShowWindowAction
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

	public static event Action<WindowID> OnShowWindowEndAction
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

	public static event Action<WindowID> OnCloseWindowAction
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

	public static int GetZByOrder(int o)
	{
		return 0;
	}

	public static void ChangeUIInUICamera(WindowID id)
	{
	}

	public static void ChangeUIToTop(WindowID id)
	{
	}

	public static List<UIData> GetUIDataList()
	{
		return null;
	}

	private static void AddUIData(WindowID id)
	{
	}

	private static void RemoveUIData(WindowID id)
	{
	}

	public static UIData GetUIData(WindowID id)
	{
		return null;
	}

	public static int GetMaxOrder()
	{
		return 0;
	}

	private static int GetMaxZ()
	{
		return 0;
	}

	private static bool is_have_uidata(WindowID id)
	{
		return false;
	}

	public static void Init()
	{
	}

	public static void PreloadWindowRes(WindowID id)
	{
	}

	public static void ShowWindow(WindowID id, object data = null)
	{
	}

	private static void _ShowWindow(WindowID id, object data = null)
	{
	}

	private static void ShowWindowInternal(WindowID id, object data)
	{
	}

	public static void CloseWindow(WindowID id)
	{
	}

	private static void CloseWindowInternal(WindowID id)
	{
	}

	public static bool IsWindowOpened(WindowID id)
	{
		return false;
	}

	public static void ShowCurrency(WindowID id)
	{
	}

	public static void CheckCurency()
	{
	}

	public static void ShowCurrency()
	{
	}

	private static void CloseCurrencyInternal()
	{
	}

	private static void CloseAllCurrency()
	{
	}

	public static void CloseCurrencyOnly()
	{
	}

	public static void CloseCurrency()
	{
	}

	public static void OpenBeforeCurrency()
	{
	}

	public static RewardSimpleProxy.Transfer ShowRewardSimple(List<Drop_DropModel.DropData> list, string title = "", Action action = null, int extraCount = 0, string desc = null)
	{
		return null;
	}

	public static void ShowGoldBuy(CoinExchangeSource buytype, long needgold, Action<int> callback, bool isOpenPreCurrency = true)
	{
	}

	public static void ShowGoldBuy(CoinExchangeSource buytype, long needgold, Action<int> callback, Action<bool> closeCallback, bool isOpenPreCurrency = true)
	{
	}

	public static void ShowRate(Action closecallback)
	{
	}

	public static void ShowShopSingle(ShopSingleProxy.SingleType type, Action onclose = null)
	{
	}

	public static void ShowBoxOpen(List<Drop_DropModel.DropData> list, uint transId = 0u)
	{
	}

	public static void ShowBoxGemOpen(List<Drop_DropModel.DropData> list, uint transId = 0u, int tenPrice = 0)
	{
	}

	public static void ShowDragonOpen(List<Drop_DropModel.DropData> list, uint transId = 0u, int tenPrice = 0)
	{
	}

	public static void ShowRelicsOpen(List<Drop_DropModel.DropData> list, uint transId = 0u, int tenPrice = 0)
	{
	}

	public static void ShowPetOpen(List<Drop_DropModel.DropData> list, uint transId = 0u, int tenPrice = 0)
	{
	}

	public static void ShowImprintOpen(List<Drop_DropModel.DropData> list, uint transId = 0u, int tenPrice = 0)
	{
	}

	public static void ShowEquipSOpen(List<Drop_DropModel.DropData> list, uint transId = 0u, int tenPrice = 0)
	{
	}

	public static void ShowManorOpen(List<Drop_DropModel.DropData> list, uint transId = 0u, int tenPrice = 0)
	{
	}

	public static void ShowBreakDownBatch(List<Drop_DropModel.DropData> list, uint transId = 0u)
	{
	}

	public static void ShowServerAssert(long time)
	{
	}

	public static void ShowMask(bool value, bool ifLoad = false)
	{
	}

	public static void ShowNetDoing(bool value, NetDoingType type = NetDoingType.netdoing_http, float dt = 0.6f, float dt2 = 0.5f, float closeTime = 0f)
	{
	}

	public static void ShowLoading(Action loading, Action end1 = null, Action end2 = null, BattleLoadProxy.LoadingType type = BattleLoadProxy.LoadingType.eMiss)
	{
	}

	public static void ShowLoading2(Action loadingPre, Action loading, Action end1 = null, Action end2 = null, BattleLoadProxy.LoadingType type = BattleLoadProxy.LoadingType.eMiss)
	{
	}

	public static void Main_to_battle()
	{
	}

	public static void Battle_to_main(Action action = null)
	{
	}

	public static void TryLogin()
	{
	}

	public static void ChangeAccount()
	{
	}

	public static void ShowPopWindowUI(string title, string content, Action<bool> callback, string sureString = "", string closeString = "", bool switchButtonPos = false)
	{
	}

	public static void ShowPopWindowOneUI(string title, string content, string sure, bool closebuttonshow, Action callback, bool showsurebutton = true)
	{
	}

	public static void ShowCheatPop(bool canClose)
	{
	}

	public static void ShowPopWindowSimpleUI(string title, string content, Action callback)
	{
	}

	public static void ShowPopWindowBuyConfirmUI(string title, string content, string sure, CurrencyType icon, bool closebuttonshow, Action callback, bool showsurebutton = true, bool showicon = true, int style = 0)
	{
	}

	public static void ShowPopWindowInfoUI(string title, string content, string sure, bool closebuttonshow, Action callback, bool showsurebutton = true)
	{
	}

	public static void ShowRewardUI(List<Drop_DropModel.DropData> list)
	{
	}

	public static void ShowAdInsideUI(ADSource source, Action callback)
	{
	}

	public static void ShowLevelUp(int level, Action onclose)
	{
	}

	public static List<WindowID> GetWindowIDs()
	{
		return null;
	}

	public static void AddOpenWindow(WindowID id)
	{
	}

	public static void AddCloseWindow(WindowID id)
	{
	}

	public static bool GetOnlyMain()
	{
		return false;
	}

	public static void GameBegin()
	{
	}

	public static void GameOver()
	{
	}

	private static void CloseGameOut()
	{
	}

	private static void CloseGameIn()
	{
	}

	public static void CloseAllWindows()
	{
	}

	private static bool GetReOpenMainClose(WindowID id)
	{
		return false;
	}

	public static void ReOpenMain()
	{
	}

	public static int GetAllListCount()
	{
		return 0;
	}

	public static WindowID GetLastWindowId()
	{
		return WindowID.WindowID_Invaild;
	}

	public static void ShowRichDialog(RichDialogData data)
	{
	}

	public static void ShowCampTile(int tileID, int xPos, int yPos, Action success = null, Action failure = null, CampTileReOpenTransData data = null)
	{
	}

	public static void showShopBoxTipsUI(string title, string content, Action action = null)
	{
	}

	public static List<PopData> GetPopOutist()
	{
		return null;
	}

	private static void OnOnlyMain(bool value)
	{
	}

	private static void DebugPop()
	{
	}

	private static void ShowPop(WindowID id, object data = null)
	{
	}

	private static void ClosePop(WindowID id)
	{
	}

	public static void ClearPop()
	{
	}
}
