using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class MonopolyPiece : MonoBehaviour
{
	public class RewardShowItem
	{
		public bool isUsing;

		public GameObject obj;

		public CanvasGroup rewardCG;

		public Image rewardIcon;

		public DxxText rewardNumTex;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public RewardShowItem item;

		internal void _003CShowRewardItem_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003COnTriggerReward_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolySaveData data;

		public MonopolyPiece _003C_003E4__this;

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
		public _003COnTriggerReward_003Ed__10(int _003C_003E1__state)
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
	private sealed class _003CShowRewardItem_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolyPiece _003C_003E4__this;

		public Drop_DropModel.DropData dropData;

		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

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
		public _003CShowRewardItem_003Ed__11(int _003C_003E1__state)
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

	private MonopolyGameData.PieceData mData;

	public SkeletonGraphic skeletonGraphic;

	public GameObject rewardObj;

	private List<RewardShowItem> rewardShowItems;

	private float rewardShowDuration;

	private float rewardFadeDuration;

	public void Init(MonopolyGameData.PieceData data)
	{
	}

	public void Open()
	{
	}

	private void OnRegistEvent()
	{
	}

	[IteratorStateMachine(typeof(_003COnTriggerReward_003Ed__10))]
	private IEnumerator OnTriggerReward(MonopolySaveData data)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowRewardItem_003Ed__11))]
	private IEnumerator ShowRewardItem(Drop_DropModel.DropData dropData)
	{
		return null;
	}

	public RewardShowItem GetRewardShowItem()
	{
		return null;
	}

	private void OnPassPosition(MonopolyGameData.ChessGridData data, bool arg2)
	{
	}

	private void OnEndJump(MonopolyGameData.ChessGridData obj)
	{
	}

	private void OnStartJump()
	{
	}

	private void OnEndRailway(MonopolyGameData.ChessGridData obj)
	{
	}

	private void OnStartRailway()
	{
	}

	private void OnUnRegistEvent()
	{
	}

	public void Jump()
	{
	}

	public void JumpToRailway()
	{
	}

	public void Railway(MonopolyGameData.ChessGridData grid)
	{
	}

	public void RailwayEnd()
	{
	}

	public void Close()
	{
	}
}
