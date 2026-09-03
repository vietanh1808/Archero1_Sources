using PureMVC.Interfaces;
using UnityEngine;

public class BadgeBagUpUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private DxxText Text_Time;

	[SerializeField]
	private DxxText Text_Desc;

	[SerializeField]
	private RectTransform RT_Content;

	[SerializeField]
	private GameObject cpItem;

	[SerializeField]
	private ButtonCtrl Button_Close;

	private int upId;

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

	private void initUI()
	{
	}

	public void onButtonClose()
	{
	}

	private void Esc()
	{
	}
}
