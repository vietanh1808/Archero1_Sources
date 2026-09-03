using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;

public class MonopolyAchievementData
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public NetBox net;

		public MonopolyAchRewardItemData giftData;

		internal bool _003CRequestMonopolyAchGift_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CRequestMonopolyAchGift_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolyAchRewardItemData giftData;

		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		public MonopolyAchievementData _003C_003E4__this;

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
		public _003CRequestMonopolyAchGift_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003CSetTotleScoce_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int final;

		public MonopolyAchievementData _003C_003E4__this;

		private int _003Cadd_003E5__2;

		private MonopolyAchRewardItemData _003Ccur_003E5__3;

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
		public _003CSetTotleScoce_003Ed__17(int _003C_003E1__state)
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

	public int TotalScore;

	public int MaxScorce;

	public int RemainReceiveTimes;

	private List<MonopolyAchRewardItemData> monopolyAchItemDatas;

	public MonopolyAchRewardLoopItemData loopMonopolyAchItemData;

	[CompilerGenerated]
	private Func<List<Drop_DropModel.DropData>, bool, IEnumerator> m_OnGiftGet;

	public Func<int, IEnumerator> OnAddSorce;

	public Func<MonopolyAchRewardItemData, IEnumerator> OnRequsetReward;

	public long LeftTime => 0L;

	public bool isEntanceLoop => false;

	public event Func<List<Drop_DropModel.DropData>, bool, IEnumerator> OnGiftGet
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Init(int scorce, STCommonAchievementData[] datas, STCommonAchievementData loopData, int RemainReceiveTimes)
	{
	}

	public List<MonopolyAchRewardItemData> GetAll()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRequestMonopolyAchGift_003Ed__14))]
	public IEnumerator RequestMonopolyAchGift(MonopolyAchRewardItemData giftData)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetTotleScoce_003Ed__17))]
	public IEnumerator SetTotleScoce(int final)
	{
		return null;
	}

	public MonopolyAchRewardItemData GetCurAch()
	{
		return null;
	}
}
