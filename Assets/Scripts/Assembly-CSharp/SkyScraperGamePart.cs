using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkyScraperGamePart : MonoBehaviour
{
	private class TimeLineBuilding : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public SkyScraperMgr.BuildingBoxNet net;

			public TimeLineBuilding _003C_003E4__this;

			internal bool _003CDo_003Eb__0()
			{
				return false;
			}

			internal bool _003CDo_003Eb__1()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDo_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineBuilding _003C_003E4__this;

			private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

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
			public _003CDo_003Ed__5(int _003C_003E1__state)
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

		private SkyScraperGamePart mCtrl;

		private float mSpeed;

		private Coroutine runCorEvent;

		private TimeLineItem complete;

		public TimeLineBuilding(SkyScraperGamePart ctrl, float speed)
		{
		}

		[IteratorStateMachine(typeof(_003CDo_003Ed__5))]
		private IEnumerator Do()
		{
			return null;
		}
	}

	private class TimeLineBuildingComplete : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public SkyScraperMgr.BuilingCompleteBoxNet net;

			public TimeLineBuildingComplete _003C_003E4__this;

			internal bool _003CDo_003Eb__0()
			{
				return false;
			}

			internal bool _003CDo_003Eb__1()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_1
		{
			public RewardSimpleProxy.Transfer transfer;

			internal bool _003CDo_003Eb__2()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDo_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineBuildingComplete _003C_003E4__this;

			private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

			private _003C_003Ec__DisplayClass3_1 _003C_003E8__2;

			private float _003CshowTime_003E5__2;

			private float _003CcurShowTime_003E5__3;

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

		private SkyScraperGamePart mCtrl;

		private float mSpeed;

		public TimeLineBuildingComplete(SkyScraperGamePart ctrl, float speed)
		{
		}

		[IteratorStateMachine(typeof(_003CDo_003Ed__3))]
		private IEnumerator Do()
		{
			return null;
		}
	}

	public SkyScraperGameListView gameListView;

	public GameObject caidaiEffect;

	public GameObject lightEffect;

	public GameObject cloundObj;

	public Animator cloundAni;

	[Header("加速状态的倍率")]
	public float AddSpeedValue;

	[Header("钩子下移时间")]
	public float downTime;

	[Header("钩子停顿时间")]
	public float stayTime;

	[Header("钩子上移时间")]
	public float upTime;

	[Header("星星闪烁时间")]
	public float starTime;

	[Header("建完一层后下移时间")]
	public float ToFinalTime;

	[Header("圣诞老人展示时间")]
	public float oldManShowTime;

	[Header("彩带展示时间")]
	public float caidaiShowTime;

	[Header("建完整栋后移到最底层的整体时间")]
	public float ToFirstTime;

	[Header("建完整栋后每层开奖时间(当前范围最大层数,每层时间)")]
	public Vector2[] ToLastSpeed;

	[Header("奖励展示时间")]
	public float ShowRewardTime;

	public Action OnStopAni;

	public Action OnReqEndAni;

	public Action OnFlyAniEnd;

	public Action OnNextBuilding;

	private ViewCellData bottomData;

	private TimeLineContainer timeLine;

	[HideInInspector]
	public List<ViewCellData> list;

	public SkyScraperSantaClausData santaClausData { get; private set; }

	public SkyScraperGameClipData clipData { get; private set; }

	public void Init()
	{
	}

	public void Open()
	{
	}

	public void Refresh()
	{
	}

	public void AddSantaClaus()
	{
	}

	public List<ViewCellData> GetList()
	{
		return null;
	}

	public void ShowCaidai()
	{
	}

	public void ShowLight()
	{
	}

	public void ShowClound()
	{
	}

	public void PlayBuilding(bool isAuto, bool isAddSpeed)
	{
	}

	public void StopAuto()
	{
	}

	public void GetReward(bool isAddSpeed)
	{
	}

	public void Close()
	{
	}
}
