using PureMVC.Interfaces;
using UnityEngine.UI;

public class BadgeBagOpenUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public PropOneEquip propItem;

	public DxxText Text_Num;

	public DxxText Text_Desc;

	public Slider slider;

	public DxxText Text_SubTitle;

	public ButtonCtrl Button_Add;

	public ButtonCtrl Button_Reduce;

	public DxxText Text_Count;

	public ButtonCtrl Button_Use;

	public DxxText Text_Use;

	private int chooseCount;

	private int min;

	private int max;

	private int MaxCond;

	private int MaxHave;

	private int bagId;

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

	public void onButtonClose()
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
