using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ActivityShipNormalOneCtrl : MonoBehaviour
{
	public Transform child;

	public DxxImage Image_BG;

	private PropOneEquip mEquip;

	public Image BG;

	public Transform crit;

	public DxxText Text_Crit;

	public DxxText Text_Value;

	public ButtonCtrl Button_buy;

	public DxxText Text_Buy;

	public DxxText Text_ADBuy;

	public DxxText Text_HasBuy;

	public DxxText Text_BPFree;

	public Transform notfreeparent1;

	public Transform notfreeparent2;

	public GoldTextCtrl buyText;

	public GoldTextCtrl priceText;

	public GoldTextCtrl disText;

	public GameObject buttonMask;

	public GameObject itemMask;

	public DxxText limitTex;

	private CActivityShipNormalItem mData;

	protected Vector2 buyVec1;

	protected Vector2 buyVec2;

	protected Vector2 adVec;

	protected AdCallbackControl mAd;

	private Drop_DropModel.DropData dropData;

	private static DelegateBridge __Hotfix0_get_sourceName;

	private static DelegateBridge __Hotfix0_showPopWindow2;

	private static DelegateBridge __Hotfix0_OnClickBuy;

	private static DelegateBridge __Hotfix0_onButtonAd;

	private static DelegateBridge __Hotfix0_OnADEndWrapper;

	private static DelegateBridge __Hotfix0_OnADEnd;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_updateData;

	private static DelegateBridge __Hotfix0_InitEquip;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge _c__Hotfix0_ctor;

	private string sourceName => null;

	private void showPopWindow2()
	{
	}

	protected virtual void OnClickBuy()
	{
	}

	private void onButtonAd()
	{
	}

	private void OnADEndWrapper(bool isAd = true)
	{
	}

	private void OnADEnd(bool isAd)
	{
	}

	public void Init(CActivityShipNormalItem data)
	{
	}

	public virtual void updateData()
	{
	}

	public void InitEquip(Drop_DropModel.DropData data, bool normal = false)
	{
	}

	public virtual void OnLanguageChange()
	{
	}
}
