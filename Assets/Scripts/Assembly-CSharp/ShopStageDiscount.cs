using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

public class ShopStageDiscount : ShopOneBase
{
	private enum TabType
	{
		Normal = 0,
		Hero = 1,
		Hell = 2
	}

	[CompilerGenerated]
	private sealed class _003CsetTabFirst_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopStageDiscount _003C_003E4__this;

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
		public _003CsetTabFirst_003Ed__33(int _003C_003E1__state)
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

	private LocalUnityObjctPool mPool;

	public GameObject content;

	public ScrollRectBase mScrollRect;

	public ButtonCtrl left_Button;

	public ButtonCtrl right_Button;

	public ButtonCtrl btnTabNormal;

	public ButtonCtrl btnTabHero;

	public ButtonCtrl btnTabHell;

	public ButtonCtrl btnPop;

	public DxxImage icon_Hero;

	[SerializeField]
	private GameObject goTabs;

	[SerializeField]
	private GameObject goMaskTabNormal;

	[SerializeField]
	private GameObject goMaskTabHero;

	[SerializeField]
	private GameObject goMaskTabHell;

	[SerializeField]
	private DxxText txtNormal;

	[SerializeField]
	private DxxText txtHero;

	[SerializeField]
	private DxxText txtHell;

	[SerializeField]
	private DxxText txtTitle;

	private TabType selectedTabType;

	private int itemcount;

	private GridLayoutGroup grid;

	private RectTransform rcontent;

	[SerializeField]
	private ShopOneStageDiscountCard copyOne;

	private List<ShopOneStageDiscountCard> mDiscountCardList;

	private bool hasTab;

	private int m_nCurShowIndex;

	private bool isDragging;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshTabText;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_OnAwake;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_setTabFirst;

	private static DelegateBridge __Hotfix0_SetTab;

	private static DelegateBridge __Hotfix0_RefreshList;

	private static DelegateBridge __Hotfix0_OnValueChanged;

	private static DelegateBridge __Hotfix0_UpdateCardShow;

	private static DelegateBridge __Hotfix0_EndDrag;

	private static DelegateBridge __Hotfix0_UpdateButton;

	private static DelegateBridge __Hotfix0_InitShopOneStageDiscount;

	private static DelegateBridge __Hotfix0_GetStageCount;

	private static DelegateBridge __Hotfix0_CheckBusy;

	private static DelegateBridge __Hotfix0_OnDrag;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge _c__Hotfix0_ctor;

	public override void OnLanguageChange()
	{
	}

	public void RefreshTabText()
	{
	}

	public override void UpdateNet()
	{
	}

	protected override void OnAwake()
	{
	}

	protected override void OnDeinit()
	{
	}

	protected override void OnInit()
	{
	}

	[IteratorStateMachine(typeof(_003CsetTabFirst_003Ed__33))]
	private IEnumerator setTabFirst()
	{
		return null;
	}

	private void SetTab(TabType tabType)
	{
	}

	private void RefreshList()
	{
	}

	private void OnValueChanged(Vector2 v)
	{
	}

	private void UpdateCardShow()
	{
	}

	private void EndDrag()
	{
	}

	private void UpdateButton()
	{
	}

	private void InitShopOneStageDiscount()
	{
	}

	private int GetStageCount(Current_purchaseItem item)
	{
		return 0;
	}

	private bool CheckBusy()
	{
		return false;
	}

	private void OnDrag(PointerEventData eventData)
	{
	}

	public override void UpdateUI()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnAwake()
	{
	}

	private void _003C_003ExLuaBaseProxy_UpdateUI()
	{
	}
}
