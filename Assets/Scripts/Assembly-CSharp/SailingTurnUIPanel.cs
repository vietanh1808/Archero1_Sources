using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SailingTurnUIPanel : MediatorCtrlBase
{
	private class TimeLineReqWheel : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public NetBox net;

			public TimeLineReqWheel _003C_003E4__this;

			internal bool _003CWaitWheelComplete_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitWheelComplete_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineReqWheel _003C_003E4__this;

			private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

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
			public _003CWaitWheelComplete_003Ed__6(int _003C_003E1__state)
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

		public int rewardId;

		public int rate;

		public List<Drop_DropModel.DropData> rewards;

		public bool isSuccess;

		private SailingTurnData CurWheelData;

		public TimeLineReqWheel(SailingTurnData wheelData)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitWheelComplete_003Ed__6))]
		private IEnumerator WaitWheelComplete()
		{
			return null;
		}
	}

	private class TimeLineWheel : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWaitWheelComplete_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineWheel _003C_003E4__this;

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
			public _003CWaitWheelComplete_003Ed__2(int _003C_003E1__state)
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

		public SailingTurnUIPanel m_Ctrl;

		public TimeLineWheel(SailingTurnUIPanel Ctrl, SailingTurnData wheelData, TimeLineReqWheel req)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitWheelComplete_003Ed__2))]
		private IEnumerator WaitWheelComplete()
		{
			return null;
		}
	}

	private class TimeLineSelectLight : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWaitWheelComplete_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CWaitWheelComplete_003Ed__2(int _003C_003E1__state)
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

		public SailingTurnUIPanel m_Ctrl;

		public TimeLineSelectLight(SailingTurnUIPanel Ctrl)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitWheelComplete_003Ed__2))]
		private IEnumerator WaitWheelComplete()
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

			private float _003Ctime_003E5__2;

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

		public TimeLineShowReward(TimeLineReqWheel req)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__1))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	public class TabBtns
	{
		public class TabBtn
		{
			private int m_index;

			public ButtonCtrl button;

			public GameObject focusObj;

			public RedNodeCtrl redObj;

			public Text nameText;

			private bool m_IsFocus;

			private Action<int> callBack;

			public TabBtn(int index, Transform go, Action<int> onClick)
			{
			}

			public void ClickDO()
			{
			}

			public void SetFocus(bool isFocus)
			{
			}

			public void SetRed(bool isShow)
			{
			}

			public void SetName(string name)
			{
			}

			public bool IsFocus()
			{
				return false;
			}

			public int GetIndex()
			{
				return 0;
			}
		}

		private TabBtn[] m_btns;

		public TabBtns(Transform tabBtnParent, Action<int> onClick)
		{
		}

		public void RefreshRed(Func<int, bool> isShowRed)
		{
		}

		public void ClickTab(int index)
		{
		}

		public void Close()
		{
		}

		public void OnLanguageChange(Func<int, string> getName)
		{
		}

		public int GetFocusIndex()
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingTurnUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__79(int _003C_003E1__state)
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
	private sealed class _003CStartLongPressBtn_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingTurnUIPanel _003C_003E4__this;

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
		public _003CStartLongPressBtn_003Ed__66(int _003C_003E1__state)
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

	public ButtonCtrl closeBtn;

	public ButtonCtrl infoBtn;

	public ButtonCtrl getBtn;

	public ButtonCtrl refreshBtn;

	public DxxText titleTex;

	public DxxText timeTex;

	public DxxText refreshBtnText;

	public DxxText getBtnText;

	public DxxText matNumText;

	public DxxText remainText;

	public DxxText autoText;

	public SailingTurnPreviewPanel previewPanel;

	public Transform tabParent;

	public SailingTurnLight sailingTurnLight;

	public GameObject[] Bgs;

	public Image SelectLight;

	public GameObject normalPar;

	public GameObject playPar;

	public GameObject resultPar;

	public SailingTurnOutWheel outWheel;

	public SailingTurnWheel inWheel;

	public GameObject maskBtn;

	public Image longPressImg;

	public Image matImg;

	public SailingTurnCurrencyUI sailingTurnCurrency;

	public GameObject refreshDiaObj;

	public DxxText refreshfreeText;

	public DxxText refreshDiaText;

	public DxxText refreshfreeDescText;

	public RectTransform Window;

	public ButtonCtrl btnVipGet;

	public ButtonCtrl btnVipTips;

	public Animation aniVipGet;

	public DxxText txtVipTipsTxt;

	public DxxText txtGiftCountdown;

	public Image imgVipGift;

	public ButtonCtrl Button_Quick;

	public DxxText Text_Quick;

	private ImageSwitchSprite[] imageSwitches;

	private TimeLineContainer timeLine;

	private TabBtns tabBtns;

	private SailingTurnData CurWheelDate;

	private Coroutine LongPressCor;

	private WaitForSeconds vipWait;

	private Coroutine vipCountDown;

	private long CurDayEndTime;

	private float LongPressDra;

	private int VipGiftGetCount => 0;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void ClickTab(int index)
	{
	}

	public void RefreshWheel()
	{
	}

	public void RefreshRemaind()
	{
	}

	private void OnFreshWheel(bool isSuccess)
	{
	}

	protected override void OnClose()
	{
	}

	public void ClosePanel()
	{
	}

	private void OpenInfo()
	{
	}

	private void GetReward()
	{
	}

	private void ReqRefresh()
	{
	}

	private void freshTime()
	{
	}

	private void freshfreeTime()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private string SetTabName(int index)
	{
		return null;
	}

	public bool RefreshRed(int index)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CStartLongPressBtn_003Ed__66))]
	private IEnumerator StartLongPressBtn()
	{
		return null;
	}

	private void RefreshStatus()
	{
	}

	private void StartWheel(bool isAuto)
	{
	}

	public void StopAutoLoop()
	{
	}

	private bool CheckCanWheel()
	{
		return false;
	}

	private void RefreshVipBoxAndTips()
	{
	}

	private void OnVipGetBtnClicked()
	{
	}

	private void OnVipGiftTipsClicked()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__79))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void onButtonQuick()
	{
	}
}
