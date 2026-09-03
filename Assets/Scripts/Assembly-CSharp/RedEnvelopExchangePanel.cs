using System;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class RedEnvelopExchangePanel : ActRedEnvelopePanelBase
{
	public Image redIcon;

	public Image mat1;

	public Image mat2;

	public DxxText mat1CountTex;

	public DxxText mat2CountTex;

	public DxxText RemainTex;

	public DxxText descTex;

	public ButtonCtrl exchange1Btn;

	public ButtonCtrl exchange10Btn;

	public ButtonCtrl mat1Btn;

	public ButtonCtrl mat2Btn;

	public DxxText exchange1Tex;

	public DxxText exchange2Tex;

	[CompilerGenerated]
	private new Action<string> m_UpdateTimeDown;

	[CompilerGenerated]
	private new Action m_RefreshTokenNum;

	private int mutNum;

	private long showTimex;

	private static DelegateBridge __Hotfix0_add_UpdateTimeDown;

	private static DelegateBridge __Hotfix0_remove_UpdateTimeDown;

	private static DelegateBridge __Hotfix0_add_RefreshTokenNum;

	private static DelegateBridge __Hotfix0_remove_RefreshTokenNum;

	private static DelegateBridge __Hotfix0_get_timeDownColor;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_ReFresh;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_ClickExchange;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge __Hotfix0_UpdateTime;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

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

	private void ReFresh()
	{
	}

	public override void Close()
	{
	}

	private void ClickExchange(int num)
	{
	}

	private void freshTime()
	{
	}

	private void UpdateTime()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
