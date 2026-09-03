using System.Collections.Generic;
using GameProtocol;

public class ContinuousBuyMgr
{
	public class ContinuousBuyConfig
	{
		public int Tag;

		public int Version;

		public long OpenTime;

		public long NoPushTime;

		public long EndTime;

		public int OpenGameLevel;

		public ContinuousBuyGiftConfig[] Rewards;
	}

	public class ContinuousBuyGiftConfig
	{
		public int id;

		public int GiftId;

		public int Layer_Min;

		public int GameLevel;

		public string Product_id;

		public int[][] Optional;

		public int Discount;

		public int CloseTime;

		public int BagPicColor;
	}

	public const int PopPanelbaseId = 2000;

	private static ContinuousBuyMgr instance;

	private CRespActivityContinueGift mSeverData;

	private ContinuousBuyConfig mCurConfig;

	private ContinuousBuyGiftConfig[] giftconfigs;

	public static ContinuousBuyMgr Instance => null;

	public bool IsOpen => false;

	public bool IsActivityOpen => false;

	private ContinuousBuyMgr()
	{
	}

	public void UnInit()
	{
	}

	public void ReqS3()
	{
	}

	public void ReqServerData(bool isShowPop = false)
	{
	}

	public List<ContinuousBuyGiftConfig> GetShowGiftsList()
	{
		return null;
	}

	public bool GetGiftHasBuyed(int giftid)
	{
		return false;
	}

	public void SetGiftHasBuyed(int giftid)
	{
	}

	public long GetTimeDown()
	{
		return 0L;
	}

	public void PopGiftPanel()
	{
	}
}
