using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class CampTownSkinEffectUIPanel : MediatorCtrlBase
{
	public class ShowData
	{
		public List<TownSkinEffectData> effectList;
	}

	public RectTransform Content;

	public DxxText Title;

	public ButtonCtrl BtnClose;

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
}
