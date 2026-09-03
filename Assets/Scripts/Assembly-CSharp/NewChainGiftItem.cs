using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class NewChainGiftItem : MonoBehaviour
{
	public GameObject itemCopy;

	public GameObject freeObj;

	public GameObject diamandObj;

	public GameObject adObj;

	public GameObject hasGet;

	public GameObject maskObj;

	public GameObject lockObj;

	public RectTransform itemParent;

	public ContentSizeFitter csf;

	public ButtonCtrl getBtn;

	public VIPFlagItem vipFlag;

	public Image costIcon;

	public Image BgImg;

	public Image BtnImg;

	public DxxText freeTex;

	public DxxText costTex;

	public DxxText adTex;

	public ScrollRect scrollRect;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private NewChainGiftMgr.NewChainGiftItemData mData;

	protected AdCallbackControl mAd;

	public void Init(NewChainGiftMgr.NewChainGiftItemData data)
	{
	}

	private void RefreshReward()
	{
	}

	private void RefreshVIP()
	{
	}

	private void RefreshButton()
	{
	}

	private void RefreshState()
	{
	}

	public float GetHigh()
	{
		return 0f;
	}

	private void ClickPay()
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}

	private void ClickFree()
	{
	}

	private void ClickAd()
	{
	}

	public void OnADEndWrapper()
	{
	}

	private void ClickDiamond()
	{
	}

	private void OnButtonStarBuy()
	{
	}

	private bool CheckBuy()
	{
		return false;
	}
}
