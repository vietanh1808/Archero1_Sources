using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using XLua;

public class CharacterManager : CInstance<CharacterManager>
{
	public const int SENIOR_GRADE = 4;

	public const int trainMaterialId = 35001;

	public const int trainMaterialId3 = 31014;

	public const int TrainMaxStar = 8;

	public Dictionary<int, int[]> attackTrain;

	public Dictionary<int, int[]> hpTrain;

	public Dictionary<int, int[]> attackStar;

	public Dictionary<int, int[]> hpStar;

	public const string ASSIST_LOG_TAG = "[英雄助战]";

	private List<Goods_goods.GoodData> m_listUnexcuteAssistAttrs;

	public int chooseHeroExId;

	public int haveExCount_Week;

	public Dictionary<int, int> heroExDict;

	public const int MaxAssistLevel = 100;

	private int AssistNeedUserLevel;

	private int AssistNeedLevel;

	private int AssistNeedHeroCount;

	private int AssistNeedHeroLevel;

	private int AssistNeedHeroStar;

	private static DelegateBridge _c__Hotfix0_ctor;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_get_UnexcuteAssistAttrs;

	private static DelegateBridge __Hotfix0_InitAssistAttr;

	private static DelegateBridge __Hotfix0_CanKeepHeroAssistAttr;

	private static DelegateBridge __Hotfix0_CanKeepCallHeroButton;

	private static DelegateBridge __Hotfix0_CanKeepHeroAssistSkills;

	private static DelegateBridge __Hotfix0_GetHeroCount;

	private static DelegateBridge __Hotfix0_getCharacterOne;

	private static DelegateBridge __Hotfix0_getHeroFragmentCount;

	private static DelegateBridge __Hotfix0_getTrainMaterialCount;

	private static DelegateBridge __Hotfix0_get_getTrainMaterial3Count;

	private static DelegateBridge __Hotfix0_isCanUnlockByFragment;

	private static DelegateBridge __Hotfix0_isEnoughUnlockHero;

	private static DelegateBridge __Hotfix0_isUnlockHero;

	private static DelegateBridge __Hotfix0_GetHeroId;

	private static DelegateBridge __Hotfix0_buyHeroFragment;

	private static DelegateBridge __Hotfix0_getRewardHero;

	private static DelegateBridge __Hotfix0_isOpenTrain;

	private static DelegateBridge __Hotfix1_isOpenTrain;

	private static DelegateBridge __Hotfix0_getMaxStarArrive;

	private static DelegateBridge __Hotfix0_getTrainAdd;

	private static DelegateBridge __Hotfix0_getTrainStarAdd;

	private static DelegateBridge __Hotfix0_getTrainSkill;

	private static DelegateBridge __Hotfix0_getTrainSkillOne;

	private static DelegateBridge __Hotfix0_getTrainTimeValue;

	private static DelegateBridge __Hotfix0_getHeroTrainData;

	private static DelegateBridge __Hotfix0_isHeroCanTrain;

	private static DelegateBridge __Hotfix0_isCanTrain;

	private static DelegateBridge __Hotfix1_isCanTrain;

	private static DelegateBridge __Hotfix0_getTrainData;

	private static DelegateBridge __Hotfix0_getTrainStar;

	private static DelegateBridge __Hotfix0_GetCharTrainMaxStar;

	private static DelegateBridge __Hotfix0_getCharacterStar;

	private static DelegateBridge __Hotfix0_getCharacterLevel;

	private static DelegateBridge __Hotfix0_GetCharacterSkillId;

	private static DelegateBridge __Hotfix0_GetCharacterStarSkillId;

	private static DelegateBridge __Hotfix0_GetCharacterInitSkillId;

	private static DelegateBridge __Hotfix0_getSkillIdDisplay;

	private static DelegateBridge __Hotfix0_getUnlockTrainAttr;

	private static DelegateBridge __Hotfix0_getAllHeroUnlockTrainAttr;

	private static DelegateBridge __Hotfix0_getAllHeroUnlockTrainAttrNotMe;

	private static DelegateBridge __Hotfix0_isHaveHeroFragment;

	private static DelegateBridge __Hotfix0_getHeroIdFromSkin;

	private static DelegateBridge __Hotfix0_haveUnLockHead;

	private static DelegateBridge __Hotfix0_CheckIfDisplay;

	private static DelegateBridge __Hotfix1_CheckIfDisplay;

	private static DelegateBridge __Hotfix0_getHeroIdByFragment;

	private static DelegateBridge __Hotfix0_GetExHaveInDict;

	private static DelegateBridge __Hotfix0_GetHeroExList;

	private static DelegateBridge __Hotfix0_GetExMaxLimit;

	private static DelegateBridge __Hotfix0_GetExWeekLimit;

	private static DelegateBridge __Hotfix0_GetExNeedStar_Left;

	private static DelegateBridge __Hotfix0_GetExGetStar_Right;

	private static DelegateBridge __Hotfix0_GetExRandomList;

	private static DelegateBridge __Hotfix0_GetExList_Hero;

	private static DelegateBridge __Hotfix0_requestHeroExchange;

	private static DelegateBridge __Hotfix0_get_Assist_NeedHeroLevel;

	private static DelegateBridge __Hotfix0_get_Assist_NeedHeroStar;

	private static DelegateBridge __Hotfix0_parseAssistCondition;

	private static DelegateBridge __Hotfix0_GetHeroUnlockCount;

	private static DelegateBridge __Hotfix0_isOpenAssistBasic;

	private static DelegateBridge __Hotfix0_isOpenAssist;

	private static DelegateBridge __Hotfix0_GetAssistCanHeroList;

	private static DelegateBridge __Hotfix0_ShowEffectsMain_Assist;

	private static DelegateBridge __Hotfix0_Assist_MainEffectShow;

	private static DelegateBridge __Hotfix0_ShowEffectsAssist_Assist;

	private static DelegateBridge __Hotfix0_Assist_IsHaveHeroOpenFunc;

	private static DelegateBridge __Hotfix0_Assist_IsOpenCurrentHero;

	private static DelegateBridge __Hotfix0_Assist_GetOpenHeroId;

	private static DelegateBridge __Hotfix0_Assist_EffectAll;

	private static DelegateBridge __Hotfix0_isCanAssistLevelUp;

	private static DelegateBridge __Hotfix0_Assist_GetHeroList;

	private static DelegateBridge __Hotfix0_Assist_GetHeroListByHeroId;

	private static DelegateBridge __Hotfix0_GetAssistEffect_Battle;

	private static DelegateBridge __Hotfix0_GetAssistSkill_Battle;

	private static DelegateBridge __Hotfix0_requestHero;

	private static DelegateBridge __Hotfix0_Assist_isHaveEmptyPos;

	private static DelegateBridge __Hotfix0_Assist_CanLevelUp;

	private static DelegateBridge __Hotfix0_GetLevelDropDataOne;

	private static DelegateBridge __Hotfix0_GetHeroTrainDropList;

	public List<Goods_goods.GoodData> UnexcuteAssistAttrs => null;

	public int getTrainMaterial3Count => 0;

	public int Assist_NeedHeroLevel => 0;

	public int Assist_NeedHeroStar => 0;

	public void init()
	{
	}

	public void InitAssistAttr(SelfAttributeData selfAttributeData, int heroid)
	{
	}

	public bool CanKeepHeroAssistAttr()
	{
		return false;
	}

	public bool CanKeepCallHeroButton()
	{
		return false;
	}

	public bool CanKeepHeroAssistSkills()
	{
		return false;
	}

	public int GetHeroCount()
	{
		return 0;
	}

	public LocalSave.CharacterOne getCharacterOne(int charid)
	{
		return null;
	}

	public int getHeroFragmentCount(int charid)
	{
		return 0;
	}

	public int getTrainMaterialCount()
	{
		return 0;
	}

	public bool isCanUnlockByFragment(int charid)
	{
		return false;
	}

	public bool isEnoughUnlockHero(int charid)
	{
		return false;
	}

	public bool isUnlockHero(int charid)
	{
		return false;
	}

	public int GetHeroId(int equipid)
	{
		return 0;
	}

	public void buyHeroFragment(int charid)
	{
	}

	public void getRewardHero(int charid)
	{
	}

	public bool isOpenTrain(int charid)
	{
		return false;
	}

	public bool isOpenTrain()
	{
		return false;
	}

	public int getMaxStarArrive()
	{
		return 0;
	}

	public void getTrainAdd(int charid, int star, ref int attack, ref int hp)
	{
	}

	public void getTrainStarAdd(int charid, int star, ref int attack, ref int hp)
	{
	}

	public string getTrainSkill(int charid, int star)
	{
		return null;
	}

	public string getTrainSkillOne(int charid, int star)
	{
		return null;
	}

	public int getTrainTimeValue(int charid, int star)
	{
		return 0;
	}

	public HeroTrainData getHeroTrainData(int charid)
	{
		return null;
	}

	public bool isHeroCanTrain()
	{
		return false;
	}

	public bool isCanTrain(int charid)
	{
		return false;
	}

	public int isCanTrain(int charid, ref int value)
	{
		return 0;
	}

	protected PlayerCharacter_Train getTrainData(int tid)
	{
		return null;
	}

	public int getTrainStar(int tid)
	{
		return 0;
	}

	public int GetCharTrainMaxStar(int charid)
	{
		return 0;
	}

	public int getCharacterStar(int charid)
	{
		return 0;
	}

	public int getCharacterLevel(int charid)
	{
		return 0;
	}

	public int GetCharacterSkillId(int id)
	{
		return 0;
	}

	public int GetCharacterStarSkillId(int id, int star)
	{
		return 0;
	}

	public int GetCharacterInitSkillId(int id)
	{
		return 0;
	}

	public int getSkillIdDisplay(int charid)
	{
		return 0;
	}

	public List<Goods_goods.GoodData> getUnlockTrainAttr(int charid)
	{
		return null;
	}

	public List<Goods_goods.GoodData> getAllHeroUnlockTrainAttr()
	{
		return null;
	}

	public List<Goods_goods.GoodData> getAllHeroUnlockTrainAttrNotMe(int charid)
	{
		return null;
	}

	public bool isHaveHeroFragment()
	{
		return false;
	}

	public int getHeroIdFromSkin(int skin)
	{
		return 0;
	}

	public bool haveUnLockHead(int headid)
	{
		return false;
	}

	public void CheckIfDisplay(List<Drop_DropModel.DropData> list)
	{
	}

	public bool CheckIfDisplay(CRewardItem item)
	{
		return false;
	}

	public int getHeroIdByFragment(int fid)
	{
		return 0;
	}

	public int GetExHaveInDict(int heroid)
	{
		return 0;
	}

	public List<HeroFragChooseData> GetHeroExList()
	{
		return null;
	}

	public int GetExMaxLimit(int star)
	{
		return 0;
	}

	public int GetExWeekLimit()
	{
		return 0;
	}

	public int GetExNeedStar_Left()
	{
		return 0;
	}

	public int GetExGetStar_Right()
	{
		return 0;
	}

	public List<HeroFragExItemData> GetExRandomList()
	{
		return null;
	}

	public List<HeroFragExItemData> GetExList_Hero(int heroid)
	{
		return null;
	}

	public void requestHeroExchange(int type, int needId, int needCount, int giveId)
	{
	}

	private void parseAssistCondition()
	{
	}

	private int GetHeroUnlockCount()
	{
		return 0;
	}

	private bool isOpenAssistBasic()
	{
		return false;
	}

	public bool isOpenAssist(int heroid)
	{
		return false;
	}

	public List<int> GetAssistCanHeroList(int heroid)
	{
		return null;
	}

	public List<string> ShowEffectsMain_Assist(int heroid)
	{
		return null;
	}

	public List<HeroAttrItem.ShowData> Assist_MainEffectShow(int heroid)
	{
		return null;
	}

	public List<HeroAttrItem.ShowData> ShowEffectsAssist_Assist(int heroid)
	{
		return null;
	}

	public bool Assist_IsHaveHeroOpenFunc()
	{
		return false;
	}

	public bool Assist_IsOpenCurrentHero()
	{
		return false;
	}

	public int Assist_GetOpenHeroId()
	{
		return 0;
	}

	public List<HeroAssistAttrItem.ShowData> Assist_EffectAll(int heroid)
	{
		return null;
	}

	public bool isCanAssistLevelUp(int heroid)
	{
		return false;
	}

	public List<int> Assist_GetHeroList()
	{
		return null;
	}

	public List<int> Assist_GetHeroListByHeroId(int id)
	{
		return null;
	}

	public List<string> GetAssistEffect_Battle(int heroid)
	{
		return null;
	}

	public List<string> GetAssistSkill_Battle(int heroid, bool includeAssistSkills = true)
	{
		return null;
	}

	public void requestHero(int type, int heroid, Action<bool> callback = null)
	{
	}

	public bool Assist_isHaveEmptyPos()
	{
		return false;
	}

	public bool Assist_CanLevelUp()
	{
		return false;
	}

	public HeroTrainLevelDropData GetLevelDropDataOne(int charid)
	{
		return null;
	}

	public List<HeroTrainLevelDropData> GetHeroTrainDropList()
	{
		return null;
	}
}
