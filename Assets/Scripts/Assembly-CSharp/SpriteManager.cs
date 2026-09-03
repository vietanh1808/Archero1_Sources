using System.Collections.Generic;
using Activity.Anniversary.Exchange.Data;
using UnityEngine;

public class SpriteManager
{
	public static Dictionary<CurrencyType, string> PropPath;

	public const string UICommon_Common_Currency = "CommonCurrency";

	public const string UICommon_Common_Equip = "CommonEquip";

	public const string ATLAS_UICOMMON = "uicommon";

	public const string ATLAS_CurrencyRandom = "CurrencyRandom";

	public const string ATLAS_SantaComp = "Santa2023";

	public const string ATLAS_SHOPUI = "shopui";

	public const string ATLAS_NEWPLAY122 = "newplay122";

	private const string ATLAS_SHOPUINEW = "newshopui";

	public const string ATLAS_MAIN = "mainui";

	public const string ATLAS_BATTLEUIS = "battleuis";

	public const string ATLAS_EVENT_MAGICIAN = "event_magician";

	public const string ATLAS_GAMEOVER = "gameover";

	public const string ATLAS_BATTLEPASS = "BattlePass";

	public const string ATLAS_SKILLICON = "skillicon";

	public const string ATLAS_PROFESSION = "profession";

	public const string ATLAS_TREASURES = "treasuresicon";

	public const string ATLAS_HEROSKILLICON = "heroskillicon";

	public const string ATLAS_DAILYSKILLICON = "dailyskillicon";

	public const string ATLAS_SKINICON = "skinicon";

	public const string ATLAS_CARD = "cardui";

	public const string ATLAS_CARD_NEW = "carduinew";

	public const string ATLAS_CHARUI = "charui";

	public const string ATLAS_NewCHARUI = "newchar";

	public const string ATLAS_NewEquipUI = "newequipbg";

	public static readonly string ATLAS_HEROUI;

	public const string ATLAS_EQUIPS = "equips";

	public const string ATLAS_DRAGON = "Dragon";

	public const string ATLAS_DRAGON_SKILL = "dragonskill";

	public const string ATLAS_ATTRIBUTES_ICON = "AttributesIcon";

	public const string ATLAS_DRAGON_QUALITY = "DragonQuality";

	public const string ATLAS_DRAGON_QUALITY_BG = "DragonQualityBg";

	public const string ATLAS_FRAGMENTS = "Fragments";

	public const string ATLAS_PROPS = "Props";

	public const string ATLAS_MONSTER_BUFF = "MonsterBuff";

	public const string ATLAS_GEMS = "gems";

	public const string ATLAS_GEMS_UI = "gemsui";

	public const string ATLAS_EGG_ICON = "eggicon";

	public const string ATLAS_EGG_MONSTER_ICON = "EggMonsterIcon";

	private const string ATLAS_CARVING = "carvings";

	public const string ATLAS_HEROICON = "heroicon";

	public const string ATLAS_SUPERICON = "supericon";

	public const string ATLAS_TOWER = "Tower";

	public const string ATLAS_NEW_SEASON = "NewSeason";

	public const string ATLAS_PVE_SKILLICON = "PVESkillIcon";

	public const string ATLAS_PET_SKILLICON = "PetSkillIcon";

	public const string ATLAS_PVESEAASONTOPIC = "pveseaasontopic";

	public const string ATLAS_MAP = "map";

	public const string ATLAS_PLAYER = "player";

	public const string ATLAS_HEADFRAME = "headframe";

	public const string ATLAS_ACTIVITY_PLAY = "activityplay";

	public const string ATLAS_PVP_GUIDE = "pvpguide";

	public const string ATLAS_Medal = "medal";

	public const string ATLAS_EquipSkin = "equipskin";

	public const string ATLAS_WeaponSkin = "weaponskinicon";

	public const string ATLAS_Pet = "peticon";

	public const string ATLAS_GUILD = "GuildUI";

	public const string ATLAS_ANNIVERSARYEXCHANGE = "activityanniversary";

	public const string ATLAS_ANNIVERSARYEXCHANGEBG = "activityanniversarybg";

	public const string ATLAS_TOWER_DEFENSE = "towerdefense";

	private const string Camp = "camp";

	public const string ATLAS_TREASURE_MAP = "SailingTreasureMap";

	public const string ATLAS_ArtifactIcon = "artifacticon";

	public const string ATLAS_ArtifactActivity = "artifactactivity";

	public const string ATotem_Icon = "totem";

	public static Sprite GetUICommon(string name)
	{
		return null;
	}

	public static Sprite GetSantaCompSprite(string name)
	{
		return null;
	}

	public static Sprite GetVipBg(int lv)
	{
		return null;
	}

	public static Sprite GetCurrencyRandom(string name)
	{
		return null;
	}

	public static Sprite GetShopUI(string name)
	{
		return null;
	}

	public static Sprite GetShopUINew(string name)
	{
		return null;
	}

	private static string GetRandomCarvingPath(int type)
	{
		return null;
	}

	public static Sprite GetRandomCarving(int type)
	{
		return null;
	}

	public static Sprite GetUICommonCurrency(CurrencyType type)
	{
		return null;
	}

	public static Sprite GetRandomEquipQuality(int quality)
	{
		return null;
	}

	public static Sprite GetMain(string name)
	{
		return null;
	}

	public static Sprite GetBattle(string name)
	{
		return null;
	}

	public static Sprite GetEventMagician(string name)
	{
		return null;
	}

	public static Sprite GetGameOver(string name)
	{
		return null;
	}

	public static Sprite GetBattlePass(string name)
	{
		return null;
	}

	public static Sprite GetSkillIcon(int id)
	{
		return null;
	}

	public static Sprite GetProfessionIcon(string name)
	{
		return null;
	}

	public static Sprite GetTreasuresIcon(int id)
	{
		return null;
	}

	public static Sprite GetTreasuresIcon(string key)
	{
		return null;
	}

	public static Sprite GetHeroSkillIcon(int id)
	{
		return null;
	}

	public static Sprite GetDailySkillIcon(int id)
	{
		return null;
	}

	public static Sprite GetSkillIconByID(int skillid)
	{
		return null;
	}

	public static Sprite GetSkinItemIcon(int id)
	{
		return null;
	}

	public static Sprite GetCharSkinIcon(int skid)
	{
		return null;
	}

	public static Sprite GetCard(int id)
	{
		return null;
	}

	public static Sprite GetRune(string id)
	{
		return null;
	}

	public static Sprite GetCard(string value)
	{
		return null;
	}

	public static Sprite GetCardNew(string value)
	{
		return null;
	}

	public static Sprite GetCharUI(int id)
	{
		return null;
	}

	public static Sprite GetCharUI(string value)
	{
		return null;
	}

	public static Sprite GetNewCharUI(string value)
	{
		return null;
	}

	public static Sprite GetNewEquipUI(string value)
	{
		return null;
	}

	public static Sprite GetHeroUI(string value)
	{
		return null;
	}

	public static Sprite GetHeroUI(int id)
	{
		return null;
	}

	public static Sprite GetGamblingUI(string value)
	{
		return null;
	}

	public static Sprite GetEquip(int equipid)
	{
		return null;
	}

	public static Sprite GetEquip(string value)
	{
		return null;
	}

	public static Sprite GetDragonIcon(int equipId)
	{
		return null;
	}

	private static string getDragonQualitySuffix(int quality)
	{
		return null;
	}

	public static Sprite GetDragonQualityHexagonBg(int quality)
	{
		return null;
	}

	public static Sprite GetDragonQualityCircle(int quality)
	{
		return null;
	}

	public static Sprite GetDragonFront(int equipId)
	{
		return null;
	}

	public static Sprite GetDragonSkillIcon(int equipId, int skillSlotIndex)
	{
		return null;
	}

	public static Sprite GetDragonRarity(int dragonRarity)
	{
		return null;
	}

	public static Sprite GetAttributeIcon(string attrName)
	{
		return null;
	}

	public static Sprite GetFragments(int id)
	{
		return null;
	}

	public static Sprite GetFragments(string key)
	{
		return null;
	}

	public static Sprite GetProps(int id)
	{
		return null;
	}

	private static Sprite GetProps(string key)
	{
		return null;
	}

	public static Sprite GetMonsterBuff(int id)
	{
		return null;
	}

	public static Sprite GetMonsterBuff(string name)
	{
		return null;
	}

	public static Sprite GetRelicsIcon(int reid)
	{
		return null;
	}

	public static Sprite GetGem(int gemid)
	{
		return null;
	}

	public static Sprite GetGemUI(string key)
	{
		return null;
	}

	public static Sprite GetGem(string value)
	{
		return null;
	}

	public static Sprite GetEggIcon(int id)
	{
		return null;
	}

	public static Sprite GetEggMonsterIcon(int id)
	{
		return null;
	}

	public static Sprite GetEggIcon(string id)
	{
		return null;
	}

	public static Sprite GetCarvingIcon(int id)
	{
		return null;
	}

	public static Sprite GetHeroIcon(int id)
	{
		return null;
	}

	public static Sprite GetSuperIcon(int id)
	{
		return null;
	}

	public static Sprite GetShopCharacter(string key)
	{
		return null;
	}

	private static string getIDString(int id)
	{
		return null;
	}

	public static Sprite GetTowerIcon(string value)
	{
		return null;
	}

	public static Sprite GetNewSeasonIcon(string value)
	{
		return null;
	}

	public static Sprite GetPVESkillIcon(string value)
	{
		return null;
	}

	public static Sprite GetPetSkillIcon(int skiId)
	{
		return null;
	}

	public static Sprite GetPveSeaasonTopicIcon(string value)
	{
		return null;
	}

	public static Sprite GetMap(string spriteName)
	{
		return null;
	}

	public static Sprite GetPlayerIcon(string value)
	{
		return null;
	}

	public static Texture GetTDMiniMap(string value)
	{
		return null;
	}

	public static Sprite GetPlayerIcon(int id)
	{
		return null;
	}

	public static Sprite GetHeadFrame(string value)
	{
		return null;
	}

	public static Sprite GetHeadFrame(int id)
	{
		return null;
	}

	public static Sprite GetActivityPlayIcon(string value)
	{
		return null;
	}

	public static Sprite GetPvpGuideIcon(string value)
	{
		return null;
	}

	public static Sprite GetMedalIcon(string value)
	{
		return null;
	}

	public static Sprite GetEquipSkinIcon(string value)
	{
		return null;
	}

	public static Sprite GetWeaponSkinIcon(string value)
	{
		return null;
	}

	public static Sprite GetPetIcon(string value)
	{
		return null;
	}

	public static Sprite GetGuildSprite(string value)
	{
		return null;
	}

	public static Sprite GetWaterMap(string spriteName)
	{
		return null;
	}

	public static string GetStylePrefix()
	{
		return null;
	}

	public static Sprite GetAnniversaryExchangeIcon(string spriteName, bool isBg = false)
	{
		return null;
	}

	public static Color GetAnniversaryExchangeColor(ExchangeThemeType type)
	{
		return default;
	}

	public static Sprite GetTowerDefenseIcon(string name)
	{
		return null;
	}

	public static Sprite GetChainGift(string name)
	{
		return null;
	}

	public static Sprite GetCampTalentSprite(string value)
	{
		return null;
	}

	public static Sprite GetNewUICommon(string value)
	{
		return null;
	}

	public static Sprite GetUICommonExtra(string value)
	{
		return null;
	}

	public static Sprite GetCampTile(string value)
	{
		return null;
	}

	public static Sprite GetCampTileBoss(string value)
	{
		return null;
	}

	public static Sprite GetCampGift(string value)
	{
		return null;
	}

	public static Sprite GetCampIcon(string value)
	{
		return null;
	}

	public static Sprite GetCampTalentAttributeIcon(string value)
	{
		return null;
	}

	public static Sprite GetCampRankSprite(string value)
	{
		return null;
	}

	public static Sprite GetCampKingScrambleSprite(string value)
	{
		return null;
	}

	public static Sprite GetFarmCardIcon(string value)
	{
		return null;
	}

	public static Sprite GetLuckyWheelSprite(string spriteName)
	{
		return null;
	}

	public static Sprite GetMonthlyCardSprite(string spriteName)
	{
		return null;
	}

	public static Sprite GetChristmas2023Sprite(string spriteName)
	{
		return null;
	}

	public static Sprite GetManorSprite(string spriteName)
	{
		return null;
	}

	public static Sprite GetFishingSprite(string spriteName)
	{
		return null;
	}

	public static Sprite GetFishingIconSprite(string spriteName)
	{
		return null;
	}

	public static Sprite GetFishingTexture(string name)
	{
		return null;
	}

	public static Sprite GetCampTownSkinIcon(string spriteName)
	{
		return null;
	}

	public static Sprite GetCampTownSkinTexture(int value)
	{
		return null;
	}

	public static Sprite GetNewSkinPreviewIcon(string spriteName)
	{
		return null;
	}

	public static Sprite GetPVERankRewardDetailIcon(string spriteName)
	{
		return null;
	}

	public static Sprite GetAct5thHuntingSprite(string spriteName)
	{
		return null;
	}

	public static Sprite GetAct5thHuntingAnimalSprite(string spriteName)
	{
		return null;
	}

	public static Sprite GetAct5thHuntingTalentSprite(string spriteName)
	{
		return null;
	}

	public static Sprite GetNewPlay125WeaponIcon(string spriteName)
	{
		return null;
	}

	public static Sprite GetNewPlay126Icon(string spriteName)
	{
		return null;
	}

	public static Sprite GetFirstCharge(string name)
	{
		return null;
	}

	public static Sprite GetHellUI(string name)
	{
		return null;
	}

	public static Sprite GetActIslandVSUI(string name)
	{
		return null;
	}

	public static Sprite GetBagUISkin(string name)
	{
		return null;
	}

	public static Sprite GetNewBp(string name)
	{
		return null;
	}

	public static void RequestAtlas(string tag)
	{
	}

	public static Sprite GetCampPreIcon(string name)
	{
		return null;
	}

	public static Sprite GetCampTeachIcon(string name)
	{
		return null;
	}

	public static Sprite GetSailingGift(string value)
	{
		return null;
	}

	public static Sprite GetSailingIcon(string picName)
	{
		return null;
	}

	public static Sprite GetSailingShipIcon(string picName)
	{
		return null;
	}

	public static Sprite GetSailingShipBattleIcon(string name)
	{
		return null;
	}

	public static Sprite GetSailingTalentSprite(string value)
	{
		return null;
	}

	public static Sprite GetSailingTalentAttributeIcon(string value)
	{
		return null;
	}

	public static Sprite GetSailingBPIcon(string picName)
	{
		return null;
	}

	public static Sprite GetTreasureMap(string key)
	{
		return null;
	}

	public static Sprite GetSailingMilitaryRankIcon(int lv)
	{
		return null;
	}

	public static Sprite GetSailingMilitarySubRankIcon(int lv)
	{
		return null;
	}

	public static Sprite GetSailingMilitaryRankIcon(string name)
	{
		return null;
	}

	public static Sprite GetSailingGhostFleetIcon(string name)
	{
		return null;
	}

	public static Sprite GetSailingTurnIcon(string name)
	{
		return null;
	}

	public static Sprite GetArtifactIcon(string value)
	{
		return null;
	}

	public static Sprite GetArtifactActivity(string value)
	{
		return null;
	}

	public static Sprite GetTotemIcon(string value)
	{
		return null;
	}

	public static Sprite GetWeaponColorIcon(string name)
	{
		return null;
	}

	public static Sprite GetWeaponSkinLevelUpIcon(string name)
	{
		return null;
	}

	public static Sprite GetActiveBpIcon(string name)
	{
		return null;
	}

	public static Sprite GetBadgeIcon(string picName)
	{
		return null;
	}

	public static Sprite GetBadgeBagIcon(int bagId)
	{
		return null;
	}

	public static Sprite GetBadgeCardIcon(int cardId)
	{
		return null;
	}

	public static Sprite GetActivity7thAnniversaryIcon(string picName)
	{
		return null;
	}
}
