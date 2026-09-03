using PureMVC.Interfaces;
using UnityEngine;

public class AltarWishUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Sub;

	public DxxText Text_Effect;

	public DxxText Text_Count;

	public DxxText Text_Info;

	public DxxText Text_Reward1;

	public PropOneEquip[] props1;

	public DxxText Text_Reward2;

	public PropOneEquip[] props2;

	public GameObject Panel2;

	public DxxText Text_Reward3;

	public PropOneEquip[] props3;

	public GameObject Panel3;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Pray;

	public DxxText Text_Pray;

	public DxxText Text_Diamond;

	private AltarData altarData;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
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

	private void android_escape()
	{
	}

	private void init()
	{
	}

	private void onButtonBless()
	{
	}
}
