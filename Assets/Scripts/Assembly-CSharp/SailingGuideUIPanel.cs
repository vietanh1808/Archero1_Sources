using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class SailingGuideUIPanel : MediatorCtrlBase
{
	public static Action GuideEndCallBack;

	public GameObject bgmask;

	private List<SailingGuideItemBase> items;

	private Dictionary<SailingGuideItemBase.GuideType, string> paths;

	private SailingGuideManager.GuideDataOne curData;

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
}
