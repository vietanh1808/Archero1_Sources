using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class EquipCastEndUIPanel : MediatorCtrlBase
{
	public class ShowData
	{
		public LocalSave.EquipOne target;

		public List<LocalSave.EquipOne> needs;

		public List<Drop_DropModel.DropData> rewards;
	}

	public GameObject TopObj;

	public DxxText Text_Title;

	public EquipOneCtrl targetItem;

	public EquipOneCtrl[] needItems;

	public DxxText Text_Name;

	public DxxText Text_Quality;

	public DxxText Text_OK;

	public ButtonCtrl Button_OK;

	public GameObject Middle;

	public RectTransform ContentAttr;

	public GameObject cpItemAttr;

	public DxxText Text_AttrTitle;

	private ShowData showData;

	private LocalUnityObjctPool mPool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void Esc()
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

	private void onButtonOK()
	{
	}

	private void initUI()
	{
	}

	private void freshAttrList()
	{
	}

	private void startAni()
	{
	}
}
