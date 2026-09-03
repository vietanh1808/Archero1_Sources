using System.Collections.Generic;
using GameProtocol;
using UnityEngine;
using XLua;

public class ActivityPayShipItemCtrl : MonoBehaviour
{
	public GameObject itemparent;

	public GameObject itemone;

	public DxxText Text_title;

	public Transform crit;

	public DxxText Text_Crit;

	public DxxText Text_Value;

	public ButtonCtrl Button_buy;

	public DxxText Text_Buy;

	public GameObject AD_Container;

	public DxxText Text_ADBuy;

	public DxxText Text_HasBuy;

	public DxxText Text_BPFree;

	public GameObject buttonMask;

	public GameObject itemMask;

	public GuildBoxButton Button_GuidGift;

	public DxxText Text_GuidGift;

	public ActivityShipPayOneCtrl firstItem;

	private CActivityShipPayItem mData;

	protected AdCallbackControl mAd;

	private LocalUnityObjctPool mPool;

	private int oneWidth;

	private Dictionary<string, int> languagedic;

	public VIPFlagItem vipItem;

	private List<ActivityShipPayOneCtrl> ctrlItems;

	private static DelegateBridge __Hotfix0_get_sourceName;

	private static DelegateBridge __Hotfix0_Start;

	private static DelegateBridge __Hotfix0_OnClickBuy;

	private static DelegateBridge __Hotfix0_OnPurchaseSuccess;

	private static DelegateBridge __Hotfix0_OnClickGuidGiftBtn;

	private static DelegateBridge __Hotfix0_OnADEndWrapper;

	private static DelegateBridge __Hotfix0_OnADEnd;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_updateData;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge _c__Hotfix0_ctor;

	private string sourceName => null;

	private void Start()
	{
	}

	private void OnClickBuy()
	{
	}

	private void OnPurchaseSuccess()
	{
	}

	private void OnClickGuidGiftBtn()
	{
	}

	protected virtual void OnADEndWrapper()
	{
	}

	protected virtual void OnADEnd()
	{
	}

	public void Init(CActivityShipPayItem data)
	{
	}

	private void updateData()
	{
	}

	public void OnLanguageChange()
	{
	}
}
