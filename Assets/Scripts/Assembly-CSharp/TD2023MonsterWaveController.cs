using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class TD2023MonsterWaveController
{
	public class WaveVO
	{
		private int finishedPathCount;

		private string WaveUpdateName;

		public int WaveId;

		public List<PathVO> PathVOList;

		public float Time;

		private TD2023MonsterWaveController waveController;

		public Action<PathVO> OnPathFinished;

		private ConditionTime delayTime;

		public int TotalMonsterCount;

		private float curElapsedTime;

		private float remainTime;

		public WaveVO(int waveId, TD2023MonsterWaveController _waveController)
		{
		}

		public void DeInit()
		{
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		private void onUpdate(float deltaTime)
		{
		}

		private void startPath()
		{
		}

		private void onPathFinished(PathVO pathVO)
		{
		}

		public string PrintInfo()
		{
			return null;
		}
	}

	public class PathVO
	{
		public int CurGroupIndex;

		public int PathId;

		public List<GroupVO> GroupVOList;

		public Action<GroupVO> OnGroupFinished;

		public ConditionTime timeInterval;

		private string UpdateName;

		private bool CanCreateGroup;

		public WaveVO waveVO;

		public Vector3 pos;

		public bool HasBoss;

		public int TotalMonsterCount;

		public Action<SubGroupVO> OnMonsterCreated;

		public int CurMonsterCount;

		public PathVO(int pathId, List<int> _groupIds, WaveVO _waveVO)
		{
		}

		public void DeInit()
		{
		}

		public void Start()
		{
		}

		private void onMonsterCreated(SubGroupVO vo)
		{
		}

		public bool ReachMaxMonster()
		{
			return false;
		}

		public void Stop()
		{
		}

		private void onUpdate(float delta)
		{
		}

		private void onGroupFinished(GroupVO groupVO)
		{
		}

		private void startGroup()
		{
		}

		private void initGroupVOList(List<int> groupIds)
		{
		}

		private void createDailyGroupVO(Daily_MonsterGroup groupMeta, int groupId, int i)
		{
		}

		private void createSeasonGroupVO(PVEStage_MonsterGroup groupMeta, int groupId, int i)
		{
		}

		public string PrintInfo()
		{
			return null;
		}
	}

	public class GroupVO
	{
		public int CurSubGroupIndex;

		public int GroupSn;

		public string[] MonsterIdStrs;

		public int GroupId;

		public float MonsterInterval;

		public float GroupInterval;

		private List<SubGroupVO> SubGroupVOList;

		public PathVO pathVO;

		private string updateName;

		private ConditionTime subGroupInterval;

		public Action<SubGroupVO> OnSubGroupFinished;

		public GroupVO(PathVO _pathVO)
		{
		}

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		private void onSubGroupFinished(SubGroupVO sub)
		{
		}

		private void onUpdate(float delta)
		{
		}

		private void startSubGroup()
		{
		}

		public string PrintInfo()
		{
			return null;
		}
	}

	public class SubGroupVO
	{
		public int CurMonsterCount;

		public int SubGroupSn;

		public int MonsterId;

		public int TotalMonsterCount;

		public float MonsterInterval;

		private string updateName;

		public GroupVO groupVO;

		private ConditionTime conditionTime;

		public SubGroupVO(GroupVO _groupVO)
		{
		}

		public void DeInit()
		{
		}

		public string PrintInfo()
		{
			return null;
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		private void onUpdate(float delta)
		{
		}
	}

	public bool AllMonsterCreated;

	public int CurWaveId;

	private ConditionTime waveInterval;

	private const string UPDATE_NAME = "TD2023MonsterWaveController-Update";

	public Action<WaveVO> OnAllPathFinished;

	public Dictionary<int, string[]> AttrDict;

	public Dictionary<int, string[]> MapAttrDict;

	private List<WaveVO> WaveVOList;

	private Dictionary<int, Tower_Defense_Wave101Model.LevelWaveData> LevelWaveDict;

	private Tower_Defense_Wave101Model.LevelWaveData CurLevelWaveData;

	private bool init;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void OnCurWavePathFinished(WaveVO waveVO)
	{
	}

	public int GetMaxWave()
	{
		return 0;
	}

	private bool CanStartWave()
	{
		return false;
	}

	public bool ReachMaxWave()
	{
		return false;
	}

	public void StartWave()
	{
	}

	private WaveVO GetWaveVO(int waveId)
	{
		return null;
	}

	public string[] GetMapAttrByWaveId(int waveId)
	{
		return null;
	}

	public string[] GetAttrByWaveId(int waveId)
	{
		return null;
	}

	private void initAttr()
	{
	}

	private int[] getCurWavePath(Tower_Defense_Wave101Model.WaveOne waveOne)
	{
		return null;
	}

	private void initPath()
	{
	}
}
