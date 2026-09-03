using UnityEngine;

public class DailyActivityOneCtrl : MonoBehaviour
{
	public ButtonCtrl Button_Buy;

	public DxxText Text_Buy;

	public DxxText Text_Title;

	public GameObject itemparent;

	public GameObject itemone;

	public DxxText Text_ADBuy;

	public DxxText Text_HasBuy;

	public DxxText Text_BPFree;

	public GameObject buttonMask;

	public GameObject bgMask;

	public VIPFlagItem vipItem;

	public DxxText Text_Star;

	public bool starBuyUsed;

	private const float OneWidth = 160f;

	private bool bInit;

	protected LocalSave.ActivityBuyOne m_Data;

	protected LocalSave.ActivityBuyADData m_adData;

	private LocalUnityObjctPool mPool;

	protected AdCallbackControl mAd;

	protected string selectionTokenPayed => null;

	private string selectionTokenAd => null;

	protected virtual ActivityGiftType giftType => ActivityGiftType.Daily;

	private string iapRewardId => null;

	private string adRewardId => null;

	private void init()
	{
	}

	protected virtual void OnClickBuy()
	{
	}

	public void InitByIapData(LocalSave.ActivityBuyOne data)
	{
	}

	private (int, int)? GetRedEnvelope(object obj)
	{
		return null;
	}

	public void InitByAD(LocalSave.ActivityBuyADData adData)
	{
	}

	protected void OnADEndWrapper()
	{
	}

	protected virtual void OnADEnd()
	{
	}

	protected void OnGetReward()
	{
	}

	public void OnClose()
	{
	}

	protected virtual void OnLanguageChange()
	{
	}
}
