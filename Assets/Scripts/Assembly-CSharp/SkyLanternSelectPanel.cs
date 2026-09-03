using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SkyLanternSelectPanel : MonoBehaviour
{
	public DxxText titleText;

	public DxxText nameText;

	public DxxText descTest;

	public DxxText btnText;

	public ButtonCtrl bgBtn;

	public ButtonCtrl closeBtn;

	public ButtonCtrl okBtn;

	public PropOneEquip selectEquipOne;

	public PropOneEquip copyOne;

	public RectTransform itemParent;

	public RectTransform selectTrans;

	private List<PropOneEquip> items;

	private SkyLanternRewardData mData;

	private Drop_DropModel.DropData curDrop;

	private int selectIndex;

	public void Init()
	{
	}

	private void ClickOk()
	{
	}

	public void Open(SkyLanternRewardData data)
	{
	}

	private void RefreshTop()
	{
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}
}
