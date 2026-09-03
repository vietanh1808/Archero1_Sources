using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;
using UnityEngine;

public class UnderseaRuinsUICtrl : MediatorCtrlBase
{
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

		public TimeLineShowReward(List<Drop_DropModel.DropData> rewards)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__1))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	private class TimeLineShowHightLight : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineShowHightLight _003C_003E4__this;

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
			public _003CWait_003Ed__3(int _003C_003E1__state)
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

		private UnderseaRuinsRewardItem mItem;

		private bool isShow;

		public TimeLineShowHightLight(UnderseaRuinsRewardItem item)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__3))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	public DxxText titleTex;

	public DxxText timeTex;

	public DxxText giftBtnTex;

	public DxxText luckyNumTex;

	public DxxText descTex;

	public DxxText onebtnNumTex;

	public DxxText tenBtnNumTex;

	public DxxText oneBtnTex;

	public DxxText tenBtnTex;

	public DxxText skipAniTex;

	public DxxText keyNumTex;

	public ButtonCtrl closeBtn;

	public ButtonCtrl infoBtn;

	public ButtonCtrl giftBtn;

	public ButtonCtrl oneBtn;

	public ButtonCtrl tenBtn;

	public UnderseaRuinsRewardItem[] rewardItems;

	public GameObject duiObj;

	public RewardTipsCtrl tipsCtrl;

	private TimeLineContainer timeLine;

	private bool isSkipAni;

	private float[] intervals;

	private Stack<int> showRewardIndexs;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnDeepSeaMonsterInfoCallBack(bool obj)
	{
	}

	private void OnCurrencyChanged(CurrencyType type, int arg2, int arg3)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshSkip()
	{
	}

	protected override void OnClose()
	{
	}

	public void ClickClose()
	{
	}

	private void ClickInfo()
	{
	}

	private void ClickOne()
	{
	}

	private void ClickTen()
	{
	}

	private void ClickGift()
	{
	}

	public void ClickSkip()
	{
	}

	private void freshTime()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Update()
	{
	}

	public void StartRewardAni(int[] rewardIndexs, List<Drop_DropModel.DropData> rewards)
	{
	}
}
