using System.Collections.Generic;
using UnityEngine;

public class NewChainGiftUIPanel : MediatorCtrlBase
{
	public int existCount;

	public float pidding;

	public float cellHigh;

	public float top;

	public DxxText titleTex;

	public DxxText timeDownTex;

	public RectTransform itemParent;

	public RectTransform view;

	public NewChainGiftItem copyObj;

	public ButtonCtrl closeBtn;

	public StarDiamondItem starDiamond;

	private NewChainGiftItem[] items;

	private List<NewChainGiftMgr.NewChainGiftItemData> datas;

	private int firstIndex;

	private long showTimex;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public void InitList()
	{
	}

	public void OnValueChange(Vector2 pos)
	{
	}

	public void RefreshList()
	{
	}

	private void freshTime()
	{
	}

	private void UpdateTime()
	{
	}

	public void ClosePanel()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
