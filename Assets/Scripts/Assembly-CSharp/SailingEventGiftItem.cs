using GameProtocol;
using UnityEngine;

public class SailingEventGiftItem : MonoBehaviour
{
	public PropOneEquip[] propItem;

	public DxxText Text_Time;

	public ButtonCtrl Button_Buy;

	public GameObject Mask;

	public GameObject DiscountObj;

	public DxxText Text_Discount;

	public DxxText Text_DiscountDesc;

	public AdsController ads;

	public GameObject AdObj;

	public DxxText Text_Ad;

	public GameObject IAPObj;

	public DxxText Text_Price;

	public GameObject StarObj;

	public DxxText Text_Star;

	public GameObject DiamondObj;

	public DxxText Text_Diamond;

	[SerializeField]
	private GameObject _objDiamondSale;

	[SerializeField]
	private DxxText _textDiamondSale;

	[SerializeField]
	private DxxText _textDiamond;

	public RectTransform RTF_IconSale;

	private SailingGiftItemData itemData;

	private int buyType;

	public void Awake()
	{
	}

	public void init(SailingGiftItemData data)
	{
	}

	private void onButtonBuy()
	{
	}

	private void popWindowSecond_Prop()
	{
	}

	private void popWindowSecond_Star()
	{
	}

	private bool checkCanExchange_Diamond()
	{
		return false;
	}

	private void doCallbackAd()
	{
	}

	private void doIAPBuy()
	{
	}

	private void doStarBuy()
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}
}
