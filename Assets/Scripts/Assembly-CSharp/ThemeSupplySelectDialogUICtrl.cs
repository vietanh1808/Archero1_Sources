using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ThemeSupplySelectDialogUICtrl : MediatorCtrlBase
{
	public class TransferData
	{
		public string sourceName;

		public string entranceName;

		public Action callback;
	}

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public DxxText Text_Title;

	public DxxText Text_Title2;

	public ButtonCtrl Button_Confirm;

	public DxxText Text_Confirm;

	public ThemeSupplySelectItem Copy_Item;

	public ScrollRectBase ScrollView;

	public RectTransform ContentTrans;

	public GridLayoutGroup GridGroup;

	private LocalUnityObjctPool mPool;

	private List<ThemeSupplySelectItem> ItemList;

	private RewardSelectionData selectionData;

	private string sourceToken;

	private Drop_DropModel.DropData resultItem;

	private int curSelectedId;

	private bool isOpen;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnSelectItem(Drop_DropModel.DropData dropData)
	{
	}

	private void OnConfirm()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}
}
