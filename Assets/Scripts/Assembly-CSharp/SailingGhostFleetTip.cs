using System;
using PureMVC.Interfaces;
using UnityEngine;

public class SailingGhostFleetTip : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private GameObject tipObj;

	[SerializeField]
	private DxxText titleName;

	[SerializeField]
	private DxxFitContentText contentText;

	[SerializeField]
	private DxxText btnName;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private ButtonCtrl btnCloseBtn;

	[SerializeField]
	private DxxText btnCloseName;

	private Action clickBtnAction;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void ShowTip(bool isActive, Action clickBtnAction)
	{
	}

	private void ClickCloseBtn()
	{
	}

	private void ClickBtn()
	{
	}
}
