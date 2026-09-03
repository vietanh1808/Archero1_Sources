using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using Spine.Unity;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class PushPillarUIPanel : MediatorCtrlBase
{
	private class TimeLinePush : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public PushResultNet result;

			internal bool _003CDo_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDo_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

			public TimeLinePush _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CDo_003Ed__3(int _003C_003E1__state)
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

		private readonly PushPillarUIPanel mCtrl;

		public List<Drop_DropModel.DropData> collectedRewards;

		public TimeLinePush(PushPillarUIPanel ctrl)
		{
		}

		[IteratorStateMachine(typeof(_003CDo_003Ed__3))]
		private IEnumerator Do()
		{
			return null;
		}
	}

	private class TimeLineShowReward : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CWait_003Ed__1(int _003C_003E1__state)
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

		public TimeLineShowReward(List<Drop_DropModel.DropData> rewards)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__1))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public PushPillarUIPanel _003C_003E4__this;

		public CommonTipsUICtrl.TipsData data;

		internal void _003CStartLongPressBtn_003Eb__0()
		{
		}

		internal void _003CStartLongPressBtn_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDelayOpenChoiceGuide_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PushPillarUIPanel _003C_003E4__this;

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
		public _003CDelayOpenChoiceGuide_003Ed__77(int _003C_003E1__state)
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
	private sealed class _003CPlayCountChange_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Text numTex;

		public int targetNum;

		private float _003Coffset_003E5__2;

		private float _003Cstep_003E5__3;

		private float _003Cresult_003E5__4;

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
		public _003CPlayCountChange_003Ed__62(int _003C_003E1__state)
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
	private sealed class _003CStartLongPressBtn_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PushPillarUIPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass72_0 _003C_003E8__1;

		private float _003Ctime_003E5__2;

		private bool _003CisPlaySound_003E5__3;

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
		public _003CStartLongPressBtn_003Ed__72(int _003C_003E1__state)
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

	public DxxText titleTex;

	public DxxText timeTex;

	public ButtonCtrl closeBtn;

	public ButtonCtrl infoBtn;

	public Image bannerImg;

	public PushPillarBoardPart boardPart;

	public PushPillarProgressPart progressPart;

	public PushPillarChoicePanel choicePanel;

	public ButtonCtrl pushBtn;

	public DxxText pushCostText;

	public Image longPressImg;

	public DxxText autoStatusText;

	public DxxText autoingText;

	public ButtonCtrl quickBuyBtn;

	public GameObject skipAnimCheckObj;

	public Image pushCoinIconImg;

	public Image pushCoinIconImg1;

	public DxxText pushCoinNumText;

	public Image shopPointIconImg;

	public DxxText shopPointNumText;

	public ButtonCtrl shopBtn;

	public ButtonCtrl taskBtn;

	public ButtonCtrl choiceBtn;

	public ButtonCtrl refreshBtn;

	public Image refreshImg;

	public Sprite noRefreshSprite;

	public Sprite refreshSprite;

	public RedNodeCtrl shopNode;

	public RedNodeCtrl taskNode;

	public SkeletonGraphic skeletonGraphic;

	public DxxText choiceBtnText;

	public DxxText shopBtnText;

	public DxxText taskBtnText;

	public DxxText descText;

	public static bool isPlaying;

	private bool isAuto;

	private long startAutoTime;

	private Coroutine LongPressCor;

	private TimeLineContainer timeLine;

	private TimeLineContainer finalTimeLine;

	private bool isLongPressCheck;

	private readonly float LongPressDra;

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

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void OnInfoCallBack(bool success)
	{
	}

	private void OnPushCallBack(bool success)
	{
	}

	private void OnRefreshCallBack(bool success)
	{
	}

	private void OnQuickBuyCallBack(bool success)
	{
	}

	private void OnShopBuyCallBack(bool success)
	{
	}

	private void OnTaskCallBack(bool success)
	{
	}

	private void OnGiftCallBack(bool success)
	{
	}

	private void OnChoicePlaceCallBack(bool success)
	{
	}

	private void OnProgressRewardCallBack()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshCurrencyNum(bool isAni = false)
	{
	}

	private void RefreshPushCost()
	{
	}

	public void RefreshRed()
	{
	}

	private void RefreshChoiceBtn()
	{
	}

	private void RefreshRefreshBtn()
	{
	}

	private void RefreshPushBtn()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayCountChange_003Ed__62))]
	public IEnumerator PlayCountChange(Text numTex, int targetNum)
	{
		return null;
	}

	private void ClickPush()
	{
	}

	private void PlayPushTimeLine(bool isAutoLoop)
	{
	}

	private void ClickShop()
	{
	}

	private void ClickTask()
	{
	}

	private void ClickChoice()
	{
	}

	private void ClickRefresh()
	{
	}

	private void ClickQuickBuy()
	{
	}

	private void ClickInfo()
	{
	}

	[IteratorStateMachine(typeof(_003CStartLongPressBtn_003Ed__72))]
	private IEnumerator StartLongPressBtn()
	{
		return null;
	}

	private void StartAutoPush()
	{
	}

	private void StopAutoPush()
	{
	}

	private void freshTime()
	{
	}

	private void ClosePanel()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayOpenChoiceGuide_003Ed__77))]
	private IEnumerator DelayOpenChoiceGuide()
	{
		return null;
	}
}
