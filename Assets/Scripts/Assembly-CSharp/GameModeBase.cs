using System;
using System.Collections.Generic;
using TableTool;

public abstract class GameModeBase
{
	public enum SkillType
	{
		SkillType_Invalid = 0,
		SkillType_Equip = 1,
		SkillType_Gem = 2,
		SkillType_MonsterBattle = 3,
		SkillType_Skin = 4,
		SkillType_Star = 5,
		SkillType_Extra = 6,
		SkillType_Dragon = 7,
		SkillType_Refine = 8,
		SkillType_Relics = 9,
		SkillType_SLG = 10,
		SkillType_Manor = 11,
		SkillType_HeadAndFrame = 12,
		SkillType_ImprintTalent = 13,
		SkillType_Wing = 14,
		SkillType_Artifact = 15
	}

	public class InitialAttr
	{
		public int Speed;

		public int HP;

		public int RotateSpeed;

		public int BodyAttack;

		public int CritRateResist;

		public int CritValueResist;

		public InitialAttr(Character_Char chardata)
		{
		}
	}

	public abstract IStageLayerManager StageChapterMgr { get; }

	public virtual int GetSoulPointMaxDrop => 0;

	public virtual int ManorMatMax => 0;

	public virtual int FountainUseMax => 0;

	public virtual int FountainUpgradeMax => 0;

	public virtual float HittedInterval => 0f;

	public GameModeBase()
	{
	}

	public abstract string[] GetMonsterTmxAttributes();

	public abstract string[] GetMapAttributes();

	public virtual Dictionary<string, Goods_goods.GoodData> GetHellMonsterAttributes()
	{
		return null;
	}

	public virtual int GetHellEnvironment()
	{
		return 0;
	}

	public virtual int[] GetHellStageInfos()
	{
		return null;
	}

	public abstract string[] GetTmxIds(int roomid, int roomcount);

	public abstract int GetMaxLayer();

	public abstract long GetMapStandardDefence();

	public virtual float GetGoldRatio()
	{
		return 0f;
	}

	public virtual int GetEquipMaxDrop()
	{
		return 0;
	}

	public virtual int GetMPMaxDrop()
	{
		return 0;
	}

	public virtual int GetExp()
	{
		return 0;
	}

	public abstract string[] GetAdTurns();

	public abstract Shop_MysticShopShow GetMysticShopShow(int stage);

	public abstract int GetMysticShopType();

	public abstract List<Shop_MysticShop> GetMysticShopData(int shoptype);

	public abstract int GetAdMysticShopType();

	public virtual int GetEquipDropID(int stage)
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetScroll(EntityType type)
	{
		return null;
	}

	public virtual int GetScrollMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetStone(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetBloodStone(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetBloodStone(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetStoneMaxDrop()
	{
		return 0;
	}

	public virtual int GetBloodStoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetSkillStone(EntityType type)
	{
		return null;
	}

	public virtual int GetSkillStoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetFetterBadge(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetFetterBadge(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetFetterBadgeMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct4thItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct4thItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetAct4thItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetCommonItem(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetCommonItem(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetCommonItemMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct4thExchangeItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct4thExchangeItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetAct4thExchangeItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetWishCoin(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetWishCoin(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetWishCoinMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetRuneStone(EntityType type)
	{
		return null;
	}

	public virtual int GetRuneStoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetCookie(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetCookie(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetCookieMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetSoulStone(EntityType type)
	{
		return null;
	}

	public virtual int GetSoulStoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAdventureCoin(EntityType type)
	{
		return null;
	}

	public virtual int GetAdventureCoinMaxDrop()
	{
		return 0;
	}

	public virtual int GetHonorStoneMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetLoupe(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetLoupe(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetLoupeMaxDrop()
	{
		return 0;
	}

	public virtual int GetJewelDropID()
	{
		return 0;
	}

	public virtual int GetJewelRate()
	{
		return 0;
	}

	public virtual int GetJewelDropRateRateMax()
	{
		return 0;
	}

	public virtual float GetSoulPointRatio()
	{
		return 0f;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetMagicStone(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetMagicStone(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetMagicStoneMax()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetDragonCoin(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetDragonCoin(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetDragonCoinMax()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetStarLightStone(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GeStarLightStone(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetStarLightStoneMax()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetManorMat(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetManorMat(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetModstone(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetModstone(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetModstoneMax()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetEquipQuintessenceItem(EntityType type)
	{
		return null;
	}

	public virtual int GetEquipQuintessenceMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetPetLevelUpItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetPetLevelUpItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetPetLevelUpItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetPetExchangeItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetPetExchangeItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetPetExchangeItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetArtifactExchangeItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetArtifactExchangeItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetArtifactExchangeItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintLevelUpItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintLevelUpItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetImprintLevelUpItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintExchangeItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintExchangeItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetImprintExchangeItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintStoneItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetImprintStoneItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetImprintStoneItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetWingLevelUpItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetWingLevelUpItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetWingLevelUpItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct5DonateItems(EntityType type)
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetAct5DonateItems(EntityType type, Func<float> func)
	{
		return null;
	}

	public virtual int GetAct5DonateItemsMaxDrop()
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetNewPlay125BagCoinItem(EntityType type)
	{
		return null;
	}

	public virtual int GetNewPlay125BagCoinMaxDrop()
	{
		return 0;
	}

	public virtual DropManager.DropData GetDropData()
	{
		return null;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetActivityProp(EntityType type)
	{
		return null;
	}

	public virtual int GetActivityPropMaxDrop()
	{
		return 0;
	}

	public virtual int GetDropDataGold(Soldier_soldier data)
	{
		return 0;
	}

	public virtual int GetDropDataEquipExp(Soldier_soldier data)
	{
		return 0;
	}

	public virtual List<Stage_Level_stagechapterModel.EquipExpRandData> GetDropById(int id, EntityType type, Func<float> func = null)
	{
		return null;
	}

	public int GetMaxDropById(LocalSave.EquipOne one)
	{
		return 0;
	}

	public virtual int GetMaxDropById(int id)
	{
		return 0;
	}

	public virtual float GetActivityAttackRatio()
	{
		return 0f;
	}

	public virtual float GetActivityHPRatio()
	{
		return 0f;
	}

	public virtual float GetActivityBodyHitRatio()
	{
		return 0f;
	}

	public virtual float GetActivityTrapHitRatio()
	{
		return 0f;
	}

	public virtual bool NeedRemoveAfterRandom()
	{
		return false;
	}

	public void AddDmgCountWrapper(EntityBase form, EntityBase target, long gotdmg, HitStruct data)
	{
	}

	public virtual void AddDmgCount(EntityBase form, EntityBase target, long gotdmg)
	{
	}

	public virtual ulong GetDmgCount(EntityBase whomake)
	{
		return 0uL;
	}

	public virtual void RestDmgCount()
	{
	}

	protected virtual void OnAfterSetPlayerPos(EntityHero player)
	{
	}

	protected virtual void OnSetHeroDropCtrl(EntityHero player)
	{
	}

	public virtual void CreatePlayer()
	{
	}

	protected virtual void CheckBattleIn(ref int playerid, ref PlayerCharacter_Character data, ref int charid)
	{
	}

	protected virtual PlayerCharacter_Character GetPlayerCharacterCharacterData()
	{
		return null;
	}

	protected virtual int GetCharacterId()
	{
		return 0;
	}

	protected virtual void OnCreatePlayer(EntityBase entity)
	{
	}

	protected virtual void InitBabies()
	{
	}

	public virtual string[] GetTmxIds(int line, int roomid, int roomcount)
	{
		return null;
	}

	public virtual int GetMappingSkill(int skill)
	{
		return 0;
	}

	public virtual int GetMappingWeapon(int weaponId)
	{
		return 0;
	}

	public virtual string GetMappingMapPrefix(string prefix, string name = null)
	{
		return null;
	}

	public virtual bool CanLearnSkills(in SkillType type, out List<int> ids, EntityHero hero)
	{
		ids = null;
		return false;
	}

	public virtual bool CanAddExtraAttributes(List<string> attrs)
	{
		return false;
	}

	protected void GetStarSkill(EntityHero hero, List<int> ids)
	{
	}

	public virtual bool BattleInCanCreateEvent(int id)
	{
		return false;
	}

	public void CreateAssistanter(int id, long hp = long.MaxValue)
	{
	}

	public virtual InitialAttr GetInitialAttr(EntityType type, int charId)
	{
		return null;
	}

	public virtual bool CanWearWing()
	{
		return false;
	}

	public virtual void CheckHeroPos()
	{
	}
}
