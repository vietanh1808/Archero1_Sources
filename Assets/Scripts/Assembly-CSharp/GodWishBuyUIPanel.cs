using PureMVC.Interfaces;
using UnityEngine.UI;

public class GodWishBuyUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Top;

	public DxxText Text_Desc;

	public ButtonCtrl Button_Close;

	public PropOneEquip propItem;

	public ButtonCtrl Button_Buy;

	public DxxText Text_Diamond;

	public Slider slider;

	public ButtonCtrl Button_Add;

	public ButtonCtrl Button_Reduce;

	public DxxText Text_Count;

	private GodWishActData quickData;

	private int chooseCount;

	private int min;

	private int max;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
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
