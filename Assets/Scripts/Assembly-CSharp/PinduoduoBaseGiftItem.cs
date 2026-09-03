using UnityEngine;
using UnityEngine.UI;

public class PinduoduoBaseGiftItem : MonoBehaviour
{
	public InfiniteListView listView;

	public DxxText titleText;

	public DxxText timeText;

	public DxxText hasBuyText;

	public DxxText priceText;

	public ButtonCtrl buyBtn;

	public Image priceIconImg;

	protected PinduoduoBaseGiftData mData;

	protected bool isReq;

	public void Init()
	{
	}

	protected virtual void OnInit()
	{
	}

	public void Open(PinduoduoBaseGiftData data)
	{
	}

	private void OnReqQuickBuyCallBack(bool obj)
	{
	}

	public void Refresh()
	{
	}

	protected virtual void OnRefresh()
	{
	}

	public void Close()
	{
	}

	public virtual void OnLanguageChange()
	{
	}

	protected virtual void ClickBuy()
	{
	}

	protected virtual void freshTime()
	{
	}
}
