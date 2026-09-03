using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class CampGuideUIPanel : MediatorCtrlBase
{
	public static Action GuideEndCallBack;

	public GameObject bgmask;

	private List<CampGuideItemBase> items;

	private Dictionary<CampGuideItemBase.CampGuideType, string> paths;

	private CampGuideManager.CampGuideData curData;

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
