using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class PiggyBankActUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiggyBankActUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__64(int _003C_003E1__state)
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
	private DxxText txt_Title;

	[SerializeField]
	private DxxText txt_desc;

	[SerializeField]
	private DxxText txt_Disocunt;

	[SerializeField]
	private DxxText txt_CountDown;

	[SerializeField]
	private DxxText txt_MinDiamond;

	[SerializeField]
	private DxxText txt_MaxDiamond;

	[SerializeField]
	private DxxText txt_NowDimaond;

	[SerializeField]
	private DxxText txt_Completed;

	[SerializeField]
	private DxxText txt_Tips;

	[SerializeField]
	private DxxText txt_BoxCountDown;

	[SerializeField]
	private ButtonCtrl btn_Rewards;

	[SerializeField]
	private ButtonCtrl btn_Buy;

	[SerializeField]
	private DxxText txt_Price;

	[SerializeField]
	private ButtonCtrl btn_StarDiamond;

	[SerializeField]
	private DxxText txt_starDiamond;

	[SerializeField]
	private ButtonCtrl btn_Left;

	[SerializeField]
	private ButtonCtrl btn_Right;

	[SerializeField]
	private ButtonCtrl btn_BottomLeft;

	[SerializeField]
	private ButtonCtrl btn_BottomRight;

	[SerializeField]
	private DxxImage img_Piggy;

	[SerializeField]
	private DxxImage img_centerBg;

	[SerializeField]
	private DxxImage img_DescBg;

	[SerializeField]
	private DxxImage img_TitleBg;

	[SerializeField]
	private DxxImage img_Bg;

	[SerializeField]
	private DxxImage img_ArrowLeft;

	[SerializeField]
	private DxxImage img_ArrowRight;

	[SerializeField]
	private GameObject go_BottomPart;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private RedNodeCtrl redNodeCtrl;

	[SerializeField]
	private GameObject tabItem;

	[SerializeField]
	private RectTransform tabParent;

	[SerializeField]
	private Image img_FreeReward;

	[SerializeField]
	private Animation ani_FreeReward;

	[SerializeField]
	private ButtonCtrl btn_Close;

	[SerializeField]
	private StarDiamondItem starDiamondItem;

	[SerializeField]
	private SkeletonGraphic ani_Buy;

	[SerializeField]
	private GameObject go_Mask;

	private PiggyBankItemData crtData;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private int crtIndex;

	private List<PiggyBankTab> tabList;

	private PiggyBankActManager pbMgr => null;

	private PiggyBankActData pData => null;

	private int MaxCount => 0;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshUI()
	{
	}

	private void CreateBottomTab()
	{
	}

	public void OnBtnTabClick(int index)
	{
	}

	private void OnBtnArrowClick(int value)
	{
	}

	private void RefreshStyle()
	{
	}

	private void RefreshSlider()
	{
	}

	private void RefreshFreeReward()
	{
	}

	private void OnBtnRewardClick()
	{
	}

	private void OnButtonStarClick()
	{
	}

	private bool CheckBuy()
	{
		return false;
	}

	private void OnBtnBuyClick()
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__64))]
	private IEnumerator CountDown()
	{
		return null;
	}

	public void Esc()
	{
	}

	protected override void OnClose()
	{
	}

	public void PlaySpineSound()
	{
	}
}
