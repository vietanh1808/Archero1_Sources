using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class EquipCastUI : MonoBehaviour
{
	public DxxText Text_MatCount;

	public EquipOneCtrl targetItem;

	public EquipCastNeedItem[] needItems;

	public DxxText Text_Attr;

	public RectTransform ContentAttr;

	public GameObject cpItemAttr;

	public ButtonCtrl Button_Cast;

	public DxxText Text_Cast;

	public ButtonCtrl Button_Info;

	public DxxText Text_Info;

	public ButtonCtrl Button_Back;

	public EquipCastChoosePanel choosePanel;

	private int chooseTargetId;

	private List<LocalSave.EquipOne> chooseNeedList;

	private LocalUnityObjctPool mPool;

	private List<EquipInfoAttributeOne> attrList;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnLanguageChanged()
	{
	}

	public object OnGetEvent(string eventName)
	{
		return null;
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	private void Esc()
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

	public void onButtonTopTarget()
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
