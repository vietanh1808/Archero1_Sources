using GameProtocol;

public class Act5thManger
{
	public const int ShopMatId = 33089;

	public const string KEY_ACT5_POP_MAIN = "KEY_ACT5_POP_MAIN";

	private static Act5thManger instance;

	private static object Locker;

	private STRespActivityFifthAnniversary mSeverData;

	private PlayerPrefsMgr.PrefDataLong NotPopAct5MainTime;

	private bool isPoped;

	private Act5CheckInData checkInData;

	private Act5thShopData shopData;

	public static Act5thManger Instance => null;

	public long EndTime => 0L;

	public long StartTime => 0L;

	public long RefreshTime => 0L;

	public bool IsOpen => false;

	public bool IsCheckInRed => false;

	public long HikingEndTime => 0L;

	public long HikingStartTime => 0L;

	public bool HikingOpen => false;

	public long LotteryEndTime => 0L;

	public long LotteryStartTime => 0L;

	public bool LotteryOpen => false;

	public long HuntingEndTime => 0L;

	public long HuntingStartTime => 0L;

	public bool HuntingOpen => false;

	public long GardenEndTime => 0L;

	public long GardenStartTime => 0L;

	public bool GardenOpen => false;

	public bool isNotTodayPop
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int ShopMatNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private Act5thManger()
	{
	}

	public void ReqAct5th()
	{
	}

	public void ReqCheckIn(Act5CheckInItemData checkIn)
	{
	}

	public void ReqExchangeShop(Act5thShopItemData shopItem, int count)
	{
	}

	public void ClearSeverData()
	{
	}

	public Act5CheckInData GetCheckInData()
	{
		return null;
	}

	public bool CanCheckIn()
	{
		return false;
	}

	public Act5thShopData GetShopData()
	{
		return null;
	}

	public bool EntanceRed()
	{
		return false;
	}

	public void PopAct5thMainUI()
	{
	}
}
