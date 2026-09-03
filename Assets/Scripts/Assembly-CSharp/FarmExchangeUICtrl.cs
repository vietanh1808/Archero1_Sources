using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class FarmExchangeUICtrl : MediatorCtrlBase
{
	public GameObject monsterRoot;

	public ButtonCtrl Button_close;

	public ButtonCtrl Button_Buy;

	public DxxText Text_buy;

	public DxxText Text_need;

	public Image Image_need;

	public DxxText Text_title;

	public DxxText Text_desc;

	public DxxText Text_left_title;

	public DxxText Text_left_value;

	public PropOneEquip Prop_left_one;

	public DxxText Text_right_title;

	public DxxText Text_right_value;

	public PropOneEquip Prop_right_one;

	private FarmExchangeUIData uidata;

	private FarmExchangeData data;

	private int need_num;

	private long have_num;

	protected override void OnInit()
	{
	}

	private void android_escape()
	{
	}

	private void OnBuyEnd()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private long getCount(PropType propType, int id)
	{
		return 0L;
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
