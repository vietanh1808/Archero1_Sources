using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTimingGiftItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CampTimingGiftItem _003C_003E4__this;

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
		public _003CCountDown_003Ed__39(int _003C_003E1__state)
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

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText discount;

	[SerializeField]
	private DxxText discountName;

	[SerializeField]
	private DxxText btnName;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private CampTimingGiftRewardItem rewardItem;

	[SerializeField]
	private CampTimingGiftAddItem addItem;

	[SerializeField]
	private Image titleBg;

	[SerializeField]
	private Image titleSubBg;

	[SerializeField]
	private Image itemBg;

	[SerializeField]
	private Image itemLight;

	[SerializeField]
	private VIPFlagItem vipItem;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private CampTimingGiftThemeType themeType;

	private CampTimingGiftItemData giftItemData;

	private LocalUnityObjctPool pool;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private bool isInit;

	private long oldGoldCount;

	private long oldDiamondCount;

	private Color yellowColor;

	private Color purpleColor;

	private Color greenColor;

	private static DelegateBridge __Hotfix0_get_CampGiftManager;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_RefreshContent;

	private static DelegateBridge __Hotfix0_RefreshTheme;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_PurchaseReward;

	private static DelegateBridge __Hotfix0_PurchaseSuccess;

	private static DelegateBridge __Hotfix0_onButtonStar;

	private static DelegateBridge __Hotfix0_CheckBuy;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampGiftManager CampGiftManager => null;

	public void Refresh(CampTimingGiftItemData giftItemData, CampTimingGiftThemeType themeType)
	{
	}

	public void OnClose()
	{
	}

	public void Init()
	{
	}

	public void RefreshContent()
	{
	}

	public void RefreshTheme()
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshItem()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshCountDown()
	{
	}

	public void RefreshTime()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__39))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void Click()
	{
	}

	private void PurchaseReward()
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}

	private void onButtonStar()
	{
	}

	private bool CheckBuy()
	{
		return false;
	}
}
