using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using GameProtocol;
using TableTool;
using UnityEngine;

public class PushPillarBoardPart : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRefreshAnimationCoroutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PushPillarBoardPart _003C_003E4__this;

		private PushPillarMgr _003Cmgr_003E5__2;

		private int[] _003ColdPositions_003E5__3;

		private int[] _003CcurrentPositions_003E5__4;

		private int _003CtotalWaves_003E5__5;

		private int _003Cwave_003E5__6;

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
		public _003CRefreshAnimationCoroutine_003Ed__27(int _003C_003E1__state)
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
	private sealed class _003CUpgradeFlyCoroutine_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PushPillarBoardPart _003C_003E4__this;

		public int targetCol;

		public int targetRow;

		public int multiplier;

		public Vector3 startWorldPos;

		public Vector3 endWorldPos;

		public Action onComplete;

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
		public _003CUpgradeFlyCoroutine_003Ed__32(int _003C_003E1__state)
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

	public PushPillarColumnView[] columns;

	public Transform dropZone;

	[Header("柱子快速下推时间")]
	public float pillarPushDownTime;

	[Header("柱子缩回时间")]
	public float pillarBounceTime;

	[Header("奖励掉落动画时间")]
	public float rewardDropTime;

	[Header("刷新时每波对角线延迟")]
	public float refreshWaveDelay;

	[Header("柱子上移一格动画时长")]
	public float pillarMoveUpTime;

	public Action OnPushAnimComplete;

	public Action OnRefreshComplete;

	public Action<int, List<Drop_DropModel.DropData>> OnRewardDrop;

	private const int COLUMN_COUNT = 5;

	private const int ROW_COUNT = 6;

	private const float PUSH_OVERSHOOT = 1.2f;

	private const float PUSH_BOUNCE = 0.2f;

	private bool isInitialized;

	private Sequence pushSequence;

	private Coroutine refreshCoroutine;

	private int[] cachedPillarPositions;

	private PushPillarGridData[,] cachedBoardGrids;

	public void Init()
	{
	}

	public void Open()
	{
	}

	public void Refresh()
	{
	}

	public void Close()
	{
	}

	public void PlayPushAnimation(int[] pushedCounts)
	{
	}

	public void PlayPushAnimation(int columnIndex, int moveCount)
	{
	}

	public void CachePillarPositionsBeforeRefresh()
	{
	}

	public void PlayRefreshAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshAnimationCoroutine_003Ed__27))]
	private IEnumerator RefreshAnimationCoroutine()
	{
		return null;
	}

	public void PlayChoicePlaceEffect(int columnIndex, int row)
	{
	}

	public void PlayUpgradeEffect(int columnIndex, int row)
	{
	}

	public void PlayRewardDropAnimation(int columnIndex, List<Drop_DropModel.DropData> rewards)
	{
	}

	public void PlayUpgradeFlyAnimation(STActivityPushPillarUpgradeEvent upgradeEvent, Action onComplete = null)
	{
	}

	[IteratorStateMachine(typeof(_003CUpgradeFlyCoroutine_003Ed__32))]
	private IEnumerator UpgradeFlyCoroutine(Vector3 startWorldPos, Vector3 endWorldPos, int targetCol, int targetRow, int multiplier, Action onComplete)
	{
		return null;
	}

	private void PlayUpgradeArriveEffect(int targetCol, int targetRow, int multiplier)
	{
	}

	public void ShowGuidePillarsAtBottom()
	{
	}

	public bool IsPillarAtBottom(int columnIndex)
	{
		return false;
	}

	public void OnLanguageChange()
	{
	}

	private bool ValidateColumnIndex(int columnIndex)
	{
		return false;
	}

	private float GetGridHeight()
	{
		return 0f;
	}

	private void CollectColumnRewards(int columnIndex)
	{
	}

	private void KillPushSequence()
	{
	}

	private void OnDestroy()
	{
	}
}
