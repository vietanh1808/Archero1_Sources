using UnityEngine;
using UnityEngine.UI;

public class TradingHouseSellPanel : MonoBehaviour
{
	public DxxText titleTex;

	public DxxText nameText;

	public DxxText lastText;

	public DxxText priceText;

	public DxxText countText;

	public DxxText allBtnTex;

	public DxxText cancleBtnTex;

	public DxxText okBtnTex;

	public DxxText lastSellText;

	public DxxText oriPriceText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgBtn;

	public ButtonCtrl allBtn;

	public ButtonCtrl halfBtn;

	public ButtonCtrl oneThirdBtn;

	public ButtonCtrl oneQuarterBtn;

	public ButtonCtrl cancleBtn;

	public ButtonCtrl okBtn;

	public PropOneEquip propOne;

	public Button reduceBtn;

	public Button addBtn;

	public DxxText costText;

	public DxxText costNumText;

	private TradingHouseCommodity mCommondity;

	private TradingHouseBehavior mBehavior;

	private int count;

	private int maxCount;

	private int mCurTradingNode;

	private string red;

	private string green;

	private string plus;

	private string reduce;

	public void Init()
	{
	}

	public void Open(TradingHouseCommodity commodity, TradingHouseBehavior behavior)
	{
	}

	private void Refresh()
	{
	}

	private void RefreshSold()
	{
	}

	private void RefreshBuy()
	{
	}

	private void RefreshCountUI()
	{
	}

	public void Close()
	{
	}

	private void ClickReduce()
	{
	}

	private void ClickAdd()
	{
	}

	private void ClickAll()
	{
	}

	private void ClickHalf()
	{
	}

	private void ClickOneThird()
	{
	}

	private void ClickOneQuarter()
	{
	}

	private void ClickOK()
	{
	}

	private bool CheckMaxCount()
	{
		return false;
	}

	private void OnLanguageChange()
	{
	}
}
