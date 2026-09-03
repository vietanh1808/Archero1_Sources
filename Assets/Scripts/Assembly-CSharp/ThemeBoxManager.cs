using GameProtocol;

public sealed class ThemeBoxManager
{
	public delegate void OnRequestInfo(bool ifSuccess, CRespShopBoxActivity data);

	public delegate void OnGetReward(bool ifSuccess, CRespOpenBoxGem data);

	public static ThemeBoxManager Instance;

	public CBoxGemActivityInfo[] ThemeItemData;

	public ulong currentStep;

	public ulong endTimeStep;

	public ulong synTimeStep;

	static ThemeBoxManager()
	{
	}

	public bool IfValid()
	{
		return false;
	}

	private ThemeBoxManager()
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void SendRequestShopInfo(OnRequestInfo onReqInfo)
	{
	}

	public void SendGetShopReward(ushort typeId, OnGetReward onGetReward, bool isSkipAd = false)
	{
	}

	public void SetThemeData(CBoxGemActivityInfo[] data)
	{
	}

	public void SetTime(ulong cur, ulong tar)
	{
	}
}
