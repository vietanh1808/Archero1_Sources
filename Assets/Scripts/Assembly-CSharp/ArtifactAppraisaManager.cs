using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;
using Newtonsoft.Json;
using TableTool;

public class ArtifactAppraisaManager
{
	public class ArtifactAppraisaConfig
	{
		public ArtifactAppraisaBaseConfig[] Base;

		public ArtifactAppraisaBoxConfig[] ArtifactBox;

		public ArtifactAppraisaTaskConfig[] task;

		public ArtifactAppraisaGiftConfig[] gift;
	}

	public class ArtifactAppraisaBaseConfig
	{
		public int Tag;

		public long StartTime;

		public long GameEndTime;

		public long EndTime;

		public int OpenGameLevel;

		public int Version;

		public int[] Layer;

		public int[][] DefaultItems;

		public int[] ItemBuy;

		public int Activation;

		public int[] ShopCoin;
	}

	public class ArtifactAppraisaBoxConfig
	{
		public int ID;

		public string Note;

		public int Level;

		public string Img;

		public int Layer;

		public int[][] Fixed_Reward;

		public int[][] Random_Reward1;

		public int[][] Random_Reward2;

		public int[][] Random_Reward3;

		public string[][] Random_Reward_show;

		public int CostItem;

		public int UPodds;

		public int MaxUPNum;

		public int[][] CostReward;

		public string Effects;

		public string Sound;

		[JsonIgnore]
		private List<GearReward> gearRewards;

		private List<Drop_DropModel.DropData> previewRewards;

		public List<GearReward> GetGearRewards()
		{
			return null;
		}

		public List<Drop_DropModel.DropData> GetAllPreviewReward()
		{
			return null;
		}
	}

	public class ArtifactAppraisaTaskConfig
	{
		public int ID;

		public string Notes;

		public int Type;

		public int CondTypeArgs;

		public int[][] Rewards;

		public int MinLevel;

		public int MaxLevel;

		public int ShowVersion;
	}

	public class ArtifactAppraisaGiftConfig
	{
		public int ID;

		public int Position;

		public int MinLevel;

		public int MaxLevel;

		public string Product_Id;

		public int Discount;

		public int Show;

		public int[][] Reward;

		public int Quota;

		public int DailyReset;
	}

	public class GearReward
	{
		public GearRewardItem[] rewardItems;

		public bool isMust;

		public string boxImg;

		public int quality;
	}

	public class GearRewardItem
	{
		public Drop_DropModel.DropData reward;

		public int probability;
	}

	public class BoxNet
	{
		public bool isDone;

		public bool isSuccess;

		public int errorCode;

		public int curIndex;

		public List<Drop_DropModel.DropData> rewards;
	}

	public class UpBoxNet : BoxNet
	{
		public bool isUpSuccess;
	}

	private static ArtifactAppraisaManager instance;

	public ArtifactAppraisaConfig S3Config;

	public STRespActivityArtifactIdentifyAnniversary severData;

	[CompilerGenerated]
	private Action<bool> m_OnReqInfoCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqQuickBuyCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqGiftCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqTaskCallBack;

	private List<ArtifactAppraisaTaskItemData> taskItemDatas;

	private List<ArtifactAppraisaShopItemData> shopItemDatas;

	private List<ArtifactAppraisaGiftItemData> giftItemDatas;

	private List<Drop_DropModel.DropData> previewRewards;

	public static ArtifactAppraisaManager Instance => null;

	public ArtifactAppraisaBaseConfig S3BaseConfig => null;

	public bool isS3Open => false;

	public int Tag_S3 => 0;

	public int Tag_Sever => 0;

	public long DailyTime => 0L;

	public long StartTime => 0L;

	public long GameEndTime => 0L;

	public long EndTime => 0L;

	public bool isSeverOpen => false;

	public bool isSeverOpenPlay => false;

	public long leftPlayTime => 0L;

	public long leftTime => 0L;

	public int layer => 0;

	public int OpenGameLevel => 0;

	public int Round => 0;

	public int CurGearIndex => 0;

	public ArtifactAppraisaBoxConfig CurGearConfig => null;

	public ArtifactAppraisaBoxConfig[] GearConfigs => null;

	public int MaxGearIndex => 0;

	public int HasUpTimesForCurGear => 0;

	public int MatId => 0;

	public int propIdA => 0;

	public int propIdB => 0;

	public int ActiveConsumeMatCount => 0;

	public int CurConsumeMatCount => 0;

	public int MaxUpTimesForCurGear => 0;

	public int LeftMustUpCount => 0;

	public bool isOpen => false;

	public int MatCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public STCommonQuickBuyData QuickBuy => null;

	public List<Drop_DropModel.DropData> rewardCache
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long LeftTimeTask => 0L;

	public long LeftTimeGift => 0L;

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

	public event Action<bool> OnReqQuickBuyCallBack
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

	public event Action<bool> OnReqGiftCallBack
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

	private ArtifactAppraisaManager()
	{
	}

	public void ReqS3()
	{
	}

	private void ParseJson()
	{
	}

	public void ReqInfo()
	{
	}

	public BoxNet ReqActiveBox()
	{
		return null;
	}

	public UpBoxNet ReqUpBox()
	{
		return null;
	}

	public BoxNet ReqOpenBox()
	{
		return null;
	}

	public void ReqQuickBuy(int buyNum)
	{
	}

	public void ReqGiftBuy(ArtifactAppraisaGiftItemData gift)
	{
	}

	public void ReqTaskGet(ArtifactAppraisaTaskItemData task)
	{
	}

	public List<ArtifactAppraisaTaskItemData> GetTaskShowList()
	{
		return null;
	}

	public void requestShopBuyItem(ArtifactAppraisaShopItemData itemData, int count)
	{
	}

	private ArtifactAppraisaShopItemData CreatShopData(STCommonShopData d)
	{
		return null;
	}

	public List<ArtifactAppraisaShopItemData> GetShopShowList(int tab)
	{
		return null;
	}

	public bool isHaveItemExch(int type)
	{
		return false;
	}

	public List<ArtifactAppraisaGiftItemData> GetGiftShowList()
	{
		return null;
	}

	public List<Drop_DropModel.DropData> GetAllPreviewReward()
	{
		return null;
	}

	public bool isPropFly(int propID)
	{
		return false;
	}

	public bool isEntanceRed()
	{
		return false;
	}

	public bool isCanUp()
	{
		return false;
	}

	public bool isHaveTaskCanGet()
	{
		return false;
	}

	public bool isHaveGiftCanGet()
	{
		return false;
	}
}
