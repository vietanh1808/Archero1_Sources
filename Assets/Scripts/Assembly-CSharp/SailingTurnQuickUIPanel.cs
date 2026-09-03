using PureMVC.Interfaces;
using UnityEngine.UI;

public class SailingTurnQuickUIPanel : MediatorCtrlBase
{
	public class QuickData
	{
		public int equipid;

		public int type;
	}

	public DxxText Text_Title;

	public DxxText Text_Desc;

	public ButtonCtrl Button_Close;

	public PropOneEquip propItem;

	public DxxText Text_SubTitle;

	public Slider slider;

	public ButtonCtrl Button_Add;

	public ButtonCtrl Button_Reduce;

	public DxxText Text_Count;

	public ButtonCtrl Button_Buy;

	public DxxText Text_Use;

	public DxxText Text_Tips;

	private int chooseCount;

	private int min;

	private int max;

	private int MaxCond;

	private int MaxHave;

	private QuickData quickData;

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
