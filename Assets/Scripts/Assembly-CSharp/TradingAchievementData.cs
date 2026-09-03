using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;

public class TradingAchievementData
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public NetBox net;

		public TradingAchRewardItemData giftData;

		internal bool _003CRequestTradingAchGift_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CRequestTradingAchGift_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TradingAchRewardItemData giftData;

		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		public TradingAchievementData _003C_003E4__this;

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
		public _003CRequestTradingAchGift_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CSetTotleScoce_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int final;

		public TradingAchievementData _003C_003E4__this;

		private int _003Cadd_003E5__2;

		private TradingAchRewardItemData _003Ccur_003E5__3;

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
		public _003CSetTotleScoce_003Ed__15(int _003C_003E1__state)
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

	private List<TradingAchRewardItemData> tradingAchItemDatas;

	[CompilerGenerated]
	private Func<List<Drop_DropModel.DropData>, bool, IEnumerator> m_OnGiftGet;

	public Func<int, IEnumerator> OnAddSorce;

	public Func<TradingAchRewardItemData, IEnumerator> OnRequsetReward;

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

	public void Init(int scorce, STCommonAchievementData[] datas)
	{
	}

	public List<TradingAchRewardItemData> GetAll()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRequestTradingAchGift_003Ed__12))]
	public IEnumerator RequestTradingAchGift(TradingAchRewardItemData giftData)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetTotleScoce_003Ed__15))]
	public IEnumerator SetTotleScoce(int final)
	{
		return null;
	}

	public TradingAchRewardItemData GetCurAch()
	{
		return null;
	}
}
