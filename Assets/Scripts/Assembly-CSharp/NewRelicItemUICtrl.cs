using PureMVC.Interfaces;
using UnityEngine;

public class NewRelicItemUICtrl : MediatorCtrlBase
{
	public EquipOneCtrl equipOneCtrl;

	public DxxText Text_Tip;

	public DxxText Text_title;

	public DxxText Text_name;

	public DxxText Text_desc;

	public DxxText Text_go;

	public DxxImage Image_icon;

	public GameObject goEffect;

	public ButtonCtrl Button_go;

	public ButtonCtrl Button_next;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	private void onClickGo()
	{
	}
}
