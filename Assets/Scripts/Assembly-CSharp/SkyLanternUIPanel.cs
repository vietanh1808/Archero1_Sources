using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;
using UnityEngine;

public class SkyLanternUIPanel : MediatorCtrlBase
{
	private class TimeLineJumpLightItem : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineJumpLightItem _003C_003E4__this;

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

		private SkyLanternRewardItem item;

		private float interval;

		public TimeLineJumpLightItem(SkyLanternRewardItem item, float interval)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__3))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	private class TimeLineShowRewardItem : TimeLineItem
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

		public TimeLineShowRewardItem(List<Drop_DropModel.DropData> rewards)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__1))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	public DxxText titleTex;

	public DxxText timeText;

	public DxxText diamondText;

	public DxxText oneBtnNumText;

	public DxxText roundBtnNumText;

	public DxxText oneBtnText;

	public DxxText roundBtnText;

	public DxxText skipText;

	public ButtonCtrl bgBtn;

	public ButtonCtrl closeBtn;

	public ButtonCtrl infoBtn;

	public ButtonCtrl oneBtn;

	public ButtonCtrl roundBtn;

	public SkyLanternRewardItem[] smallRewardItems;

	public SkyLanternRewardItem[] bigRewardItems;

	public SkyLanternSelectPanel selectPanel;

	public SkyLanternInfoPanel infoPanel;

	public SkyLanternModelShowPart modelShowPart;

	public GameObject skipCheckObj;

	public GameObject selectBigObj;

	private bool isSkip;

	private bool isPlaying;

	[Header("加速启动跳跃次数")]
	public int StartTimes;

	[Header("加速启动跳跃间隔")]
	public float[] StartInterval;

	[Header("高频随机跳跃持续时间")]
	public float ContinuousTime;

	[Header("加速启动跳跃间隔")]
	public float ContinuousInterval;

	[Header("降低速度跳跃次数")]
	public int EndTimes;

	[Header("降低速度跳跃间隔")]
	public float[] EndInterval;

	private TimeLineContainer showModelTimeLine;

	private TimeLineContainer aniTimeLine;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnReqSelectRewardCallBack(bool obj)
	{
	}

	private void OnReqLotteryCallBack(uint[] arg1, uint arg2, List<Drop_DropModel.DropData> arg3, bool isRound)
	{
	}

	private void AddTimeLineItem(TimeLineContainer timeline, SkyLanternRewardItem[] items, int id)
	{
	}

	private void OnReqInfoCallBack(bool obj)
	{
	}

	protected override void OnClose()
	{
	}

	public void ClickAddSpeed()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshSmallRewards()
	{
	}

	private void RefreshBigRewards()
	{
	}

	private void RefreshPrice()
	{
	}

	private void OpenSelectPanel(SkyLanternRewardData data)
	{
	}

	private void ClickInfo()
	{
	}

	private void ClosePanel()
	{
	}

	private void ClickRound()
	{
	}

	private void ClickOne()
	{
	}

	private void StartShowModel()
	{
	}

	private void freshTime()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
