using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cooperation.NetData;
using TableTool;

public class SelfAttributeData
{
	public enum RelicRarity
	{
		A = 1,
		S = 2,
		SS = 3,
		SSS = 4
	}

	[CompilerGenerated]
	private sealed class _003CSplitDaily130Attributes_003Ed__62 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string starConfig;

		public string _003C_003E3__starConfig;

		private string[] _003CsplitConfigs_003E5__2;

		private int _003Ci_003E5__3;

		string IEnumerator<string>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSplitDaily130Attributes_003Ed__62(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public EntityAttributeBase attribute;

	private List<string> levelups;

	private List<string> m_listUnusedAttrs;

	private List<string> m_listUsedAttrs;

	private bool isKeysMode;

	private const string REFINE_TAG = "[精炼属性]";

	private const string RELIC_ATTR = "[RELIC_ATTRS]";

	public const string WEAPON_SKIN_LOG = "[WEAPON_SKIN]";

	private List<LocalSave.EquipOne> mEquips;

	public EntityAttributeBase.ValueFloatBase InGameGold;

	public EntityAttributeBase.AttackSpeedValueBase InGameExp;

	public EntityAttributeBase.ValueFloatBase Up_Weapon;

	public EntityAttributeBase.ValueFloatBase Up_Hero;

	public EntityAttributeBase.ValueFloatBase Up_Armor;

	public EntityAttributeBase.ValueFloatBase Up_Pet;

	public EntityAttributeBase.ValueFloatBase Up_Ornament;

	public EntityAttributeBase.ValueFloatBase Up_Talisman;

	public EntityAttributeBase.ValueFloatBase Up_Bracelet;

	public EntityAttributeBase.ValueFloatBase Up_MagicBook;

	public PlayerInfoData playerInfo { get; private set; }

	public Dictionary<string, AddAttStringData> excuteAttList { get; private set; }

	public void Init(int charid = 0, bool isSelf = true)
	{
	}

	private EntityAttributeBase createAttribute()
	{
		return null;
	}

	public void InitDefault(PlayerInfoData pInfo)
	{
	}

	private void InitTryPlay(int charid)
	{
	}

	private void InitHeroAttBaseTryPlay(int charid, LocalSave.CharacterOne one)
	{
	}

	private void InitHeroAttTryPlay(LocalSave.CharacterOne one)
	{
	}

	public void InitShowAttribute(int charId = 0)
	{
	}

	public void InitDragonAttribute()
	{
	}

	private void InitCooperation(bool isSelf)
	{
	}

	public void InitCooperationPVP(PlayerInfoData pInfo)
	{
	}

	public void SetPlayerInfo(PlayerInfoData pInfo)
	{
	}

	private void InitAttribute_SailingBagBattle(int charid)
	{
	}

	private void InitAttribute_Season(int charid)
	{
	}

	public void PveSeasonAttributeInit(int charid)
	{
	}

	private void InitAttribute(int charid)
	{
	}

	private void initCampBattleAttr()
	{
	}

	private void onAfterInitAttrInGame(int charid)
	{
	}

	private void CheckHellMode()
	{
	}

	private void commonReset()
	{
	}

	public void CheckIfInitHeroAssistAttr(int heroid)
	{
	}

	private bool TryApplyBattleSystemAttrsDecision(int systemId, Action initAttrs)
	{
		return false;
	}

	private bool ShouldSkipConfiguredBattleSystemAttrs(int systemId)
	{
		return false;
	}

	public void CheckIfInitRefineInGame()
	{
	}

	private void initRefineAttrs()
	{
	}

	public void CheckIfInitHeadAndHeadFrameInGame()
	{
	}

	public void CheckIfInitPetsInGame()
	{
	}

	private void initPetAttr()
	{
	}

	public void CheckIfInitImprintInGame()
	{
	}

	public void CheckIfInitDragonsInGame()
	{
	}

	public void CheckIfInitRelicsInGame(int charId)
	{
	}

	private void initRelics(int charId)
	{
	}

	public static LocalSave.CharacterOne getCharOne(int charid)
	{
		return null;
	}

	private void initWeaponSkinAttr()
	{
	}

	public void InitAttributeForActivity114()
	{
	}

	private void initEquipsInternal()
	{
	}

	private void InitEquips()
	{
	}

	private void InitImprint()
	{
	}

	private void InitDragons(bool useEquipLevel = true)
	{
	}

	private void InitDragonsInSeason()
	{
	}

	private void initDragonExternalProperties(LocalSave.EquipOne one, SelfAttributeData data, bool useEquipLevel = true)
	{
	}

	private void addDragonExternalAttributes(DragonMagic_MagicConfig configMeta, int skillLevel, SelfAttributeData selfAttributeData, LocalSave.EquipOne equipOne, int skillId, int skillSlotIndex, bool useEquipLevel = true)
	{
	}

	private void InitEquips(int level)
	{
	}

	public void InitBabies()
	{
	}

	public void InitCharacter(int charid)
	{
	}

	private void InitDaily130HeroAttributes(int charid)
	{
	}

	private int GetDaily130HeroId(int charid)
	{
		return 0;
	}

	private int GetDaily130StarIndex(int heroId)
	{
		return 0;
	}

	private void ApplyDaily130AttributeGroup(string[] config, int starIndex, string logTag)
	{
	}

	[IteratorStateMachine(typeof(_003CSplitDaily130Attributes_003Ed__62))]
	private IEnumerable<string> SplitDaily130Attributes(string starConfig)
	{
		return null;
	}

	public void InitPveSeasonCharacter(int charid, int level = 1)
	{
	}

	private void InitHeroAttBase(int charid, LocalSave.CharacterOne one)
	{
	}

	private void InitHeroAtt(LocalSave.CharacterOne one)
	{
	}

	private void InitHeroSkinAtt(int charID)
	{
	}

	private void InitPveSeasonHeroAtt(LocalSave.CharacterOne one)
	{
	}

	private void InitHeroSkinAttr(int charID)
	{
	}

	private void InitATKAndHpAttr(int charid)
	{
	}

	private void CheckInitImprintAttrs()
	{
	}

	private void InitImprintAttrs()
	{
	}

	public void CheckIfInitManorAttrs()
	{
	}

	public void InitManorAttrs()
	{
	}

	public void CheckIfInitArtifactInGame()
	{
	}

	public void CheckIfInitArtifactInGame(int aID, int aStar)
	{
	}

	public void CheckIfInitTotemInGame(int charID)
	{
	}

	public void CheckIfInitTotemInGameLast(int charID)
	{
	}

	public void initArtifactAttrs()
	{
	}

	public void initArtifactAttrs(int aID, int aStar)
	{
	}

	public void InitGemsAttrs()
	{
	}

	public void initVIPAttrs()
	{
	}

	public void initBadgeAttrs()
	{
	}

	public void initMedalAttrs()
	{
	}

	public void InitHeadAttrs()
	{
	}

	public void InitHeadFrameAttrs()
	{
	}

	public void initTrainAttr(int charid)
	{
	}

	public void InitRunes()
	{
	}

	public void InitAltarAttrs()
	{
	}

	public void InitEggAttrs()
	{
	}

	protected void InitWingAttrs()
	{
	}

	private void _InitWingAttrs()
	{
	}

	private void _InitTryPlayWingAttrs()
	{
	}

	private void ExcuteWingUniqueAttrs(List<Goods_goods.GoodData> allAttrlist)
	{
	}

	private void _InitTotemAttrs(int charID)
	{
	}

	private void _InitTotemAttrsLast(int charID)
	{
	}

	private bool CheckTotemAttrs(Goods_goods.GoodData goodData, int charID)
	{
		return false;
	}

	private void InitHeroStarAttrPercent(int charID, float value)
	{
	}

	private void InitHeroSkinUpPercent(int charID, float value)
	{
	}

	private void InitHeroAssistAttrPercent(int chardID, float value)
	{
	}

	private void InitUpEquipPercent(float value)
	{
	}

	private void InitSP1GemsAddPercent(float value)
	{
	}

	private void InitSP2GemsAddPercent(float value)
	{
	}

	private void InitRelicsBasePercent(float value)
	{
	}

	private void InitPetBasePercent(float value)
	{
	}

	private void InitRelicsRedStarPercent(float value)
	{
	}

	private void InitRelicsOrangeStarPercent(float value)
	{
	}

	public void InitWeaponColorAttr()
	{
	}

	public void InitWeaponCollectAttr()
	{
	}

	public void InitHeroSkinCollectAttr()
	{
	}

	public void InitWeaponSkinLevelUpAttr()
	{
	}

	public List<string> GetUnusedAttrs()
	{
		return null;
	}

	private void ExcuteRuneHeroAttrs(int charid, Dictionary<int, EntityAttributeBase.ValueBase> values, string name)
	{
	}

	private void ExcuteRuneHeroAttrs(int charid, Dictionary<int, EntityAttributeBase.ValueFloatBase> values, string name)
	{
	}

	private void ClearCards()
	{
	}

	private void InitCards()
	{
	}

	public void InitEquip(List<LocalSave.EquipOne> wearList)
	{
	}

	public void InitCharacterLevel1(int id)
	{
	}

	public void Attribute2LevelUp(EntityData data)
	{
	}

	public float GetEquipUpPercentWrapper(LocalSave.EquipOne equipOne, int i)
	{
		return 0f;
	}

	public float GetEquipUpPercentWrapperInternal(int position, int index, int i)
	{
		return 0f;
	}

	public long GetAllWeaponValue(LocalSave.EquipOne equipOne)
	{
		return 0L;
	}

	public float GetUpPercent(int position)
	{
		return 0f;
	}

	public float GetEquipUpPercent(int position)
	{
		return 0f;
	}

	public float GetRefineUpPercent(int index, int i)
	{
		return 0f;
	}

	public int GetUpGemLevel(int location)
	{
		return 0;
	}

	public float GetGemsAddPercent(string attr, bool InJewelSet)
	{
		return 0f;
	}

	public float GetGemsAddPercentByType(string attr, bool InJewelSet)
	{
		return 0f;
	}

	public bool Excute(string att)
	{
		return false;
	}

	public bool Excute(string type, long value)
	{
		return false;
	}

	public void CacheExcuteAttString(string type, long value)
	{
	}

	public EntityAttributeBase InitInPvp1()
	{
		return null;
	}

	public float GetDeltaPercentForRelicBasicAttr(int relicRarity)
	{
		return 0f;
	}
}
