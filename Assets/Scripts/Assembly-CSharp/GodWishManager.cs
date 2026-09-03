using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public sealed class GodWishManager
{
	private static GodWishManager instance;

	private static object Locker;

	public bool isPullData;

	public GodWishActData actData;

	public List<GodWishBoxData> boxDataList;

	public List<List<int>> GodDayShowList;

	public List<GodWishTicketData> GodRecordList;

	public int[] PreviewTickets;

	public bool isPassDay;

	public int Temp_LastRound;

	public List<Drop_DropModel.DropData> TicketRewardList;

	public List<GodWishGiftItemData> giftDataList;

	public int ShopPropId;

	public List<GodWishShopItemData> shopDataList;

	public List<GodWishTaskItemData> taskDataList;

	public int[] RoundRewardCount;

	public static GodWishManager Instance => null;

	public bool showGuide => false;

	public long LeftTime => 0L;

	public long LeftTimePlay => 0L;

	public long LeftTimeShop => 0L;

	public int RoundMax => 0;

	public void init()
	{
	}

	public void uninit()
	{
	}

	public void setGuideShow(bool show)
	{
	}

	private bool isOpenMaxLevel()
	{
		return false;
	}

	public bool isOpen()
	{
		return false;
	}

	public bool isOpenPlay()
	{
		return false;
	}

	public bool isOpenShop()
	{
		return false;
	}

	public void requestClearActData(Action<STRespActivityScratchLottery, int> action = null)
	{
	}

	public void requestActData(Action<STRespActivityScratchLottery, int> action = null)
	{
	}

	private void parseGiveItem(STRespActivityScratchLottery data)
	{
	}

	private void parseActData(STRespActivityScratchLottery data)
	{
	}

	private void ParseBoxRewardData(STRespActivityScratchLottery data)
	{
	}

	private void ParseGodDayShowData(STRespActivityScratchLottery data)
	{
	}

	private void ParseGodRecordData(STRespActivityScratchLottery data)
	{
	}

	private void ParseRoundReward(STRespActivityScratchLottery data)
	{
	}

	public void ParsePreviewTicket(STRespActivityScratchLottery data)
	{
	}

	public void requestScratchTicket(Action<STRespActivityScratchLottery, int> action = null)
	{
	}

	private void setTicketReward(STRespActivityScratchLottery data)
	{
	}

	public GodWishTicketData GetGodTicketData(int wid)
	{
		return null;
	}

	public GodWishTicketData GetGodTicketRecordDataLast()
	{
		return null;
	}

	private void parseGiftData(STActivityLotteryGift data)
	{
	}

	public void requestGiftAd(int giftId, Action<STRespActivityScratchLottery, int> action = null)
	{
	}

	public GodWishGiftItemData GetGiftItemData(int giftId)
	{
		return null;
	}

	public bool isGiftAdGet()
	{
		return false;
	}

	private void parseShopData(STActivityLotteryShop data)
	{
	}

	public void requestShopBuyItem(int itemId, int count, Action<STRespActivityScratchLottery, int> action = null)
	{
	}

	public GodWishShopItemData GetShopItemData(int shopId)
	{
		return null;
	}

	public List<GodWishShopItemData> GetShowShopList()
	{
		return null;
	}

	public bool isShopCanExch()
	{
		return false;
	}

	public void requestPropBuy(int count, Action<STRespActivityScratchLottery, int> action = null)
	{
	}

	private void parseTaskData(STRespActivityScratchLottery data)
	{
	}

	public void requestQueryInfo(Action<STRespActivityScratchLottery, int> action = null)
	{
	}

	public void requestTaskGet(int taskId, Action<STRespActivityScratchLottery, int> action = null)
	{
	}

	public GodWishTaskItemData GetTaskItemData(int taskId)
	{
		return null;
	}

	public List<GodWishTaskItemData> GetTaskShowList()
	{
		return null;
	}

	public bool isHaveTaskReward()
	{
		return false;
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}

	public int RoundNext(int round)
	{
		return 0;
	}

	public GodWishBoxData GetBoxDataShow(int round, int type)
	{
		return null;
	}

	public GodWishBoxData GetBoxData(int round, int type)
	{
		return null;
	}

	public bool isEndRoundReward(int round, int type)
	{
		return false;
	}

	public int GetGodSameCount(List<int> list1, List<int> list2)
	{
		return 0;
	}

	public int GetGodSameCountLast()
	{
		return 0;
	}

	public int GetGodTicketRank(int count)
	{
		return 0;
	}

	public string GetGodTicketRankStr(int count)
	{
		return null;
	}

	public List<int> GetGodShowCurrent()
	{
		return null;
	}

	public List<int> GetGodShowDayOne(int day)
	{
		return null;
	}

	public List<GodWishTicketData> GetGodDayRewardShowList()
	{
		return null;
	}

	public List<GodWishTicketData> GetGodWishRecordShowList()
	{
		return null;
	}

	public long Utc8Time0(long stime)
	{
		return 0L;
	}

	public int GetPassDay(long stime, long etime)
	{
		return 0;
	}

	public bool isMainIconRedPoint()
	{
		return false;
	}

	public bool isRed_Task()
	{
		return false;
	}

	public bool isRed_Gift()
	{
		return false;
	}

	public bool isRed_Shop()
	{
		return false;
	}
}
