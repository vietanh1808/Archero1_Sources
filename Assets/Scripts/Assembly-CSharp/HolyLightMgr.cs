using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;
using UnityEngine;

public class HolyLightMgr
{
	public class HolyLightConfig
	{
		public HolyLightBaseConfig[] Base;

		public HolyLightWishConfig[] Wish;

		public HolyLightPrizeConfig[] Prize;

		public HolyLightCountConfig[] Count;

		public HolyLightDrowConfig[] Draw;

		public HolyLightRewardConfig[] Reward;

		public TreasurePrivilegeConfig[] Privilege;
	}

	public class HolyLightBaseConfig
	{
		public int Tag;

		public long ShowTime;

		public long StartTime;

		public long GameEndTime;

		public long EndTime;

		public int OpenGameLevel;

		public int Version;

		public int[][] Consume;

		public int[][] DefaultItems;
	}

	public class HolyLightWishConfig
	{
		public int ID;

		public int MinLevel;

		public int MaxLevel;

		public int Level;

		public int Value;

		public int RewardType;

		public int RewardSkill;

		public int[][] RewardItem;

		public int SkillWeight;
	}

	public class HolyLightCountConfig
	{
		public int ID;

		public int MinLevel;

		public int MaxLevel;

		public int Times;

		public int[][] Reward;
	}

	public class HolyLightRewardConfig
	{
		public int ID;

		public int[][] MinLevel;

		public int Layer;

		public int Weight;

		public int ShowWeight;
	}

	public class HolyLightDrowConfig
	{
		public int ID;

		public float[][] ExtractionProbability;
	}

	public class HolyLightPrizeConfig
	{
		public int ID;

		public int Position;

		public int[][] Reward;

		public int Layer;

		public int ShowLayer;

		public int Times;

		public int ConditionType;

		public int PrivilegeLevel;

		public int hasTimes => 0;

		public bool isShow => false;

		public bool isUnLock => false;

		public int leftTimes => 0;

		public bool IshaveTimes => false;
	}

	public class TreasurePrivilegeConfig
	{
		public int ID;

		public int Level;

		public string Note;

		public int MissionType;

		public int CondTypeArgs;

		public int Power1;

		public int Power2;

		public int Power3;

		public int[][] PicImg;

		public int SkinArgs;
	}

	private static HolyLightMgr instance;

	private static object Locker;

	private STRespActivityAngelPurify mSeverData;

	private HolyLightConfig S3Config;

	private HolyLightAllRewardData mHolyLightAllRewardData;

	private HolyLightCountRewardData mHolyLightCountRewardData;

	private TreasureLevelData mTreasureLevelData;

	[CompilerGenerated]
	private Action<bool> m_OnReqInfoCallBack;

	public Action OnReqDoanteCallBack;

	public Action<int, Vector3> OnReqAllRewardCallBack;

	public Action OnReqStageRewardCallBack;

	public Action OnReqSelectBigRewardCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqTaskCallBack;

	private List<HolyLightTaskItemData> taskItemDatas;

	public static HolyLightMgr Instance => null;

	public int Tag_Sever => 0;

	public bool isOpen => false;

	public long StartTime => 0L;

	public long GameEndTime => 0L;

	public long EndTime => 0L;

	public bool isSeverOpen => false;

	public bool isSeverOpenPlay => false;

	public long leftPlayTime => 0L;

	public long leftTime => 0L;

	public bool IsHaveRed => false;

	public bool isTaskRed => false;

	public int DonateMatId => 0;

	public int donateMatNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ConsumeMatNum => 0;

	public int hasDonateTimes => 0;

	public int mustGetTimes => 0;

	public int lastMustTimes => 0;

	public HolyLightBaseConfig S3BaseConfig => null;

	public HolyLightPrizeConfig[] S3PrizeeConfig => null;

	public long S3PreviewTime => 0L;

	public long S3StartTime => 0L;

	public bool isPreview => false;

	public long leftPreviewTime => 0L;

	public bool isS3Open => false;

	public int Tag_S3 => 0;

	public long S3GameEndTime => 0L;

	public long S3EndTime => 0L;

	public bool isS3TimeOpen => false;

	public bool isS3OpenPlay => false;

	public long leftS3PlayTime => 0L;

	public long leftS3Time => 0L;

	public int CurBigRewardID => 0;

	public int CurLevel => 0;

	public HolyLightPrizeConfig CurBigReward => null;

	public bool isPopComics
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isGuideNewWordEffect
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public event Action<bool> OnReqInfoCallBack
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

	public event Action<bool> OnReqTaskCallBack
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

	private HolyLightMgr()
	{
	}

	public void ReqS3(Action callBack = null)
	{
	}

	private void ParseJson()
	{
	}

	public void ReqInfo(Action<bool> callBack = null)
	{
	}

	private void InitData()
	{
	}

	public void ReqDoante(Action<List<Drop_DropModel.DropData>> callBack = null)
	{
	}

	public void ReqAllReward(HolyLightAllRewardItemData itemData, Vector3 pos)
	{
	}

	public void ReqStageReward(HolyLightAllRewardItemData itemData)
	{
	}

	public void ReqSelectBigReward(int id)
	{
	}

	public void ReqTaskGet(HolyLightTaskItemData task)
	{
	}

	public HolyLightAllRewardData GetAllReward()
	{
		return null;
	}

	public HolyLightCountRewardData GetCountReward()
	{
		return null;
	}

	public List<HolyLightTaskItemData> GetTaskShowList()
	{
		return null;
	}

	public List<HolyLightPrizeConfig> GetBigRewardList()
	{
		return null;
	}

	public int GetBigRewardHasTimes(int rewaedId)
	{
		return 0;
	}

	public List<(int, int)> GetUnLockSkillIds()
	{
		return null;
	}

	public bool isUnLockTryHero()
	{
		return false;
	}

	public List<HolyLightAllRewardItemData> GetRewardSkillList()
	{
		return null;
	}

	private void InitTreasureData()
	{
	}

	public int GetCurrentTreasureLevel()
	{
		return 0;
	}

	public TreasureLevelData GetTreasureLevelData()
	{
		return null;
	}

	public TreasureTaskInfo GetTreasureTasksForLevel(int level)
	{
		return null;
	}

	public List<TreasurePrivilegeInfo> GetTreasurePrivilegesForLevel(int level)
	{
		return null;
	}

	public int GetTreasurePrivilegeValue(int privilegeType)
	{
		return 0;
	}

	public bool IsTreasureLevelActivated(int level)
	{
		return false;
	}

	public bool IsTreasureDataReady()
	{
		return false;
	}

	public List<HolyLightRewardData> GetShowRewardData()
	{
		return null;
	}
}
