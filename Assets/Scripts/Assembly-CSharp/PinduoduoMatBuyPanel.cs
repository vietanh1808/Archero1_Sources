using UnityEngine;
using UnityEngine.UI;

public class PinduoduoMatBuyPanel : MonoBehaviour
{
	public DxxText Text_Title;

	public DxxText Text_Top;

	public DxxText Text_Desc;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_bg;

	public PropOneEquip propItem;

	public ButtonCtrl Button_Buy;

	public DxxText Text_Diamond;

	public Slider slider;

	public ButtonCtrl Button_Add;

	public ButtonCtrl Button_Reduce;

	[SerializeField]
	private OfficialStoreBannerCtrl _goOfficialStoreBanner;

	public StarDiamondItem starDiamond;

	private PinduoduoCommonQuickBuyItemData quickData;

	private int chooseCount;

	private int min;

	private int max;

	private bool needDiamondEnough;

	public void Init()
	{
	}

	public void Open(PinduoduoCommonQuickBuyItemData data)
	{
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonBuy()
	{
	}

	private void onButtonAdd()
	{
	}

	private void onButtonReduce()
	{
	}

	private void initUI()
	{
	}

	private void freshUI()
	{
	}

	public void onSliderValueChanged()
	{
	}
}
