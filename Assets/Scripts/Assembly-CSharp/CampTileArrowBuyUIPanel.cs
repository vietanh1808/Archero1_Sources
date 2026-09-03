using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileArrowBuyUIPanel : MonoBehaviour
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private DxxText arrowName;

	[SerializeField]
	private DxxText arrowCanBuyCount;

	[SerializeField]
	private DxxText arrowPriceOne;

	[SerializeField]
	private DxxText arrowPriceMore;

	[SerializeField]
	private DxxText arrowBuyOne;

	[SerializeField]
	private DxxText arrowBuyMore;

	[SerializeField]
	private ButtonCtrl buyOneBtn;

	[SerializeField]
	private ButtonCtrl buyMoreBtn;

	[SerializeField]
	private ButtonCtrl info;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private Slider buySlider;

	[SerializeField]
	private ButtonCtrl sliderReduceBtn;

	[SerializeField]
	private ButtonCtrl sliderReduceTenBtn;

	[SerializeField]
	private ButtonCtrl sliderAddBtn;

	[SerializeField]
	private ButtonCtrl sliderAddTenBtn;

	[SerializeField]
	private ButtonCtrl arrowBuyBtn;

	[SerializeField]
	private DxxText arrowPrice;

	[SerializeField]
	private DxxText arrowCount;

	[SerializeField]
	private DxxText arrowDesc;

	public GameObject NameObj;

	public GameObject LevelObj;

	private long CurLeftTime;

	private CampTileArrowType type;

	private int _buyCount;

	private int _min;

	private int _max;

	private static DelegateBridge __Hotfix0_get_CampTileManager;

	private static DelegateBridge __Hotfix0_get_CurCurrencyType;

	private static DelegateBridge __Hotfix0_get_ScrambleStatus;

	private static DelegateBridge __Hotfix0_get_BuyOnePrice;

	private static DelegateBridge __Hotfix0_get_BuyMaxCount;

	private static DelegateBridge __Hotfix0_get_CurLeftBuyCount;

	private static DelegateBridge __Hotfix0_get_HaveBuyCount;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_BuyArrow;

	private static DelegateBridge __Hotfix0_InfoClick;

	private static DelegateBridge __Hotfix0_CheckSameDay;

	private static DelegateBridge __Hotfix0_OneDisable;

	private static DelegateBridge __Hotfix0_MoreDisable;

	private static DelegateBridge __Hotfix0_RefreshSlider;

	private static DelegateBridge __Hotfix0_RefreshSliderTxt;

	private static DelegateBridge __Hotfix0_OnSliderValueChanged;

	private static DelegateBridge __Hotfix0_onButtonAdd;

	private static DelegateBridge __Hotfix0_onButtonAddTen;

	private static DelegateBridge __Hotfix0_onButtonReduce;

	private static DelegateBridge __Hotfix0_onButtonReduceTen;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTileManager CampTileManager => null;

	private CurrencyType CurCurrencyType => CurrencyType.None;

	private CampKingScrambleStatus ScrambleStatus => CampKingScrambleStatus.None;

	private float BuyOnePrice => 0f;

	private float BuyMaxCount => 0f;

	private float CurLeftBuyCount => 0f;

	private int HaveBuyCount => 0;

	public void Init()
	{
	}

	public void Open(CampTileArrowType type)
	{
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshItem()
	{
	}

	public void RefreshText()
	{
	}

	public void BuyArrow(int count)
	{
	}

	public void InfoClick()
	{
	}

	public bool CheckSameDay()
	{
		return false;
	}

	public void OneDisable()
	{
	}

	public void MoreDisable()
	{
	}

	private void RefreshSlider()
	{
	}

	private void RefreshSliderTxt()
	{
	}

	public void OnSliderValueChanged()
	{
	}

	private void onButtonAdd()
	{
	}

	private void onButtonAddTen()
	{
	}

	private void onButtonReduce()
	{
	}

	private void onButtonReduceTen()
	{
	}
}
