using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;

public class SeasonTaskMgr : CInstance<SeasonTaskMgr>
{
	public enum SeasonTaskState
	{
		InProgress = 0,
		CanClaim = 1,
		Finished = 2
	}

	public class SeasonTaskNode
	{
		private Achieve_PVEAchieve _config;

		private SeasonTaskState _state;

		public int Count { get; }

		public int Id { get; private set; }

		public int RewardNum => 0;

		public int RewardIcon => 0;

		public int RewardType => 0;

		public List<Drop_DropModel.DropData> HardRewards => null;

		public float Percent => 0f;

		public int SortOrder { get; private set; }

		public string Text => null;

		public int Target => 0;

		public bool Complete => false;

		public bool CanClaim => false;

		public bool Over => false;

		public bool InProgress => false;

		public SeasonTaskNode(Achieve_PVEAchieve config, int count, bool over)
		{
		}

		public void RefreshData(Achieve_PVEAchieve config, bool over)
		{
		}
	}

	private static int[] magicArray;

	[CompilerGenerated]
	private Action m_OnItemChanged;

	private Dictionary<int, Achieve_PVEAchieve> _configDic;

	private bool _claiming;

	private Dictionary<int, List<Achieve_PVEAchieve>> _hardConfigDic;

	public bool IsProhibited { get; private set; }

	public List<SeasonTaskNode> AllNormalTasks { get; set; }

	public List<SeasonTaskNode> AllHardTasks { get; set; }

	public int TaskCount { get; private set; }

	public int HardTaskCount { get; private set; }

	public long TimeLeft => 0L;

	public bool HasCanClaim => false;

	public bool HasHardCanClaim => false;

	public bool SeasonOver => false;

	public event Action OnItemChanged
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

	public new void Init()
	{
	}

	private void InitConfigList()
	{
	}

	public void RefreshFromNet(Action<bool> callback = null)
	{
	}

	public void ClaimReward(SeasonTaskNode node, Action callback)
	{
	}

	public void RequestHardTaskInfo(Action<bool> callback = null)
	{
	}

	public void ClaimHardReward(SeasonTaskNode node, Action callback)
	{
	}

	public void SetHardTaskData(CRespPveSeasonAchieve data)
	{
	}

	public void ClaimAllHarReward(Action callback)
	{
	}
}
