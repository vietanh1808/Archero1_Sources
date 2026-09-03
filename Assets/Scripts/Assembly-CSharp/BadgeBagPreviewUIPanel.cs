using PureMVC.Interfaces;
using UnityEngine;

public class BadgeBagPreviewUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private DxxText Text_Name;

	[SerializeField]
	private DxxText Text_Desc;

	[SerializeField]
	private PropOneEquip topItem;

	[SerializeField]
	private RectTransform RT_Content;

	[SerializeField]
	private GameObject cpItem;

	[SerializeField]
	private ButtonCtrl Button_Close;

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

	private void initUI()
	{
	}

	private void Esc()
	{
	}

	public void onButtonClose()
	{
	}
}
