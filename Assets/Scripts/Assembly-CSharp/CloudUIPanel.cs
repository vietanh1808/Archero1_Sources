using System;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class CloudUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private FitContentText tips;

	[SerializeField]
	private RectTransform leftCloud;

	[SerializeField]
	private RectTransform rightCloud;

	private const float CloudMoveTime = 0.6f;

	private CloudData cloudData;

	private float leftCloudWidth;

	private float rightCloudWidth;

	private SequencePool pool;

	private bool isOpen;

	private bool needClose;

	private Action openEventAfterNotify;

	private int originSort;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshSort()
	{
	}

	private void CloseCloud()
	{
	}

	private void OpenCloud()
	{
	}
}
