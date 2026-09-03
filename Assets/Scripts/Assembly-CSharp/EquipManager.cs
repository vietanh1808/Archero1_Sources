using System;
using System.Collections.Generic;
using GameProtocol;

public sealed class EquipManager : CInstance<EquipManager>
{
	public class EquipSDropUp
	{
		public int Rate;

		public long OpenTime;

		public long EndTime;

		public int[][] UPshow;

		public string Img;
	}

	private List<ulong> breakList;

	public long meltBeginTime;

	public int meltTimes;

	public Dictionary<int, List<CommonMatIdData>> equipCommonMatDict;

	private const int MaxQuality = 8;

	private List<int> canExcList;

	public const int EquipCastMatId = 31016;

	public long EquipS_OpenTime;

	public long EquipS_EndTime;

	private bool haveOpenEquipS;

	public EquipSDropUp EquipSDropUpInfo;

	public bool IsOneKeyDragonCombineOPen => false;

	public int MaxOneKeyDragonCombineNum => 0;

	public int[] CanOneKeyDragonCombineQualitys => null;

	public long EquipS_LeftTime => 0L;

	public long EquipS_TotalTime => 0L;

	public int EquipS_PriceTen => 0;

	public ushort EquipSCount { get; private set; }

	public int BagShowCondTotal => 0;

	public int BagShowCondCategory => 0;

	private void init()
	{
	}

	public void clearBreakList()
	{
	}

	public void addBreakList(ulong row)
	{
	}

	public void requestBreakLsit()
	{
	}

	public void requsetCheckMeltDown()
	{
	}

	public void requsetMeltDown(ulong a, ulong b)
	{
	}

	public bool checkMeltState()
	{
		return false;
	}

	public bool canContinueMelt()
	{
		return false;
	}

	public bool checkMeltTimeOut()
	{
		return false;
	}

	public bool checkEquipPositionOpen()
	{
		return false;
	}

	public bool isShowRedMelt()
	{
		return false;
	}

	public void setShowRedMelt()
	{
	}

	private void sdkEventMelt(string result, int reason, ulong a, ulong b, int c)
	{
	}

	public string getEquipPic(int position)
	{
		return null;
	}

	public List<LocalSave.EquipOne> GetDragonsCanCombine()
	{
		return null;
	}

	public bool haveCanCombineDragon()
	{
		return false;
	}

	public bool canJoinCombine(List<LocalSave.EquipOne> list, LocalSave.EquipOne current)
	{
		return false;
	}

	private int GetCountSameEquipId(List<LocalSave.EquipOne> list, LocalSave.EquipOne me)
	{
		return 0;
	}

	public Dictionary<string, int> combineNeedDict_BreakType3(int equipid)
	{
		return null;
	}

	private Dictionary<string, int> combineNeedDict_BreakType3(LocalSave.EquipOne me)
	{
		return null;
	}

	private Dictionary<string, int> combineHaveDict_BreakType3(List<LocalSave.EquipOne> list, LocalSave.EquipOne me)
	{
		return null;
	}

	public void requestDragonCombine(List<ulong> list)
	{
	}

	public void requestDragonCombineBatch(List<ulong[]> list, IEnumerable<int> choosed)
	{
	}

	public int GetDragonsMaxSkillLevel()
	{
		return 0;
	}

	public int GetDragonsMaxLevel()
	{
		return 0;
	}

	public int GetDragonsRarity(int rarity)
	{
		return 0;
	}

	public int GetDragonsQuality(int quality)
	{
		return 0;
	}

	public List<LocalSave.ExcOutData> GetExchangeList_PVE()
	{
		return null;
	}

	public bool isOpenEquipCast()
	{
		return false;
	}

	public List<LocalSave.EquipOne> getCastEquipList(int position, int quality, int ratity)
	{
		return null;
	}

	public void requestEquipCast(int tid, List<ulong> rowIds, Action<CRespEquipSSComposite, int> action = null)
	{
	}

	public bool isHaveEquipCastOne(int equipid)
	{
		return false;
	}

	public int getEquipCastMaxOne(int equipid)
	{
		return 0;
	}

	public int getEquipCastShowId()
	{
		return 0;
	}

	public bool canEquipCasting(int equipid)
	{
		return false;
	}

	public void requestEquipDownLevel(ulong rowid)
	{
	}

	public void requestEquipDownQuality(ulong rowid)
	{
	}

	public bool isCanEquipDownLevel(LocalSave.EquipOne e)
	{
		return false;
	}

	public bool isCanEquipDownQuality(LocalSave.EquipOne e)
	{
		return false;
	}

	public List<CommonMatIdData> GetEquipCommonMat(int equipid)
	{
		return null;
	}

	private List<CommonMatIdData> findEquipCommonMat(int equipid)
	{
		return null;
	}

	private List<CommonMatIdData> GetCommonMatId(int position, int quality, int rarity, int index)
	{
		return null;
	}

	public int GetEquipCommonMatCount(int equipid)
	{
		return 0;
	}

	public void EquipOneItemWithBPAndTalent(PropOneEquip item)
	{
	}

	public bool isOpenEquipS()
	{
		return false;
	}

	public void requestEquipS(int type, Action<bool> callback = null)
	{
	}

	public int GetOneBasicEquipID(int pos)
	{
		return 0;
	}

	public bool EquipSUpOpen()
	{
		return false;
	}

	public void SetEquipSUpCountToNextGuarantee(ushort count)
	{
	}

	public ushort GetEquipSUpCountToNextGuarantee()
	{
		return 0;
	}

	public List<LocalSave.EquipOne> GetEquipsByType(int type)
	{
		return null;
	}

	public List<LocalSave.EquipOne> GetEquipsByType(List<int> types)
	{
		return null;
	}

	public bool isShowBag()
	{
		return false;
	}

	public void setShowBag(bool show)
	{
	}

	public bool isShowBagSubTab(int tab)
	{
		return false;
	}

	public void setShowBagSubTab(int tab, bool show)
	{
	}

	public bool isShowBagTab2Type(int type)
	{
		return false;
	}

	public void setShowBagTab2Type(int type, bool show)
	{
	}

	public bool isHaveNewInBag(int tab)
	{
		return false;
	}

	public bool isRedPoint_Bag()
	{
		return false;
	}

	public float GetEquipLevelDropRatio(SelfAttributeData attributeData, int propType)
	{
		return 0f;
	}
}
