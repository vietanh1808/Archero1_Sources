using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class RedEnvelopeShopPanel : ActRedEnvelopePanelBase
{
	[CompilerGenerated]
	private new Action<string> m_UpdateTimeDown;

	[CompilerGenerated]
	private new Action m_RefreshTokenNum;

	public RedEnvelopeShopItem itemObj;

	public Transform itemParent;

	public ScrollRect scroll;

	public RedShopTab[] tabs;

	private List<RedEnvelopeShopItem> items;

	private long showTimex;

	private static DelegateBridge __Hotfix0_add_UpdateTimeDown;

	private static DelegateBridge __Hotfix0_remove_UpdateTimeDown;

	private static DelegateBridge __Hotfix0_add_RefreshTokenNum;

	private static DelegateBridge __Hotfix0_remove_RefreshTokenNum;

	private static DelegateBridge __Hotfix0_get_timeDownColor;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_ShowShop;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge __Hotfix0_UpdateTime;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge _c__Hotfix0_ctor;

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

	public void ShowShop(int tab)
	{
	}

	public override void Close()
	{
	}

	private void Refresh()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void freshTime()
	{
	}

	private void UpdateTime()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
