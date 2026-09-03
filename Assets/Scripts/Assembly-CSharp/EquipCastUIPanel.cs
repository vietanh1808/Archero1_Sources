using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class EquipCastUIPanel : MediatorCtrlBase
{
	public DxxText Text_MatCount;

	public EquipOneCtrl targetItem;

	public NewFlagItem equipCastNewItem;

	public EquipCastNeedItem[] needItems;

	public DxxText Text_Attr;

	public RectTransform ContentAttr;

	public GameObject cpItemAttr;

	public ButtonCtrl Button_Cast;

	public DxxText Text_Cast;

	public ButtonCtrl Button_Info;

	public DxxText Text_Info;

	public ButtonCtrl Button_Back;

	public ButtonCtrl Button_TopInfo;

	public EquipCastChoosePanel choosePanel;

	private int chooseTargetId;

	private List<LocalSave.EquipOne> chooseNeedList;

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

	private void onButtonCast()
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonBack()
	{
	}

	private void onButtonTopInfo()
	{
	}

	private void initUI()
	{
	}

	private void freshMatItem()
	{
	}

	private void freshTargetItem()
	{
	}

	private void freshNewItem()
	{
	}

	private void freshNeedItems()
	{
	}

	private void freshAttrList()
	{
	}

	public void onButtonChoosePanelTop()
	{
	}

	public void onButtonChoosePanelBottom(int index)
	{
	}

	public void onButtonCloseChoosePanel()
	{
	}

	private void resetNeedList()
	{
	}

	public void chooseTopItem(int equipid)
	{
	}

	public void chooseNeedItems(int index, LocalSave.EquipOne e)
	{
	}
}
