using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;

public class RedEnvelopGiftPanel : ActRedEnvelopePanelBase
{
	public RedEnvelopGiftItem CopyObj;

	public Transform itemParent;

	public StarDiamondItem sItem;

	[CompilerGenerated]
	private new Action<string> m_UpdateTimeDown;

	[CompilerGenerated]
	private new Action m_RefreshTokenNum;

	private List<RedEnvelopGiftItem> items;

	private long showTimex;

	public override Color timeDownColor => default;

	public override event Action<string> UpdateTimeDown
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override event Action RefreshTokenNum
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override void Init()
	{
	}

	public override void Open()
	{
	}

	public void StarBuyCallBack()
	{
	}

	public override void Close()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void freshTime()
	{
	}

	private void UpdateTime()
	{
	}
}
