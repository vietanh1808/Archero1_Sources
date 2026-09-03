using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;
using UnityEngine;

public class DeepSeaMonsterManager
{
	public enum Stage
	{
		None = 0,
		Monster = 1,
		Island = 2
	}

	public class BuffData
	{
		public string buffType;

		public Sprite buffIcon;

		public string buffValue;

		public bool isUnLock;
	}

	public class DSMRewardItemData
	{
		private STSpecia3DepthRewardData severData;

		protected DeepSeaMonsterManager parent;

		public virtual Stage stage => Stage.None;

		public int ID => 0;

		public int NeedProgress => 0;

		public List<Drop_DropModel.DropData> Rewards => null;

		public int index => 0;

		public virtual BeastIslandRewardStatus Status => BeastIslandRewardStatus.None;

		public DSMRewardItemData(DeepSeaMonsterManager _manager, STSpecia3DepthRewardData _severData)
		{
		}
	}

	public class DSMIslandRewardItemData : DSMRewardItemData
	{
		public override Stage stage => Stage.None;

		public override BeastIslandRewardStatus Status => BeastIslandRewardStatus.None;

		public DSMIslandRewardItemData(DeepSeaMonsterManager _manager, STSpecia3DepthRewardData _severData)
			: base(null, null)
		{
		}
	}

	public class UnderseaRuinsReward
	{
		private STSpecia3TreasureRewardData severData;

		public int ID => 0;

		public int Index => 0;

		public bool isBig => false;

		public Drop_DropModel.DropData drop => null;

		public UnderseaRuinsReward(STSpecia3TreasureRewardData _severData)
		{
		}
	}

	private static DeepSeaMonsterManager instance;

	public Stage curStage;

	public int progress;

	public int todayHasCount;

	private int todayMaxCount;

	public long damage;

	public long allBlood;

	public List<SailingRankShowItemData> rankShowData;

	public List<UnderseaRuinsReward> underseaRuinsRewards;

	private DSMRewardItemData[] rewardItemDatas;

	private DSMIslandRewardItemData[] islanRewarddItemDatas;

	public int underseaRuinsLuckyNum;

	public int underseaRuinsMaxLuckyNum;

	public long StartTime;

	public long EndTime;

	public long RankEndTime;

	public long underseaRuinsStartTime;

	public long underseaRuinsEndTime;

	private ulong ServerRewardBits;

	public int CanPlayCount;

	public bool isCanPaly;

	private ulong ServerIsLandRewardBits;

	[CompilerGenerated]
	private Action<bool> m_OnDeepSeaMonsterInfoCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnDeepSeaMonsterBossRewardCallBack;

	[CompilerGenerated]
	private Action<int[], List<Drop_DropModel.DropData>> m_OnUnderseaRuinsRewardCallBack;

	[CompilerGenerated]
	private Action<List<SailingMonsterMCannonDamageData>, List<Drop_DropModel.DropData>> m_OnDeepSeaMonsterFireCallBack;

	[CompilerGenerated]
	private Action m_OnExchangeBomCallBack;

	public static DeepSeaMonsterManager Instance => null;

	public int TodayMaxCount => 0;

	public long leftTime => 0L;

	public int keyCount => 0;

	public bool isOpen => false;

	public bool underseaRuinsIsOpen => false;

	public bool isHaveBossRewardCanRevice => false;

	public bool isAllIsLandRewardClaimed => false;

	public int DifficultId => 0;

	public int CollectionMatID => 0;

	public int CurCollectionProgress
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MaxCollectionProgress => 0;

	public float CollectionProgressRate => 0f;

	public int nextIslandRewardBlood => 0;

	public event Action<bool> OnDeepSeaMonsterInfoCallBack
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

	public event Action<bool> OnDeepSeaMonsterBossRewardCallBack
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

	public event Action<int[], List<Drop_DropModel.DropData>> OnUnderseaRuinsRewardCallBack
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

	public event Action<List<SailingMonsterMCannonDamageData>, List<Drop_DropModel.DropData>> OnDeepSeaMonsterFireCallBack
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

	public event Action OnExchangeBomCallBack
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

	private DeepSeaMonsterManager()
	{
	}

	public bool IsClaimedIslandReward(int rewardId)
	{
		return false;
	}

	public bool IsClaimedReward(int rewardId)
	{
		return false;
	}

	public DSMRewardItemData[] GetRewards(Stage stage)
	{
		return null;
	}

	public BuffData[] GetBuffs()
	{
		return null;
	}

	public float GetRemainBlood()
	{
		return 0f;
	}

	public int GetConsumePower()
	{
		return 0;
	}

	public void ReqDeepSeaMonsterInfo(Action callback = null)
	{
	}

	public void ReqDeepSeaMonsterBossReward(int id, Stage stage)
	{
	}

	public void ReqUnderseaRuinsReward(bool isTen)
	{
	}

	public void ReqDeepSeaMonsterFire(int normalCount, int premiumCount)
	{
	}

	public void ReqFireInfo()
	{
	}

	public void ReqExchangeBom(int normalCount)
	{
	}

	private void SyncRankShowData(STShipBattleSeasonIsLandRankInfo rData)
	{
	}

	private void SyncRankShowData(STShipBattleSeasonFireRankInfo rData)
	{
	}

	private void showRewardWindow(STCommonData stcd, Action onCloseShowRewardWindow = null)
	{
	}
}
