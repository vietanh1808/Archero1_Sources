using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class ActMountainUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public ActMountainUIPanel _003C_003E4__this;

		public bool reqSuccess;

		public Action _003C_003E9__0;

		internal void _003CStartAutoPlay_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActMountainUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__86(int _003C_003E1__state)
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
	private sealed class _003CStartAutoPlay_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActMountainUIPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass106_0 _003C_003E8__1;

		private int _003Cindex_003E5__2;

		private int _003CopenCount_003E5__3;

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
		public _003CStartAutoPlay_003Ed__106(int _003C_003E1__state)
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
	private DxxText text_height;

	[SerializeField]
	private DxxText text_heightCount;

	[SerializeField]
	private DxxText text_AddHeight;

	[SerializeField]
	private DxxText text_AddHeightNatural;

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
	private MountainCardItem[] cards;

	[SerializeField]
	private Toggle tg_clean;

	[SerializeField]
	private MountainHeightBox heightBox;

	[SerializeField]
	private GameObject allMask;

	[SerializeField]
	private GameObject go_EffectLight;

	[SerializeField]
	private GameObject go_EffectSmoke;

	[SerializeField]
	private Transform trans_Hero;

	[SerializeField]
	private RectTransform rect_Cloud;

	[SerializeField]
	private RectTransform rect_Cloud2;

	[SerializeField]
	private RectTransform rect_Road1;

	[SerializeField]
	private RectTransform rect_Road2;

	[SerializeField]
	private RectTransform rect_BehindRoad1;

	[SerializeField]
	private RectTransform rect_BehindRoad2;

	[SerializeField]
	private Animation ani_Hero;

	[SerializeField]
	private RedNodeCtrl redNode_Gift;

	[SerializeField]
	private RedNodeCtrl redNode_Task;

	[SerializeField]
	private RedNodeCtrl redNode_Achievement;

	[SerializeField]
	private ActMountainInfoPanel infoPanel;

	[SerializeField]
	private Image image_Prop;

	[SerializeField]
	private Image image_BtnPlay;

	[SerializeField]
	private SkeletonGraphic sk_Boat;

	[SerializeField]
	private GameObject go_EffectSlow;

	[SerializeField]
	private GameObject go_EffectQuick;

	public GameObject Cloud;

	public DxxText Text_Searching;

	public RectTransform CloudLeft;

	public RectTransform CloudRight;

	public GameObject PopRewardWindow;

	public RectTransform PopContainer;

	public GameObject cpPopItem;

	private Vector3 cloudEndValue;

	private Vector3 cloudRestartValue;

	private Vector3 roadRestartValue;

	private Vector3 roadBehindRestartValue;

	private Vector3 roadEndValue;

	private Vector3 roadBehindEndValue;

	private bool isAuto;

	private bool isAllAuto;

	private WaitForSeconds wait;

	private Coroutine coroutineCountDown;

	private Coroutine coroutinePlayMove;

	private WaitForSeconds cardWait;

	private Color addHeightColor;

	private int addHeight;

	private float cloudSpeed;

	private float roadSpeed;

	private float mountainSpeed;

	private const float CardGoTime = 0.3f;

	private const float AutoCloseRewardTime = 1.5f;

	private bool isOpen;

	private bool isGoOnAuto;

	private ActMountaineeringMgr m_Mgr => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshBoat()
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

	private void Update()
	{
	}

	public void CloudMove()
	{
	}

	private void SeaMove()
	{
	}

	public void RefreshPlayBtnText()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__86))]
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

	public void showPopReward(MountainAchievementData aData, Vector3 pos)
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

	private void OnBtnAutoPlayDisable()
	{
	}

	public void RestartAutoPlay()
	{
	}

	private void ShowReward()
	{
	}

	[IteratorStateMachine(typeof(_003CStartAutoPlay_003Ed__106))]
	private IEnumerator StartAutoPlay()
	{
		return null;
	}

	private void OnBtnQuickBuyClick()
	{
	}
}
