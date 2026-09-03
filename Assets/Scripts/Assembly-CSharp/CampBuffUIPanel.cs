using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class CampBuffUIPanel : MediatorCtrlBase
{
	public class ShowData
	{
		public bool preview;

		public CampID campID;

		public CampTileBattleStatus status;

		public List<CampBuffItemData> buffList;
	}

	public RectTransform Content;

	public DxxText Title;

	public DxxText Text_Status;

	public ButtonCtrl BtnClose;

	public ButtonCtrl Button_Info;

	public DxxText Text_Desc;

	public GameObject cpItem;

	public ShowData showData;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void initUI()
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

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonInfo()
	{
	}
}
