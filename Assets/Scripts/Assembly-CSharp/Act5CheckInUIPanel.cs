using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class Act5CheckInUIPanel : MediatorCtrlBase
{
	public DxxText titleTex;

	public ButtonCtrl closeBtn;

	public Button bgBtn;

	public Act5CheckInItem copyObj;

	public RectTransform itemParent;

	public RectTransform view;

	private List<Act5CheckInItem> items;

	private Act5CheckInData m_Data;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void Esc()
	{
	}

	public void RefreshList()
	{
	}

	private void JumpTo()
	{
	}

	public Act5CheckInItemData GetData(uint type, uint taskId)
	{
		return null;
	}

	public void RefreshTask()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
