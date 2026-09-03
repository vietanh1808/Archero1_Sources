using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic
{
	public enum EGameState
	{
		Main = 0,
		Gaming = 1,
		Pause = 2,
		Over = 3
	}

	private class AnimationData
	{
		public AnimationCurve[] curves;

		public AnimationData(int id1, int id2, int id3)
		{
		}
	}

	private static int bPause;

	private static EGameState GameState;

	private static bool m_bOpenMemOptimization;

	private static bool? m_bDestroyWindowFlag;

	public static bool IfVideoCutMode;

	private static bool _Daily_IfShowDebugInfo;

	public const bool DataSyncOpen = true;

	public const bool BoxDataSync = true;

	private const bool _useobb = true;

	private static bool _checklogin;

	public static bool bInitSuccess;

	public static bool bCheat;

	public static bool bServerMaintain;

	public static int AttributeRandomSeed;

	public const float RoomScaleZ = 1.23f;

	public static int DesignWidth;

	public static int DesignHeight;

	public static int ScreenWidth;

	public static int ScreenHeight;

	public static float ScreenRatio;

	public static int Width;

	public static int Height;

	public static float WidthScale;

	public static float HeightScale;

	public static Vector2 ScreenSize;

	public static float WidthScaleAll;

	private static float _WidthReal;

	private static Vector3 GetCanHit_mePos;

	private static Vector3 GetCanHit_dir;

	private static RaycastHit[] GetCanHit_rayhits;

	private static int GetCanHit_RayLength;

	private static Quaternion GetCanHit_ChildRotate;

	private static float GetCanHit_Angle;

	private static List<Vector2Int> RandomItem_list;

	private static HoldManager _Hold;

	private static ReleaseManager _Release;

	private static bool mInGame;

	private static SelfAttributeData _SelfAttribute;

	private static SelfAttributeData _SelfAttributeDragon;

	private static SelfAttributeData _SelfAttributeOutGame;

	public static bool IsPlayerCreated;

	private static SelfAttributeData _SelfAttributeShowInGame;

	private static int BulletID;

	public static int spaceCount;

	private static Dictionary<HitType, AnimationData> mAnimationList;

	public static Dictionary<EElementType, ElementDataClass> ElementData;

	private static bool __DEBUG_IsTryPlaySkillEnabled;

	private const float HERO_SHOW_OFFSET = 50f;

	public static int HERO_SHOW_COUNT;

	public const string CHAPTER_WAVE_TAG = "[CHAPTER_WAVE_TAG]";

	private static bool? _CanShowOfficialStore;

	private static bool? _CanShowOfficialStorePop;

	private static bool? _CanShowOfficialStoreShopBanner;

	private static bool? _CanShowOfficialStoreBar;

	public const string QualityString = "SettingQuality";

	public static Dictionary<int, int> mQualitys;

	private static int mBeforeWidth;

	public static bool Paused => false;

	public static bool DebugMode => false;

	public static bool OpenMemOptimization
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool DestroyWindowFlag => false;

	public static bool TestPvpSkill { get; set; }

	public static bool UseHabbyMail => false;

	public static bool Daily_IfShowDebugInfo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool Daily_IfDebug => false;

	public static bool UseObb => false;

	public static bool bCheckLogin => false;

	public static float WidthReal
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static HoldManager Hold => null;

	public static ReleaseManager Release => null;

	public static bool InGame => false;

	public static EntityHero Self => null;

	public static EntityHero TDSelf => null;

	public static SelfAttributeData SelfAttribute => null;

	public static SelfAttributeData SelfAttributeDragon => null;

	public static SelfAttributeData SelfAttributeOutGame => null;

	public static SelfAttributeData SelfAttributeShow => null;

	public static SelfAttributeData GetActivity114Data => null;

	public static bool DEBUG_IsTryPlaySkillEnabled => false;

	public static bool IsInDailyTDEntrance { get; set; }

	public static bool EnableNewHeroShow => false;

	private static bool CanShowOfficialStore => false;

	public static bool CanShowOfficialStorePop => false;

	public static bool CanShowOfficialStoreShopBanner => false;

	public static bool CanShowOfficialStoreBar => false;

	public static GameMode AdventureMode
	{
		get
		{
			return (GameMode)0;
		}
		set
		{
		}
	}

	public static int Main_Stage
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int QualityID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static void SetPause(bool pause)
	{
	}

	public static void SetPauseUpdateOnly(bool pause)
	{
	}

	public static void RestPause()
	{
	}

	public static void SetGameState(EGameState state)
	{
	}

	public static void SetCheckLogin(bool value)
	{
	}

	public static bool GetCanMainBattle()
	{
		return false;
	}

	public static string GetCurHeroAssetName(string pModelId)
	{
		return null;
	}

	public static string GetModelPathName(string pModelId)
	{
		return null;
	}

	public static bool IsCurHeroAssetReady(bool pShowWindow = true)
	{
		return false;
	}

	public static bool IsAssetReady(string pAssetPath, bool pShowWindow = true)
	{
		return false;
	}

	public static bool IsOpenUpdate()
	{
		return false;
	}

	public static bool IsNeedUpdate()
	{
		return false;
	}

	public static bool DontNeedUpdate(bool pShowWindow = true)
	{
		return false;
	}

	public static void CheckGameLevelOverCache(Action<bool> callback)
	{
	}

	public static bool check_main_battle()
	{
		return false;
	}

	private static void OnCheckFinish(string groupName, bool ifFinish, int downloadCount, int downloadSize, List<string> downloadList)
	{
	}

	public static void PlayMainBattle()
	{
	}

	public static void PlayBattle_Main()
	{
	}

	public static void PlayCampBattle(int tileId, int zoneId, int tileIndex, BattleType BattleType, int BattleValue, SLGTileVO vo)
	{
	}

	public static void SetCampBattleData(int zoneId, int tileLevel, int slgStageChapterId)
	{
	}

	public static bool TryGetBattleBundleGroup(out string groupName)
	{
		groupName = null;
		return false;
	}

	private static void send_use_key()
	{
	}

	public static void ReqMysticShop()
	{
	}

	public static void SetMagicianShown(bool shown)
	{
	}

	public static bool CanShowMagician(int level)
	{
		return false;
	}

	public static bool CanShowMagicianSweep()
	{
		return false;
	}

	public static void ReqMagician(bool showMask, int type, int cellCount = -1, Action<List<Drop_DropModel.DropData>> action = null)
	{
	}

	public static bool CheckPlayTowerBattle(int towerId)
	{
		return false;
	}

	public static void PlayBattle_Tower(int towerId)
	{
	}

	public static void PlayBattle_EventTower(int towerId, int difficulty)
	{
	}

	public static void PlayBattle_TowerDefense(int levelId = 101)
	{
	}

	public static bool GetCanDailyBattle(int dailyId)
	{
		return false;
	}

	public static bool CheckPlayDailyBattle(int dailyId)
	{
		return false;
	}

	public static bool CheckPlayGuildBattle()
	{
		return false;
	}

	public static void CheckPlayDailyPVP(int dailyId, Action<bool> pFaile)
	{
	}

	public static void PlayBattle_Daily(int dailyId)
	{
	}

	public static void PlayBattle_SailingBag(int id, int type = 1)
	{
	}

	public static void CheckSeasonBattle()
	{
	}

	public static void CheckHardSeasonBattle()
	{
	}

	public static void PlayBattle_Season(GameMode mode = GameMode.eSeason)
	{
	}

	public static void ResetRectTransform(Transform t)
	{
	}

	public static void ResetRectTransform(RectTransform tran)
	{
	}

	public static bool GetCanHit(EntityBase me, EntityBase other)
	{
		return false;
	}

	public static bool CheckLine(EntityBase self, EntityBase other)
	{
		return false;
	}

	public static void RandomItem(EntityBase entity, int range, out float endx, out float endz)
	{
		endx = default;
		endz = default;
	}

	public static void SetHold(HoldManager hold)
	{
	}

	public static void SetRelease(ReleaseManager release)
	{
	}

	public static GameObject EffectGet(string key)
	{
		return null;
	}

	public static GameObject EffectGet(int fxid)
	{
		return null;
	}

	public static void AddEffectToEffectMask(Transform pEffectItem, EntityBase pParent)
	{
	}

	public static bool IsInMapEffect(int id)
	{
		return false;
	}

	public static bool IsInMapEffect(string path)
	{
		return false;
	}

	public static void CacheLoadMapEffect(string path, Action<GameObject> onLoaded)
	{
	}

	public static void CacheLoadMapEffect(int id, Action<GameObject> onLoaded)
	{
	}

	public static bool IsInCloneList(int id)
	{
		return false;
	}

	public static bool IsInCloneList(string path)
	{
		return false;
	}

	public static void CacheLoadEffect(string path, Action<GameObject> onLoaded)
	{
	}

	public static void CacheLoadEffect(int id, Action<GameObject> onLoaded)
	{
	}

	public static void EffectCache(GameObject o)
	{
	}

	public static BulletBase GetBullet(int id)
	{
		return null;
	}

	public static void CacheBullet(int id, BulletBase o)
	{
	}

	public static void ClearBullet(int id)
	{
	}

	public static int GetSkillEffectID(int id)
	{
		return 0;
	}

	public static GameObject Effect_SkillAloneEffect(int id)
	{
		return null;
	}

	public static GameObject Effect_SkillAlone(int id)
	{
		return null;
	}

	public static int GetSkillAloneID(int id)
	{
		return 0;
	}

	public static GameObject Effect_WeaponHandEffect(int id)
	{
		return null;
	}

	public static GameObject Effect_Food(int id)
	{
		return null;
	}

	public static int GetFoodID(int id)
	{
		return 0;
	}

	public static GameObject Effect_BulletCreateEffect(int id)
	{
		return null;
	}

	public static UISortOrder Effect_BoxOpen(int id)
	{
		return null;
	}

	public static UISortOrder Effect_BoxOpen_Charge(int id)
	{
		return null;
	}

	public static UISortOrder Effect_BoxOpen_Equip(int id)
	{
		return null;
	}

	public static GameObject EffectUI_ChangeCharacter(int quality)
	{
		return null;
	}

	public static GameObject EffectUI_HeroSkin(int quality)
	{
		return null;
	}

	public static GameObject EffectUI_MagicBook(int id)
	{
		return null;
	}

	public static GameObject EffectUI_SeniorMagicBook(int id)
	{
		return null;
	}

	public static GameObject EffectUI_BoxTen(int quality)
	{
		return null;
	}

	public static UISortOrder EffectGetSortOrder(int id)
	{
		return null;
	}

	public static GameObject EntityGet(string key)
	{
		return null;
	}

	public static void EntityCache(GameObject o, int maxcount)
	{
	}

	public static GameObject HoldGet(string key)
	{
		return null;
	}

	public static void HoldCache(GameObject o)
	{
	}

	public static void PlayEffect(int fxId, Vector3 position)
	{
	}

	public static void SetInGame(bool gaming)
	{
	}

	public static EntityBase FindTarget(EntityBase self)
	{
		return null;
	}

	public static EntityBase GetTarget(EntityBase self)
	{
		return null;
	}

	public static void ClearSelfAttribute()
	{
	}

	public static int GetBulletID()
	{
		return 0;
	}

	public static bool IsCanTriggerHero(Collider o)
	{
		return false;
	}

	public static bool IsCanTriggerHero(GameObject o)
	{
		return false;
	}

	public static bool IsCanTriggerEntity(Collider o)
	{
		return false;
	}

	public static bool IsCanTriggerEntity(GameObject o)
	{
		return false;
	}

	public static bool IsSameTeam(EntityBase me, EntityBase other)
	{
		return false;
	}

	public static bool IsSameTeam(BulletBase bullet, EntityBase entity)
	{
		return false;
	}

	private static int GetTeam(BulletBase bullet)
	{
		return 0;
	}

	public static int GetTeam(EntityBase entity)
	{
		return 0;
	}

	public static int Random(int min, int max)
	{
		return 0;
	}

	public static float Random(float min, float max)
	{
		return 0f;
	}

	public static long Random(long min, long max)
	{
		return 0L;
	}

	public static List<BattleDropData> GetTDStoneList(int exp)
	{
		return null;
	}

	public static List<BattleDropData> GetSLGTalentList(int exp)
	{
		return null;
	}

	public static List<BattleDropData> GetSLGCampTalentList(int exp)
	{
		return null;
	}

	public static List<BattleDropData> GetExpList(int exp, Func<FoodType, float> RatioFunc = null)
	{
		return null;
	}

	public static List<BattleDropData> GetPureGoldList(int pureGold)
	{
		return null;
	}

	public static List<BattleDropData> GetSoulPointList(int cnt)
	{
		return null;
	}

	private static string calculateTempSpace()
	{
		return null;
	}

	public static long GetMaxHP(int entityid, bool isboss, MapCreator.HeroModeData.SOLIDER_TYPE type)
	{
		return 0L;
	}

	private static long get_max_hp_internal(int entityid, bool isboss, MapCreator.HeroModeData.SOLIDER_TYPE type)
	{
		return 0L;
	}

	public static AnimationCurve GetHPChangerAnimation(HitType type, int curve)
	{
		return null;
	}

	public static EElementType GetElement(string value)
	{
		return EElementType.eNone;
	}

	public static int GetStage(int stage)
	{
		return 0;
	}

	public static void ChangeAccount(bool changeplayer)
	{
	}

	public static void DeleteAccount()
	{
	}

	public static void ClearCache()
	{
	}

	public static void CheckDelAccount()
	{
	}

	public static bool IsMultipleOnline()
	{
		return false;
	}

	public static bool IsInPvp()
	{
		return false;
	}

	public static EntityBase GetAttackTarget(EntityBase character, EntityBase source = null)
	{
		return null;
	}

	public static void SetDEBUG_IsTryPlaySkillEnabled(bool enabled)
	{
	}

	public static bool IsMeleePartBody(int partId)
	{
		return false;
	}

	public static int GetLocalWeaponHandId(int weaponId)
	{
		return 0;
	}

	public static bool CanSaveInRealTime()
	{
		return false;
	}

	public static bool CanSaveGoldInRealTime()
	{
		return false;
	}

	public static bool IsOddUserId()
	{
		return false;
	}

	public static HeroShow GetHeroShow(string Tag, int type = 1)
	{
		return null;
	}

	public static HeroShow GetWingShow(string Tag)
	{
		return null;
	}

	public static void ResetHeroShow(HeroShow heroShow, float size = 1.88f)
	{
	}

	public static void RefreshHeroShowUI(HeroShow heroShow, GameObject goHeroShow, RawImage img_hero)
	{
	}

	public static void RefreshPetShowUI(HeroShow heroShow, GameObject goHeroShow, RawImage img_hero, float scale = 1f, float offy = 0f, float rotaY = 0f)
	{
	}

	public static void RefreshWingShowUI(HeroShow heroShow, GameObject goHeroShow, RawImage img_hero, float scale = 1f, Vector3 pos = default(Vector3), float rotaY = 0f, int star = 0)
	{
	}

	public static void Refresh3DShowUI(HeroShow heroShow, GameObject goHeroShow, RawImage img_hero, float scale = 1f, float px = 0f, float py = 0f, float pz = 0f, float rx = 0f, float ry = 0f, float rz = 0f)
	{
	}

	public static bool IsGameType5ByStage(int stage)
	{
		return false;
	}

	public static bool IsGameType5()
	{
		return false;
	}

	public static bool IsInvalidRoomIdInGameType5(int roomId)
	{
		return false;
	}

	public static int GetMaxLayerInGameType5()
	{
		return 0;
	}

	public static bool CanSaveCache()
	{
		return false;
	}

	static GameLogic()
	{
	}

	public static long GetNewSlotoutValue(long value, Skill_slotout data)
	{
		return 0L;
	}

	public static GameObject PlayEffect(string path, Transform parent)
	{
		return null;
	}

	public static GameObject PlayEffect(string path, Vector3 pos)
	{
		return null;
	}

	public static void SendHit_Thunder(EntityBase target, EntityBase enemy, float hit)
	{
	}

	public static float GetThunderPercent(EntityBase target, EntityBase entity)
	{
		return 0f;
	}

	public static float GetFirePercent(EntityBase target, EntityBase entity)
	{
		return 0f;
	}

	public static float GetBulletDamageTakenPercent(int weaponId, float flySwordPercent, float meteorPercent, float starPercent)
	{
		return 0f;
	}

	private static bool IsFlySwordWeapon(int weaponId)
	{
		return false;
	}

	private static bool IsMeteorWeapon(int weaponId)
	{
		return false;
	}

	private static bool IsStarWeapon(int weaponId)
	{
		return false;
	}

	public static float GetElementPercent(EntityBase target, EntityBase entity)
	{
		return 0f;
	}

	public static void SendHit_Bullet(EntityBase target, EntityBase source, long beforehit, HitType hittype, HitBulletStruct bulletdata)
	{
	}

	public static void SendHit_Bullet(EntityBase target, EntityBase source, long beforehit, HitType hittype, HitBulletStruct bulletdata, int soundid)
	{
	}

	public static void SendHit_Bullet(EntityBase target, EntityBase source, long beforehit, HitType hittype, HitBulletStruct bulletdata, EElementType elementType)
	{
	}

	public static void SendHit_Trap(EntityBase target, long beforehit)
	{
	}

	public static void SendHit_Trap(EntityBase target, long beforehit, int soundid)
	{
	}

	public static void SendHit_Body(EntityBase target, EntityBase source, long beforehit)
	{
	}

	public static void SendHit_Body(EntityBase target, EntityBase source, long beforehit, int soundid)
	{
	}

	public static void SendHit_Buff(EntityBase target, EntityBase source, long beforehit, EElementType element, int buffid)
	{
	}

	public static void SendHit_Rebound(EntityBase target, EntityBase source, HitStruct hs)
	{
	}

	public static void SendHit_FightBack(EntityBase target, EntityBase source, HitStruct hs)
	{
	}

	public static void SendHit_Skill(EntityBase target, EntityBase source, long beforehit)
	{
	}

	public static void SendHit_RotateSword_Skill(EntityBase target, EntityBase source, long beforehit, int skillAloneId = 1073)
	{
	}

	public static void SendHit_Skill(EntityBase target, EntityBase source, long beforehit, float backratio)
	{
	}

	public static void SendHit_Skill(EntityBase target, EntityBase source, long beforehit, float backratio, bool realHitRaiseFlag, string args = "")
	{
	}

	public static void SendHit_Skill_TrueHit(EntityBase target, EntityBase source, long truehit, float backratio, string args = "")
	{
	}

	public static void SendHit_Skill_BackSpecial(EntityBase target, EntityBase source, long beforehit, float backratio)
	{
	}

	public static void SendHit_Skill_Crit(EntityBase target, EntityBase source, long beforehit, float backratio)
	{
	}

	public static void SendHit_Skill_Crit(EntityBase target, EntityBase source, long beforehit)
	{
	}

	public static void SendHit_Crit(EntityBase target, EntityBase source, long beforehit)
	{
	}

	public static void SendHit_RotateSword_Skill_Crit(EntityBase target, EntityBase source, long beforehit, int skillAloneId = 1073)
	{
	}

	public static void SendHit_Skill(EntityBase target, long beforehit, EElementType element)
	{
	}

	public static void Send_Recover(EntityBase target, long value)
	{
	}

	public static void SendHit_Survival()
	{
	}

	public static void ClearCurrentWaveEnemies()
	{
	}

	public static void ClearCurrentRoundEnemies()
	{
	}

	public static HitStruct GetBulletHitStruct(EntityBase source, long beforehit, HitType hittype, HitBulletStruct bulletdata)
	{
		return null;
	}

	private static HitStruct GetBulletHitStruct(EntityBase source, long beforehit, HitType hittype, HitBulletStruct bulletdata, int soundid)
	{
		return null;
	}

	private static HitStruct GetTrapHitStruct(EntityBase entity, long beforehit)
	{
		return null;
	}

	private static HitStruct GetTrapHitStruct(EntityBase entity, long beforehit, int soundid)
	{
		return null;
	}

	private static HitStruct GetSkillHitStruct(long beforehit, int soundid)
	{
		return null;
	}

	private static HitStruct GetSkillHitStruct(long beforehit, int soundid, EElementType element)
	{
		return null;
	}

	private static HitStruct GetSkillHitStruct(EntityBase entity, long beforehit)
	{
		return null;
	}

	private static HitStruct GetSkillHitStruct(EntityBase entity, long beforehit, EElementType element)
	{
		return null;
	}

	private static HitStruct GetTrapHitStruct(long beforehit, int soundid)
	{
		return null;
	}

	private static HitStruct GetBodyHitStruct(EntityBase source, long beforehit)
	{
		return null;
	}

	private static HitStruct GetBodyHitStruct(EntityBase source, long beforehit, int soundid)
	{
		return null;
	}

	private static HitStruct GetBuffHitStruct(EntityBase source, long beforehit, EElementType element, int buffid)
	{
		return null;
	}

	private static HitStruct GetReboundHitStruct(EntityBase source, HitStruct hs)
	{
		return null;
	}

	private static HitStruct GetFightBackStruct(EntityBase source, HitStruct hs)
	{
		return null;
	}

	public static HitStruct GetRecoverStruct(long value)
	{
		return null;
	}

	public static HitStruct GetHitStruct(EntityBase source, long beforehit, HitType hittype, HitBulletStruct bulletdata, HitSourceType sourcetype, EElementType element, int buffid, int soundid)
	{
		return null;
	}

	public static void SendBuff(EntityBase target, EntityBase source, int buffid, params float[] args)
	{
	}

	public static void SendBuff(EntityBase target, EntityBase source, int buffid, string[] attrs, params float[] args)
	{
	}

	public static void SendBuffInternal(EntityBase target, EntityBase source, int buffid, string[] attrs, params float[] args)
	{
	}

	public static void SendBuffInternal(EntityBase target, EntityBase source, int buffid, params float[] args)
	{
	}

	public static BuffCommand CreateBuffCmd(EntityBase source, int buffid, params float[] args)
	{
		return null;
	}

	public static void SendStandaloneBuff(EntityBase target, EntityBase source, int buffid, params float[] args)
	{
	}

	public static void SendBuffBySelfHero(EntityBase target, EntityBase source, int buffid, params float[] args)
	{
	}

	public static void SendBuffBySelfHero(EntityBase target, int buffid, params float[] args)
	{
	}

	public static void SendBuff(EntityBase target, int buffid, params float[] args)
	{
	}

	public static void SendBuffs(EntityBase target, List<int> buffids)
	{
	}

	public static void RemoveBuff(EntityBase target, int buffid, params float[] args)
	{
	}

	public static void RemoveBuffs(EntityBase target, int[] buffids)
	{
	}

	public static void RemoveBuffs(EntityBase target, List<int> buffids)
	{
	}

	public static void RemoveBuffBySelfHero(EntityBase target, int buffid, params float[] args)
	{
	}

	public static void ForceSendBuff(EntityBase target, EntityBase source, int buffid, params float[] args)
	{
	}

	public static void ForceSendBuff(EntityBase target, int buffid, params float[] args)
	{
	}

	public static void ForceRemoveBuff(EntityBase target, int buffid, params float[] args)
	{
	}

	public static void UpdateResolution()
	{
	}

	public static void ResetMaxResolution()
	{
	}

	private static int get_max_resolution()
	{
		return 0;
	}

	public static bool IsMinResolution()
	{
		return false;
	}

	private static void SetResolution(int width, int height)
	{
	}

	private static bool SetResolution(int res)
	{
		return false;
	}

	public static void ShowHPMaxChange(long change, EntityBase showEntity = null)
	{
	}

	public static void ShowAttackChange(long change, EntityBase showEntity = null)
	{
	}

	public static void ShowAttackSpeedChange(string change, EntityBase showEntity = null)
	{
	}

	public static void ShowCritRateChange(string change, EntityBase showEntity = null)
	{
	}

	public static void ShowMissRateChange(string change, EntityBase showEntity = null)
	{
	}

	public static void ShowSkillName(int skillId, EntityBase showEntity = null)
	{
	}

	public static void ShowArtifactGameSkillUp(int skillId)
	{
	}

	public static void CreateHPChanger(EntityBase from, EntityBase to, HitStruct hs)
	{
	}

	public static void CreateHPChanger(EntityBase entity, HitStruct hs)
	{
	}

	public static void ShowPowerUpdate(int before, int after)
	{
	}
}
