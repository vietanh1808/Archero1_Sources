using System;
using System.Collections.Generic;
using DailyActivity;
using TableTool;
using UnityEngine;

public class GameModeDaily : GameModeBase
{
	public enum eDailyMode
	{
		eFar = 1,
		eNear = 2,
		eSurvival = 3,
		Count = 4
	}

	private LocalModelManager _tableMgr;

	private HoldManager _holdMgr;

	private ReleaseManager _releaseMgr;

	private BattleModuleData _battleData;

	private MapCreator _mapCreator;

	private IDailyLevelsManager _dailyData;

	private bool _daily130BossRoomStrategySkillLearned;

	private int PARTNER_MAX;

	public Vector3 HeroPosition { get; set; }

	public override IStageLayerManager StageChapterMgr => null;

	public override float HittedInterval => 0f;

	public GameModeDaily(IDailyLevelsManager dailyData)
	{
	}

	~GameModeDaily()
	{
	}

	public override long GetMapStandardDefence()
	{
		return 0L;
	}

	public override string[] GetMapAttributes()
	{
		return null;
	}

	public override Shop_MysticShopShow GetMysticShopShow(int stage)
	{
		return null;
	}

	public override int GetMysticShopType()
	{
		return 0;
	}

	public override List<Shop_MysticShop> GetMysticShopData(int shoptype)
	{
		return null;
	}

	public override int GetAdMysticShopType()
	{
		return 0;
	}

	public override int GetEquipDropID(int stage)
	{
		return 0;
	}

	public override float GetGoldRatio()
	{
		return 0f;
	}

	public override int GetEquipMaxDrop()
	{
		return 0;
	}

	public override int GetExp()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetScroll(EntityType type)
	{
		return null;
	}

	public override int GetScrollMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetStone(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetBloodStone(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetBloodStone(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetStoneMaxDrop()
	{
		return 0;
	}

	public override int GetBloodStoneMaxDrop()
	{
		return 0;
	}

	public override int GetCookieMaxDrop()
	{
		return 0;
	}

	public override int GetSoulStoneMaxDrop()
	{
		return 0;
	}

	public override int GetRuneStoneMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetRuneStone(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetCookie(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetCookie(EntityType type, Func<float> func)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetSoulStone(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetAdventureCoin(EntityType type)
	{
		return null;
	}

	public override int GetAdventureCoinMaxDrop()
	{
		return 0;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetLoupe(EntityType type)
	{
		return null;
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetLoupe(EntityType type, Func<float> func)
	{
		return null;
	}

	public override int GetLoupeMaxDrop()
	{
		return 0;
	}

	public override int GetHonorStoneMaxDrop()
	{
		return 0;
	}

	public override int GetJewelDropID()
	{
		return 0;
	}

	public override int GetJewelRate()
	{
		return 0;
	}

	public override int GetJewelDropRateRateMax()
	{
		return 0;
	}

	public override int GetWishCoinMaxDrop()
	{
		return 0;
	}

	public override int GetMaxLayer()
	{
		return 0;
	}

	public override string[] GetTmxIds(int roomid, int roomcount)
	{
		return null;
	}

	public override string[] GetTmxIds(int line, int roomid, int roomcount)
	{
		return null;
	}

	public override string[] GetMonsterTmxAttributes()
	{
		return null;
	}

	public override string[] GetAdTurns()
	{
		return null;
	}

	public override DropManager.DropData GetDropData()
	{
		return null;
	}

	public override int GetDropDataGold(Soldier_soldier data)
	{
		return 0;
	}

	public override int GetDropDataEquipExp(Soldier_soldier data)
	{
		return 0;
	}

	public override float GetActivityHPRatio()
	{
		return 0f;
	}

	public override float GetActivityAttackRatio()
	{
		return 0f;
	}

	public override float GetActivityBodyHitRatio()
	{
		return 0f;
	}

	public override float GetActivityTrapHitRatio()
	{
		return 0f;
	}

	public override bool CanLearnSkills(in SkillType type, out List<int> ids, EntityHero hero)
	{
		ids = null;
		return false;
	}

	public override bool CanAddExtraAttributes(List<string> attrs)
	{
		return false;
	}

	protected override void OnCreatePlayer(EntityBase entity)
	{
	}

	private void OnDaily130GotoNextRoomAfter(RoomGenerateBase.Room room)
	{
	}

	private void OnDaily130WaveCreateStart(int waveIndex, RoomGenerateBase.RoomType roomType, int totalWaveCount, int intervalSeconds)
	{
	}

	public void ChangeModelBySkinId(EntityBase entity, in int id)
	{
	}

	protected override void InitBabies()
	{
	}

	private void InitMazeEquipBabies()
	{
	}

	public EntityHero CreatePlayer(int id, long energy)
	{
		return null;
	}

	public void CreatePartner(int id, long energy, long hp = long.MaxValue)
	{
	}

	public override List<Stage_Level_stagechapterModel.EquipExpRandData> GetActivityProp(EntityType type)
	{
		return null;
	}

	public override int GetActivityPropMaxDrop()
	{
		return 0;
	}

	public override int GetMappingWeapon(int weaponId)
	{
		return 0;
	}

	public override string GetMappingMapPrefix(string prefix, string name = null)
	{
		return null;
	}

	public override bool BattleInCanCreateEvent(int id)
	{
		return false;
	}

	protected override void OnAfterSetPlayerPos(EntityHero player)
	{
	}

	public override InitialAttr GetInitialAttr(EntityType type, int charId)
	{
		return null;
	}

	public override bool CanWearWing()
	{
		return false;
	}

	protected override void OnSetHeroDropCtrl(EntityHero player)
	{
	}

	protected override int GetCharacterId()
	{
		return 0;
	}

	protected override PlayerCharacter_Character GetPlayerCharacterCharacterData()
	{
		return null;
	}

	protected override void CheckBattleIn(ref int playerid, ref PlayerCharacter_Character data, ref int charid)
	{
	}
}
