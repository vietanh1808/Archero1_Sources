using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class GiftBoxUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CscrollToIndex_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GiftBoxUICtrl _003C_003E4__this;

		public int total;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CscrollToIndex_003Ed__36(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public DxxText Text_Title;

	public DxxText Text_SubTitle;

	public DxxText Text_Time;

	public Image roleImage;

	public Image kvImage;

	public ScrollRect scrollRect;

	public RectTransform viewRect;

	public RectTransform container;

	public GameObject tempItem;

	public ButtonCtrl Button_Buy;

	public DxxText Text_ButtonBuy;

	public ButtonCtrl Button_Close;

	public DxxText Text_HaveBuy;

	public Dictionary<int, GiftBoxItemCtrl> items;

	public GameObject PanelTab;

	public GameObject[] GiftBG;

	public Button[] Button_Tab;

	public GameObject[] Focus_Tab;

	public DxxText[] Text_Tab;

	public GameObject[] Red_Tab;

	[SerializeField]
	private GameObject[] selectImg;

	public StarDiamondItem starDiamond;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	public RectTransform buttonsParent;

	public ContentSizeFitter contentSizeFitter;

	private int currentTab;

	private int sindex;

	private static DelegateBridge __Hotfix0_get_OpenTab;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_scrollToIndex;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_RefeshRed;

	private static DelegateBridge __Hotfix0_OnButtonBuy;

	private static DelegateBridge __Hotfix0_onButtonStarBuy;

	private static DelegateBridge __Hotfix0_PurchaseSuccess;

	private static DelegateBridge __Hotfix0_onButtonTab;

	private static DelegateBridge __Hotfix0_GetTheme;

	private static DelegateBridge _c__Hotfix0_ctor;

	private int OpenTab => 0;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	private void init(int tab)
	{
	}

	[IteratorStateMachine(typeof(_003CscrollToIndex_003Ed__36))]
	private IEnumerator scrollToIndex(int total)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void RefeshRed()
	{
	}

	public void OnButtonBuy()
	{
	}

	private void onButtonStarBuy()
	{
	}

	private void PurchaseSuccess(GiftBoxManager.GiftBoxData boxData, CRespInAppPurchase data)
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private string GetTheme(int id)
	{
		return null;
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
