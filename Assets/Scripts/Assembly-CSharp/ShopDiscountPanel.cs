using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ShopDiscountPanel : MediatorCtrlBase
{
	public Image img_bg;

	public Image img_block;

	public DxxImage img_shop;

	public Transform container;

	public ShopOneStageDiscount discountItem;

	public ButtonCtrl btn_close;

	private Color oldBgColor;

	private Sequence seq;

	private GameObject goBtnShop;

	public override void OnLanguageChange()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void reset()
	{
	}

	private void closeWindow()
	{
	}

	private void SetUpBtnShopPos(Transform _btnShopTrans)
	{
	}

	private Transform GetBtnShopTrans()
	{
		return null;
	}
}
