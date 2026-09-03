using System;
using System.Collections.Generic;
using System.Reflection;
using Activity;
using Activity.Anniversary;
using Activity.Anniversary.Exchange.Data;
using Tutorial;
using UnityEngine;
using XLua.CSObjectWrap;
using XLua.LuaDLL;
using XLuaTest;

namespace XLua
{
	public class ObjectTranslator
	{
		private class IniterAdderUnityEngineVector2
		{
			static IniterAdderUnityEngineVector2()
			{
			}

			private static void Init(LuaEnv luaenv, ObjectTranslator translator)
			{
			}
		}

		internal enum LOGLEVEL
		{
			NO = 0,
			INFO = 1,
			WARN = 2,
			ERROR = 3
		}

		public delegate void PushCSObject(IntPtr L, object obj);

		public delegate object GetCSObject(IntPtr L, int idx);

		public delegate void UpdateCSObject(IntPtr L, int idx, object obj);

		public delegate bool CheckFunc<T>(IntPtr L, int idx);

		public delegate void GetFunc<T>(IntPtr L, int idx, out T val);

		private static IniterAdderUnityEngineVector2 s_IniterAdderUnityEngineVector2_dumb_obj;

		private int UnityEngineVector2_TypeID;

		private int UnityEngineVector3_TypeID;

		private int UnityEngineVector4_TypeID;

		private int UnityEngineColor_TypeID;

		private int UnityEngineQuaternion_TypeID;

		private int UnityEngineRay_TypeID;

		private int UnityEngineBounds_TypeID;

		private int UnityEngineRay2D_TypeID;

		private int XLuaTestPedding_TypeID;

		private int XLuaTestMyStruct_TypeID;

		private int XLuaTestPushAsTableStruct_TypeID;

		private int TutorialTestEnum_TypeID;

		private int TutorialTestEnum_EnumRef;

		private int XLuaTestMyEnum_TypeID;

		private int XLuaTestMyEnum_EnumRef;

		private int TutorialDerivedClassTestEnumInner_TypeID;

		private int TutorialDerivedClassTestEnumInner_EnumRef;

		private int WindowID_TypeID;

		private int WindowID_EnumRef;

		private int RedNodeType_TypeID;

		private int RedNodeType_EnumRef;

		private int GiftBoxManagerGiftBoxType_TypeID;

		private int GiftBoxManagerGiftBoxType_EnumRef;

		private int ActivityTab_TypeID;

		private int ActivityTab_EnumRef;

		private int Act4thBoxManagerBoxSource_TypeID;

		private int Act4thBoxManagerBoxSource_EnumRef;

		private int ActivityAnniversaryExchangeDataExchangeThemeType_TypeID;

		private int ActivityAnniversaryExchangeDataExchangeThemeType_EnumRef;

		private int ActivityAnniversaryTabAnni_TypeID;

		private int ActivityAnniversaryTabAnni_EnumRef;

		private int ActivityAnniversaryRequestType_TypeID;

		private int ActivityAnniversaryRequestType_EnumRef;

		private int ActivityAnniversaryRewardType_TypeID;

		private int ActivityAnniversaryRewardType_EnumRef;

		private int ActivityAnniversaryTaskType_TypeID;

		private int ActivityAnniversaryTaskType_EnumRef;

		private int ActivityAnniversaryJigsawState_TypeID;

		private int ActivityAnniversaryJigsawState_EnumRef;

		private int ActivityAnniversaryTowerDefenseBattleRequestType_TypeID;

		private int ActivityAnniversaryTowerDefenseBattleRequestType_EnumRef;

		private int CampAchievementItemStatus_TypeID;

		private int CampAchievementItemStatus_EnumRef;

		private int CampGiftType_TypeID;

		private int CampGiftType_EnumRef;

		private int CampTimingGiftThemeType_TypeID;

		private int CampTimingGiftThemeType_EnumRef;

		private int CampShopItemResetType_TypeID;

		private int CampShopItemResetType_EnumRef;

		private int CampTalentLineDir_TypeID;

		private int CampTalentLineDir_EnumRef;

		private int CampTalentTeamTaskStatus_TypeID;

		private int CampTalentTeamTaskStatus_EnumRef;

		private int CampTileStatus_TypeID;

		private int CampTileStatus_EnumRef;

		private int CampTileBattleStatus_TypeID;

		private int CampTileBattleStatus_EnumRef;

		private int CampTileOpenCond_TypeID;

		private int CampTileOpenCond_EnumRef;

		private int CampTileOperationRestriction_TypeID;

		private int CampTileOperationRestriction_EnumRef;

		private int CampTileOperationType_TypeID;

		private int CampTileOperationType_EnumRef;

		private int CampTileOccupyRestriction_TypeID;

		private int CampTileOccupyRestriction_EnumRef;

		private int CampTileOccupyType_TypeID;

		private int CampTileOccupyType_EnumRef;

		private int CampTileOccupyAttackType_TypeID;

		private int CampTileOccupyAttackType_EnumRef;

		private int CampTileType_TypeID;

		private int CampTileType_EnumRef;

		private int CampTileResourceType_TypeID;

		private int CampTileResourceType_EnumRef;

		private int CampTileOutputResourceType_TypeID;

		private int CampTileOutputResourceType_EnumRef;

		private int BossBattleStatus_TypeID;

		private int BossBattleStatus_EnumRef;

		private int CampTileRewardStatus_TypeID;

		private int CampTileRewardStatus_EnumRef;

		private int CampTileArrowType_TypeID;

		private int CampTileArrowType_EnumRef;

		private int HeroDispatchStatus_TypeID;

		private int HeroDispatchStatus_EnumRef;

		private int ProgressType_TypeID;

		private int ProgressType_EnumRef;

		private int BattleType_TypeID;

		private int BattleType_EnumRef;

		private int LuckyWheelRewardStatus_TypeID;

		private int LuckyWheelRewardStatus_EnumRef;

		private int LuckyWheelRewardTheme_TypeID;

		private int LuckyWheelRewardTheme_EnumRef;

		private int PropType_TypeID;

		private int PropType_EnumRef;

		private int Christmas2023RewardStatus_TypeID;

		private int Christmas2023RewardStatus_EnumRef;

		private int FishingRewardStatus_TypeID;

		private int FishingRewardStatus_EnumRef;

		private int FishingStatus_TypeID;

		private int FishingStatus_EnumRef;

		private int FishingRodAniStatus_TypeID;

		private int FishingRodAniStatus_EnumRef;

		private int FishingFishAniStatus_TypeID;

		private int FishingFishAniStatus_EnumRef;

		private int FishingResult_TypeID;

		private int FishingResult_EnumRef;

		private int FishingRodStatus_TypeID;

		private int FishingRodStatus_EnumRef;

		private int FishingFishStatus_TypeID;

		private int FishingFishStatus_EnumRef;

		private int FishingRodType_TypeID;

		private int FishingRodType_EnumRef;

		private int FishingFishType_TypeID;

		private int FishingFishType_EnumRef;

		private int FishingSoundStatus_TypeID;

		private int FishingSoundStatus_EnumRef;

		private int CampTownSkinLockType_TypeID;

		private int CampTownSkinLockType_EnumRef;

		private static XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj;

		internal MethodWrapsCache methodWrapsCache;

		internal ObjectCheckers objectCheckers;

		internal ObjectCasters objectCasters;

		internal readonly ObjectPool objects;

		internal readonly Dictionary<object, int> reverseMap;

		internal LuaEnv luaEnv;

		internal StaticLuaCallbacks metaFunctions;

		internal List<Assembly> assemblies;

		private lua_CSFunction importTypeFunction;

		private lua_CSFunction loadAssemblyFunction;

		private lua_CSFunction castFunction;

		private readonly Dictionary<Type, Action<IntPtr>> delayWrap;

		private readonly Dictionary<Type, Func<int, LuaEnv, LuaBase>> interfaceBridgeCreators;

		private readonly Dictionary<Type, Type> aliasCfg;

		private Dictionary<Type, bool> loaded_types;

		public int cacheRef;

		private MethodInfo[] genericAction;

		private MethodInfo[] genericFunc;

		private Dictionary<Type, Func<DelegateBridgeBase, Delegate>> delegateCreatorCache;

		private Dictionary<int, WeakReference> delegate_bridges;

		private int common_array_meta;

		private int common_delegate_meta;

		private int enumerable_pairs_func;

		private Dictionary<Type, int> typeIdMap;

		private Dictionary<int, Type> typeMap;

		private HashSet<Type> privateAccessibleFlags;

		private Dictionary<object, int> enumMap;

		private List<lua_CSFunction> fix_cs_functions;

		private Dictionary<Type, PushCSObject> custom_push_funcs;

		private Dictionary<Type, GetCSObject> custom_get_funcs;

		private Dictionary<Type, UpdateCSObject> custom_update_funcs;

		private Dictionary<Type, Delegate> push_func_with_type;

		private Dictionary<Type, Delegate> get_func_with_type;

		private int decimal_type_id;

		private static IniterAdderUnityEngineVector2 IniterAdderUnityEngineVector2_dumb_obj => null;

		private static XLua_Gen_Initer_Register__ gen_reg_dumb_obj => null;

		public void PushUnityEngineVector2(IntPtr L, Vector2 val)
		{
		}

		public void Get(IntPtr L, int index, out Vector2 val)
		{
			val = default;
		}

		public void UpdateUnityEngineVector2(IntPtr L, int index, Vector2 val)
		{
		}

		public void PushUnityEngineVector3(IntPtr L, Vector3 val)
		{
		}

		public void Get(IntPtr L, int index, out Vector3 val)
		{
			val = default;
		}

		public void UpdateUnityEngineVector3(IntPtr L, int index, Vector3 val)
		{
		}

		public void PushUnityEngineVector4(IntPtr L, Vector4 val)
		{
		}

		public void Get(IntPtr L, int index, out Vector4 val)
		{
			val = default;
		}

		public void UpdateUnityEngineVector4(IntPtr L, int index, Vector4 val)
		{
		}

		public void PushUnityEngineColor(IntPtr L, Color val)
		{
		}

		public void Get(IntPtr L, int index, out Color val)
		{
			val = default;
		}

		public void UpdateUnityEngineColor(IntPtr L, int index, Color val)
		{
		}

		public void PushUnityEngineQuaternion(IntPtr L, Quaternion val)
		{
		}

		public void Get(IntPtr L, int index, out Quaternion val)
		{
			val = default;
		}

		public void UpdateUnityEngineQuaternion(IntPtr L, int index, Quaternion val)
		{
		}

		public void PushUnityEngineRay(IntPtr L, Ray val)
		{
		}

		public void Get(IntPtr L, int index, out Ray val)
		{
			val = default;
		}

		public void UpdateUnityEngineRay(IntPtr L, int index, Ray val)
		{
		}

		public void PushUnityEngineBounds(IntPtr L, Bounds val)
		{
		}

		public void Get(IntPtr L, int index, out Bounds val)
		{
			val = default;
		}

		public void UpdateUnityEngineBounds(IntPtr L, int index, Bounds val)
		{
		}

		public void PushUnityEngineRay2D(IntPtr L, Ray2D val)
		{
		}

		public void Get(IntPtr L, int index, out Ray2D val)
		{
			val = default;
		}

		public void UpdateUnityEngineRay2D(IntPtr L, int index, Ray2D val)
		{
		}

		public void PushXLuaTestPedding(IntPtr L, Pedding val)
		{
		}

		public void Get(IntPtr L, int index, out Pedding val)
		{
			val = default;
		}

		public void UpdateXLuaTestPedding(IntPtr L, int index, Pedding val)
		{
		}

		public void PushXLuaTestMyStruct(IntPtr L, MyStruct val)
		{
		}

		public void Get(IntPtr L, int index, out MyStruct val)
		{
			val = default;
		}

		public void UpdateXLuaTestMyStruct(IntPtr L, int index, MyStruct val)
		{
		}

		public void PushXLuaTestPushAsTableStruct(IntPtr L, PushAsTableStruct val)
		{
		}

		public void Get(IntPtr L, int index, out PushAsTableStruct val)
		{
			val = default;
		}

		public void UpdateXLuaTestPushAsTableStruct(IntPtr L, int index, PushAsTableStruct val)
		{
		}

		public void PushTutorialTestEnum(IntPtr L, TestEnum val)
		{
		}

		public void Get(IntPtr L, int index, out TestEnum val)
		{
			val = default;
		}

		public void UpdateTutorialTestEnum(IntPtr L, int index, TestEnum val)
		{
		}

		public void PushXLuaTestMyEnum(IntPtr L, MyEnum val)
		{
		}

		public void Get(IntPtr L, int index, out MyEnum val)
		{
			val = default;
		}

		public void UpdateXLuaTestMyEnum(IntPtr L, int index, MyEnum val)
		{
		}

		public void PushTutorialDerivedClassTestEnumInner(IntPtr L, DerivedClass.TestEnumInner val)
		{
		}

		public void Get(IntPtr L, int index, out DerivedClass.TestEnumInner val)
		{
			val = default;
		}

		public void UpdateTutorialDerivedClassTestEnumInner(IntPtr L, int index, DerivedClass.TestEnumInner val)
		{
		}

		public void PushWindowID(IntPtr L, WindowID val)
		{
		}

		public void Get(IntPtr L, int index, out WindowID val)
		{
			val = default;
		}

		public void UpdateWindowID(IntPtr L, int index, WindowID val)
		{
		}

		public void PushRedNodeType(IntPtr L, RedNodeType val)
		{
		}

		public void Get(IntPtr L, int index, out RedNodeType val)
		{
			val = default;
		}

		public void UpdateRedNodeType(IntPtr L, int index, RedNodeType val)
		{
		}

		public void PushGiftBoxManagerGiftBoxType(IntPtr L, GiftBoxManager.GiftBoxType val)
		{
		}

		public void Get(IntPtr L, int index, out GiftBoxManager.GiftBoxType val)
		{
			val = default;
		}

		public void UpdateGiftBoxManagerGiftBoxType(IntPtr L, int index, GiftBoxManager.GiftBoxType val)
		{
		}

		public void PushActivityTab(IntPtr L, Tab val)
		{
		}

		public void Get(IntPtr L, int index, out Tab val)
		{
			val = default;
		}

		public void UpdateActivityTab(IntPtr L, int index, Tab val)
		{
		}

		public void PushAct4thBoxManagerBoxSource(IntPtr L, Act4thBoxManager.BoxSource val)
		{
		}

		public void Get(IntPtr L, int index, out Act4thBoxManager.BoxSource val)
		{
			val = default;
		}

		public void UpdateAct4thBoxManagerBoxSource(IntPtr L, int index, Act4thBoxManager.BoxSource val)
		{
		}

		public void PushActivityAnniversaryExchangeDataExchangeThemeType(IntPtr L, ExchangeThemeType val)
		{
		}

		public void Get(IntPtr L, int index, out ExchangeThemeType val)
		{
			val = default;
		}

		public void UpdateActivityAnniversaryExchangeDataExchangeThemeType(IntPtr L, int index, ExchangeThemeType val)
		{
		}

		public void PushActivityAnniversaryTabAnni(IntPtr L, TabAnni val)
		{
		}

		public void Get(IntPtr L, int index, out TabAnni val)
		{
			val = default;
		}

		public void UpdateActivityAnniversaryTabAnni(IntPtr L, int index, TabAnni val)
		{
		}

		public void PushActivityAnniversaryRequestType(IntPtr L, RequestType val)
		{
		}

		public void Get(IntPtr L, int index, out RequestType val)
		{
			val = default;
		}

		public void UpdateActivityAnniversaryRequestType(IntPtr L, int index, RequestType val)
		{
		}

		public void PushActivityAnniversaryRewardType(IntPtr L, RewardType val)
		{
		}

		public void Get(IntPtr L, int index, out RewardType val)
		{
			val = default;
		}

		public void UpdateActivityAnniversaryRewardType(IntPtr L, int index, RewardType val)
		{
		}

		public void PushActivityAnniversaryTaskType(IntPtr L, TaskType val)
		{
		}

		public void Get(IntPtr L, int index, out TaskType val)
		{
			val = default;
		}

		public void UpdateActivityAnniversaryTaskType(IntPtr L, int index, TaskType val)
		{
		}

		public void PushActivityAnniversaryJigsawState(IntPtr L, JigsawState val)
		{
		}

		public void Get(IntPtr L, int index, out JigsawState val)
		{
			val = default;
		}

		public void UpdateActivityAnniversaryJigsawState(IntPtr L, int index, JigsawState val)
		{
		}

		public void PushActivityAnniversaryTowerDefenseBattleRequestType(IntPtr L, TowerDefenseBattleRequestType val)
		{
		}

		public void Get(IntPtr L, int index, out TowerDefenseBattleRequestType val)
		{
			val = default;
		}

		public void UpdateActivityAnniversaryTowerDefenseBattleRequestType(IntPtr L, int index, TowerDefenseBattleRequestType val)
		{
		}

		public void PushCampAchievementItemStatus(IntPtr L, CampAchievementItemStatus val)
		{
		}

		public void Get(IntPtr L, int index, out CampAchievementItemStatus val)
		{
			val = default;
		}

		public void UpdateCampAchievementItemStatus(IntPtr L, int index, CampAchievementItemStatus val)
		{
		}

		public void PushCampGiftType(IntPtr L, CampGiftType val)
		{
		}

		public void Get(IntPtr L, int index, out CampGiftType val)
		{
			val = default;
		}

		public void UpdateCampGiftType(IntPtr L, int index, CampGiftType val)
		{
		}

		public void PushCampTimingGiftThemeType(IntPtr L, CampTimingGiftThemeType val)
		{
		}

		public void Get(IntPtr L, int index, out CampTimingGiftThemeType val)
		{
			val = default;
		}

		public void UpdateCampTimingGiftThemeType(IntPtr L, int index, CampTimingGiftThemeType val)
		{
		}

		public void PushCampShopItemResetType(IntPtr L, CampShopItemResetType val)
		{
		}

		public void Get(IntPtr L, int index, out CampShopItemResetType val)
		{
			val = default;
		}

		public void UpdateCampShopItemResetType(IntPtr L, int index, CampShopItemResetType val)
		{
		}

		public void PushCampTalentLineDir(IntPtr L, CampTalentLineDir val)
		{
		}

		public void Get(IntPtr L, int index, out CampTalentLineDir val)
		{
			val = default;
		}

		public void UpdateCampTalentLineDir(IntPtr L, int index, CampTalentLineDir val)
		{
		}

		public void PushCampTalentTeamTaskStatus(IntPtr L, CampTalentTeamTaskStatus val)
		{
		}

		public void Get(IntPtr L, int index, out CampTalentTeamTaskStatus val)
		{
			val = default;
		}

		public void UpdateCampTalentTeamTaskStatus(IntPtr L, int index, CampTalentTeamTaskStatus val)
		{
		}

		public void PushCampTileStatus(IntPtr L, CampTileStatus val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileStatus val)
		{
			val = default;
		}

		public void UpdateCampTileStatus(IntPtr L, int index, CampTileStatus val)
		{
		}

		public void PushCampTileBattleStatus(IntPtr L, CampTileBattleStatus val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileBattleStatus val)
		{
			val = default;
		}

		public void UpdateCampTileBattleStatus(IntPtr L, int index, CampTileBattleStatus val)
		{
		}

		public void PushCampTileOpenCond(IntPtr L, CampTileOpenCond val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileOpenCond val)
		{
			val = default;
		}

		public void UpdateCampTileOpenCond(IntPtr L, int index, CampTileOpenCond val)
		{
		}

		public void PushCampTileOperationRestriction(IntPtr L, CampTileOperationRestriction val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileOperationRestriction val)
		{
			val = default;
		}

		public void UpdateCampTileOperationRestriction(IntPtr L, int index, CampTileOperationRestriction val)
		{
		}

		public void PushCampTileOperationType(IntPtr L, CampTileOperationType val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileOperationType val)
		{
			val = default;
		}

		public void UpdateCampTileOperationType(IntPtr L, int index, CampTileOperationType val)
		{
		}

		public void PushCampTileOccupyRestriction(IntPtr L, CampTileOccupyRestriction val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileOccupyRestriction val)
		{
			val = default;
		}

		public void UpdateCampTileOccupyRestriction(IntPtr L, int index, CampTileOccupyRestriction val)
		{
		}

		public void PushCampTileOccupyType(IntPtr L, CampTileOccupyType val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileOccupyType val)
		{
			val = default;
		}

		public void UpdateCampTileOccupyType(IntPtr L, int index, CampTileOccupyType val)
		{
		}

		public void PushCampTileOccupyAttackType(IntPtr L, CampTileOccupyAttackType val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileOccupyAttackType val)
		{
			val = default;
		}

		public void UpdateCampTileOccupyAttackType(IntPtr L, int index, CampTileOccupyAttackType val)
		{
		}

		public void PushCampTileType(IntPtr L, CampTileType val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileType val)
		{
			val = default;
		}

		public void UpdateCampTileType(IntPtr L, int index, CampTileType val)
		{
		}

		public void PushCampTileResourceType(IntPtr L, CampTileResourceType val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileResourceType val)
		{
			val = default;
		}

		public void UpdateCampTileResourceType(IntPtr L, int index, CampTileResourceType val)
		{
		}

		public void PushCampTileOutputResourceType(IntPtr L, CampTileOutputResourceType val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileOutputResourceType val)
		{
			val = default;
		}

		public void UpdateCampTileOutputResourceType(IntPtr L, int index, CampTileOutputResourceType val)
		{
		}

		public void PushBossBattleStatus(IntPtr L, BossBattleStatus val)
		{
		}

		public void Get(IntPtr L, int index, out BossBattleStatus val)
		{
			val = default;
		}

		public void UpdateBossBattleStatus(IntPtr L, int index, BossBattleStatus val)
		{
		}

		public void PushCampTileRewardStatus(IntPtr L, CampTileRewardStatus val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileRewardStatus val)
		{
			val = default;
		}

		public void UpdateCampTileRewardStatus(IntPtr L, int index, CampTileRewardStatus val)
		{
		}

		public void PushCampTileArrowType(IntPtr L, CampTileArrowType val)
		{
		}

		public void Get(IntPtr L, int index, out CampTileArrowType val)
		{
			val = default;
		}

		public void UpdateCampTileArrowType(IntPtr L, int index, CampTileArrowType val)
		{
		}

		public void PushHeroDispatchStatus(IntPtr L, HeroDispatchStatus val)
		{
		}

		public void Get(IntPtr L, int index, out HeroDispatchStatus val)
		{
			val = default;
		}

		public void UpdateHeroDispatchStatus(IntPtr L, int index, HeroDispatchStatus val)
		{
		}

		public void PushProgressType(IntPtr L, ProgressType val)
		{
		}

		public void Get(IntPtr L, int index, out ProgressType val)
		{
			val = default;
		}

		public void UpdateProgressType(IntPtr L, int index, ProgressType val)
		{
		}

		public void PushBattleType(IntPtr L, BattleType val)
		{
		}

		public void Get(IntPtr L, int index, out BattleType val)
		{
			val = default;
		}

		public void UpdateBattleType(IntPtr L, int index, BattleType val)
		{
		}

		public void PushLuckyWheelRewardStatus(IntPtr L, LuckyWheelRewardStatus val)
		{
		}

		public void Get(IntPtr L, int index, out LuckyWheelRewardStatus val)
		{
			val = default;
		}

		public void UpdateLuckyWheelRewardStatus(IntPtr L, int index, LuckyWheelRewardStatus val)
		{
		}

		public void PushLuckyWheelRewardTheme(IntPtr L, LuckyWheelRewardTheme val)
		{
		}

		public void Get(IntPtr L, int index, out LuckyWheelRewardTheme val)
		{
			val = default;
		}

		public void UpdateLuckyWheelRewardTheme(IntPtr L, int index, LuckyWheelRewardTheme val)
		{
		}

		public void PushPropType(IntPtr L, PropType val)
		{
		}

		public void Get(IntPtr L, int index, out PropType val)
		{
			val = default;
		}

		public void UpdatePropType(IntPtr L, int index, PropType val)
		{
		}

		public void PushChristmas2023RewardStatus(IntPtr L, Christmas2023RewardStatus val)
		{
		}

		public void Get(IntPtr L, int index, out Christmas2023RewardStatus val)
		{
			val = default;
		}

		public void UpdateChristmas2023RewardStatus(IntPtr L, int index, Christmas2023RewardStatus val)
		{
		}

		public void PushFishingRewardStatus(IntPtr L, FishingRewardStatus val)
		{
		}

		public void Get(IntPtr L, int index, out FishingRewardStatus val)
		{
			val = default;
		}

		public void UpdateFishingRewardStatus(IntPtr L, int index, FishingRewardStatus val)
		{
		}

		public void PushFishingStatus(IntPtr L, FishingStatus val)
		{
		}

		public void Get(IntPtr L, int index, out FishingStatus val)
		{
			val = default;
		}

		public void UpdateFishingStatus(IntPtr L, int index, FishingStatus val)
		{
		}

		public void PushFishingRodAniStatus(IntPtr L, FishingRodAniStatus val)
		{
		}

		public void Get(IntPtr L, int index, out FishingRodAniStatus val)
		{
			val = default;
		}

		public void UpdateFishingRodAniStatus(IntPtr L, int index, FishingRodAniStatus val)
		{
		}

		public void PushFishingFishAniStatus(IntPtr L, FishingFishAniStatus val)
		{
		}

		public void Get(IntPtr L, int index, out FishingFishAniStatus val)
		{
			val = default;
		}

		public void UpdateFishingFishAniStatus(IntPtr L, int index, FishingFishAniStatus val)
		{
		}

		public void PushFishingResult(IntPtr L, FishingResult val)
		{
		}

		public void Get(IntPtr L, int index, out FishingResult val)
		{
			val = default;
		}

		public void UpdateFishingResult(IntPtr L, int index, FishingResult val)
		{
		}

		public void PushFishingRodStatus(IntPtr L, FishingRodStatus val)
		{
		}

		public void Get(IntPtr L, int index, out FishingRodStatus val)
		{
			val = default;
		}

		public void UpdateFishingRodStatus(IntPtr L, int index, FishingRodStatus val)
		{
		}

		public void PushFishingFishStatus(IntPtr L, FishingFishStatus val)
		{
		}

		public void Get(IntPtr L, int index, out FishingFishStatus val)
		{
			val = default;
		}

		public void UpdateFishingFishStatus(IntPtr L, int index, FishingFishStatus val)
		{
		}

		public void PushFishingRodType(IntPtr L, FishingRodType val)
		{
		}

		public void Get(IntPtr L, int index, out FishingRodType val)
		{
			val = default;
		}

		public void UpdateFishingRodType(IntPtr L, int index, FishingRodType val)
		{
		}

		public void PushFishingFishType(IntPtr L, FishingFishType val)
		{
		}

		public void Get(IntPtr L, int index, out FishingFishType val)
		{
			val = default;
		}

		public void UpdateFishingFishType(IntPtr L, int index, FishingFishType val)
		{
		}

		public void PushFishingSoundStatus(IntPtr L, FishingSoundStatus val)
		{
		}

		public void Get(IntPtr L, int index, out FishingSoundStatus val)
		{
			val = default;
		}

		public void UpdateFishingSoundStatus(IntPtr L, int index, FishingSoundStatus val)
		{
		}

		public void PushCampTownSkinLockType(IntPtr L, CampTownSkinLockType val)
		{
		}

		public void Get(IntPtr L, int index, out CampTownSkinLockType val)
		{
			val = default;
		}

		public void UpdateCampTownSkinLockType(IntPtr L, int index, CampTownSkinLockType val)
		{
		}

		public void DelayWrapLoader(Type type, Action<IntPtr> loader)
		{
		}

		public void AddInterfaceBridgeCreator(Type type, Func<int, LuaEnv, LuaBase> creator)
		{
		}

		public bool TryDelayWrapLoader(IntPtr L, Type type)
		{
			return false;
		}

		public void Alias(Type type, string alias)
		{
		}

		private void addAssemblieByName(IEnumerable<Assembly> assemblies_usorted, string name)
		{
		}

		public ObjectTranslator(LuaEnv luaenv, IntPtr L)
		{
		}

		private void initCSharpCallLua()
		{
		}

		private Func<DelegateBridgeBase, Delegate> getCreatorUsingGeneric(DelegateBridgeBase bridge, Type delegateType, MethodInfo delegateMethod)
		{
			return null;
		}

		private Delegate getDelegate(DelegateBridgeBase bridge, Type delegateType)
		{
			return null;
		}

		public object CreateDelegateBridge(IntPtr L, Type delegateType, int idx)
		{
			return null;
		}

		public bool AllDelegateBridgeReleased()
		{
			return false;
		}

		public void ReleaseLuaBase(IntPtr L, int reference, bool is_delegate)
		{
		}

		public object CreateInterfaceBridge(IntPtr L, Type interfaceType, int idx)
		{
			return null;
		}

		public void CreateArrayMetatable(IntPtr L)
		{
		}

		public void CreateDelegateMetatable(IntPtr L)
		{
		}

		internal void CreateEnumerablePairs(IntPtr L)
		{
		}

		public void OpenLib(IntPtr L)
		{
		}

		internal void createFunctionMetatable(IntPtr L)
		{
		}

		internal Type FindType(string className, bool isQualifiedName = false)
		{
			return null;
		}

		private bool hasMethod(Type type, string methodName)
		{
			return false;
		}

		internal void collectObject(int obj_index_to_collect)
		{
		}

		private int addObject(object obj, bool is_valuetype, bool is_enum)
		{
			return 0;
		}

		internal object GetObject(IntPtr L, int index)
		{
			return null;
		}

		public Type GetTypeOf(IntPtr L, int idx)
		{
			return null;
		}

		public bool Assignable<T>(IntPtr L, int index)
		{
			return false;
		}

		public bool Assignable(IntPtr L, int index, Type type)
		{
			return false;
		}

		public object GetObject(IntPtr L, int index, Type type)
		{
			return null;
		}

		public void Get<T>(IntPtr L, int index, out T v)
		{
			v = default;
		}

		public void PushByType<T>(IntPtr L, T v)
		{
		}

		public T[] GetParams<T>(IntPtr L, int index)
		{
			return null;
		}

		public Array GetParams(IntPtr L, int index, Type type)
		{
			return null;
		}

		public T GetDelegate<T>(IntPtr L, int index) where T : class
		{
			return null;
		}

		public int GetTypeId(IntPtr L, Type type)
		{
			return 0;
		}

		public void PrivateAccessible(IntPtr L, Type type)
		{
		}

		internal int getTypeId(IntPtr L, Type type, out bool is_first, LOGLEVEL log_level = LOGLEVEL.WARN)
		{
			is_first = default;
			return 0;
		}

		private void pushPrimitive(IntPtr L, object o)
		{
		}

		public void PushAny(IntPtr L, object o)
		{
		}

		public int TranslateToEnumToTop(IntPtr L, Type type, int idx)
		{
			return 0;
		}

		public void Push(IntPtr L, lua_CSFunction o)
		{
		}

		public void Push(IntPtr L, LuaBase o)
		{
		}

		public void Push(IntPtr L, object o)
		{
		}

		public void PushObject(IntPtr L, object o, int type_id)
		{
		}

		public void Update(IntPtr L, int index, object obj)
		{
		}

		private object getCsObj(IntPtr L, int index, int udata)
		{
			return null;
		}

		internal object SafeGetCSObj(IntPtr L, int index)
		{
			return null;
		}

		internal object FastGetCSObj(IntPtr L, int index)
		{
			return null;
		}

		internal void ReleaseCSObj(IntPtr L, int index)
		{
		}

		internal lua_CSFunction GetFixCSFunction(int index)
		{
			return null;
		}

		internal void PushFixCSFunction(IntPtr L, lua_CSFunction func)
		{
		}

		internal object[] popValues(IntPtr L, int oldTop)
		{
			return null;
		}

		internal object[] popValues(IntPtr L, int oldTop, Type[] popTypes)
		{
			return null;
		}

		private void registerCustomOp(Type type, PushCSObject push, GetCSObject get, UpdateCSObject update)
		{
		}

		public bool HasCustomOp(Type type)
		{
			return false;
		}

		private bool tryGetPushFuncByType<T>(Type type, out T func) where T : class
		{
			func = null;
			return false;
		}

		private bool tryGetGetFuncByType<T>(Type type, out T func) where T : class
		{
			func = null;
			return false;
		}

		public void RegisterPushAndGetAndUpdate<T>(Action<IntPtr, T> push, GetFunc<T> get, Action<IntPtr, int, T> update)
		{
		}

		public void RegisterChecker<T>(CheckFunc<T> check)
		{
		}

		public void RegisterCaster<T>(GetFunc<T> get)
		{
		}

		public void PushDecimal(IntPtr L, decimal val)
		{
		}

		public bool IsDecimal(IntPtr L, int index)
		{
			return false;
		}

		public decimal GetDecimal(IntPtr L, int index)
		{
			return 0m;
		}

		public void Get(IntPtr L, int index, out decimal val)
		{
			val = 0m;
		}
	}
}
