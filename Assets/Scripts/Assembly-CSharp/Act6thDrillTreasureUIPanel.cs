using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class Act6thDrillTreasureUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass98_0
	{
		public Act6thDrillTreasureUIPanel _003C_003E4__this;

		public bool reqSuccess;

		public Action _003C_003E9__0;

		internal void _003CStartAutoPlay_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Act6thDrillTreasureUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__80(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CStartAutoPlay_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Act6thDrillTreasureUIPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass98_0 _003C_003E8__1;

		private int _003Cindex_003E5__2;

		private int _003CopenCount_003E5__3;

		private int[] _003CrIndex_003E5__4;

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
		public _003CStartAutoPlay_003Ed__98(int _003C_003E1__state)
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
	private DxxText text_Title;

	[SerializeField]
	private DxxText text_Time;

	[SerializeField]
	private DxxText text_playTitle;

	[SerializeField]
	private DxxText text_Gift;

	[SerializeField]
	private DxxText text_Shop;

	[SerializeField]
	private DxxText text_Task;

	[SerializeField]
	private DxxText text_PropCount;

	[SerializeField]
	private DxxText text_Play;

	[SerializeField]
	private DxxText text_heightCount;

	[SerializeField]
	private DxxText text_AddHeight;

	[SerializeField]
	private DxxText text_AddHeightNatural;

	[SerializeField]
	private DxxText text_ShopPropA;

	[SerializeField]
	private DxxText text_ShopPropB;

	[SerializeField]
	private ButtonCtrl btn_Close;

	[SerializeField]
	private ButtonCtrl btn_Play;

	[SerializeField]
	private ButtonCtrl btn_Gift;

	[SerializeField]
	private ButtonCtrl btn_Task;

	[SerializeField]
	private ButtonCtrl btn_Shop;

	[SerializeField]
	private ButtonCtrl btn_Info;

	[SerializeField]
	private ButtonCtrl btn_QuickBuy;

	[SerializeField]
	private Act6thDrillTreasureCardItem[] cards;

	[SerializeField]
	private Act6thDrillTreasureDeepBox heightBox;

	[SerializeField]
	private GameObject allMask;

	[SerializeField]
	private RectTransform rect_Road;

	[SerializeField]
	private DxxImage img_BehindRoad1;

	[SerializeField]
	private DxxImage img_BehindRoad2;

	[SerializeField]
	private RedNodeCtrl redNode_Gift;

	[SerializeField]
	private RedNodeCtrl redNode_Task;

	[SerializeField]
	private RedNodeCtrl redNode_Achievement;

	[SerializeField]
	private RedNodeCtrl redNode_Shop;

	[SerializeField]
	private Image image_Prop;

	[SerializeField]
	private Image img_ShopPropA;

	[SerializeField]
	private Image img_ShopPropB;

	[SerializeField]
	private UGUISpriteAnimation imgBoat;

	[SerializeField]
	private UGUISpriteAnimation imgCave;

	[SerializeField]
	private GameObject go_EffectSlow;

	[SerializeField]
	private GameObject go_EffectQuick;

	[SerializeField]
	private GameObject go_EffectQuick2;

	[SerializeField]
	private Image image_BtnPlay;

	public GameObject Cloud;

	public DxxText Text_Searching;

	public RectTransform CloudLeft;

	public RectTransform CloudRight;

	public GameObject PopRewardWindow;

	public RectTransform PopContainer;

	public GameObject cpPopItem;

	private bool isAuto;

	private WaitForSeconds wait;

	private Coroutine coroutineCountDown;

	private Coroutine coroutinePlayMove;

	private WaitForSeconds cardWait;

	private Color addHeightColor;

	private int addHeight;

	private float roadSpeed;

	private const int SLOW_FPS = 15;

	private const int FAST_FPS = 45;

	private const int CAVE_SLOW_FPS = 7;

	private const int CAVE_FAST_FPS = 21;

	private bool isAllAuto;

	private const float CardGoTime = 0.3f;

	private const float AutoCloseRewardTime = 1.5f;

	private const float RoadReset = 4f;

	private bool isGoOnAuto;

	private bool isOpen;

	private Act6thDrillTreasureMgr DMgr => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void Refresh()
	{
	}

	private void RefreshShopProp()
	{
	}

	private void AddShopProp(int aCount, int bCount)
	{
	}

	public void RefreshHeight()
	{
	}

	public void RefreshRedNode()
	{
	}

	public void RefreshPropCount()
	{
	}

	public void InitMiddleCards()
	{
	}

	private void Esc()
	{
	}

	private void RefreshCountDown()
	{
	}

	private void FixedUpdate()
	{
	}

	private void RoadMove()
	{
	}

	public void RefreshPlayBtnText()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__80))]
	private IEnumerator CountDown()
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void BoosterAniEnd()
	{
	}

	private void AutoCloseRewardShow()
	{
	}

	public void RefreshRoad()
	{
	}

	public void GoNextRoad()
	{
	}

	private void cloudCome(Action action = null)
	{
	}

	private void cloudGo(Action action = null)
	{
	}

	public void GoNextRound()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void showPopReward(Act6thDrillTreasureAchievementData aData, Vector3 pos)
	{
	}

	public void OnBtnCloseClick()
	{
	}

	private void OnBtnInfoClick()
	{
	}

	private void OnBtnGiftClick()
	{
	}

	private void OnBtnShopClick()
	{
	}

	private void OnBtnTaskClick()
	{
	}

	private void OnBtnAutoPlayClick()
	{
	}

	[IteratorStateMachine(typeof(_003CStartAutoPlay_003Ed__98))]
	private IEnumerator StartAutoPlay()
	{
		return null;
	}

	private int[] GetRandomCardIndex(int count)
	{
		return null;
	}

	public void RestartAutoPlay()
	{
	}

	private void ShowReward()
	{
	}

	private void OnBtnQuickBuyClick()
	{
	}

	private void OnBtnAutoPlayDisable()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}
}
