using System.Collections.Generic;
using GameProtocol;
using XLua;

public sealed class GiftBoxManager
{
	public enum GiftBoxType
	{
		Equip = 0,
		Gem = 1,
		Diamond = 2,
		Hero = 3,
		Relics = 4,
		Pet = 5,
		Wing = 6,
		Artifact = 7
	}

	public class GiftBoxData
	{
		public int openId;

		public bool haveBuy;

		public long rewardLog;

		public int heroId;

		public int giftType;

		public long actTime;

		public string ProductId;

		public List<GiftCondData> conds;

		public List<GiftItemData> items;

		public int Discount;

		private static DelegateBridge _c__Hotfix0_ctor;
	}

	public class GiftCondData
	{
		public int boxId;

		public int min;

		public int max;

		public int count;

		private static DelegateBridge _c__Hotfix0_ctor;
	}

	public class GiftItemData
	{
		public int index;

		public int level;

		public List<string> list;

		private static DelegateBridge _c__Hotfix0_ctor;
	}

	private static GiftBoxManager instance;

	private static object Locker;

	public Dictionary<GiftBoxType, GiftBoxData> boxDataDict;

	public bool haveRedMain;

	public bool[] haveRedTab;

	public const int Total = 8;

	private static DelegateBridge __Hotfix0_get_Instance;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_uninit;

	private static DelegateBridge __Hotfix0_requestGiftBox;

	private static DelegateBridge __Hotfix0_createCActivityInvestData;

	private static DelegateBridge __Hotfix0_initGiftBoxData;

	private static DelegateBridge __Hotfix0_checkStateInMain;

	private static DelegateBridge __Hotfix0_checkStateAllArrive;

	private static DelegateBridge __Hotfix0_checkOpenId;

	private static DelegateBridge __Hotfix0_isShowEntrance;

	private static DelegateBridge __Hotfix0_showEntranceOne;

	private static DelegateBridge __Hotfix0_LevelToChapter;

	private static DelegateBridge __Hotfix0_LevelPass;

	private static DelegateBridge __Hotfix0_LevelFailCount;

	private static DelegateBridge __Hotfix0_checkHaveGet;

	private static DelegateBridge __Hotfix0_checkCanGet;

	private static DelegateBridge __Hotfix0_checkGetAll;

	private static DelegateBridge __Hotfix0_canGetHasBuy;

	private static DelegateBridge __Hotfix0_canGetNotGet;

	private static DelegateBridge __Hotfix0_noBuyGift;

	private static DelegateBridge __Hotfix0_haveGetNoGet;

	private static DelegateBridge __Hotfix0_getNoGetFirst;

	private static DelegateBridge __Hotfix0_GetGiftBoxData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static GiftBoxManager Instance => null;

	private void init()
	{
	}

	public void uninit()
	{
	}

	public void requestGiftBox(int operation, int gift, int type, int index)
	{
	}

	private CActivityInvestData createCActivityInvestData(CRespActivityInvest info)
	{
		return null;
	}

	private void initGiftBoxData(GiftBoxType type, CActivityInvestData info)
	{
	}

	public void checkStateInMain()
	{
	}

	public void checkStateAllArrive(int tab)
	{
	}

	public int checkOpenId(GiftBoxData data)
	{
		return 0;
	}

	public bool isShowEntrance()
	{
		return false;
	}

	public bool showEntranceOne(GiftBoxType type)
	{
		return false;
	}

	public void LevelToChapter(int level, ref int c, ref int i)
	{
	}

	public void LevelPass(int level, ref int c, ref int pass, ref int total)
	{
	}

	public int LevelFailCount()
	{
		return 0;
	}

	public bool checkHaveGet(GiftBoxData data, int index)
	{
		return false;
	}

	public bool checkCanGet(GiftBoxData data, int index)
	{
		return false;
	}

	public bool checkGetAll(GiftBoxData data)
	{
		return false;
	}

	public bool canGetHasBuy()
	{
		return false;
	}

	public bool canGetNotGet()
	{
		return false;
	}

	public bool noBuyGift()
	{
		return false;
	}

	public bool haveGetNoGet(GiftBoxData data)
	{
		return false;
	}

	public int getNoGetFirst(GiftBoxData data)
	{
		return 0;
	}

	public GiftBoxData GetGiftBoxData(int tab)
	{
		return null;
	}
}
