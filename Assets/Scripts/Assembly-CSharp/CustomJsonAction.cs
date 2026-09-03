using System;

public static class CustomJsonAction
{
	[Serializable]
	public class SyncSkill4087VO : CustomJsonActionVO
	{
		public long value;

		public long max;
	}

	[Serializable]
	public class SyncSkill4088VO : CustomJsonActionVO
	{
		public float x;

		public float z;
	}

	public class SyncSkill4089VO : CustomJsonActionVO
	{
		public int effectId;

		public int times;
	}

	public const string ADD_SKILL_ID = "AddSkillId";

	public const string ADD_OWL_ELF = "AddOwlElf";

	public const string REMOVE_OWL_ELF = "RemoveOwlElf";

	public const string REMOVE_OWL_ELF_BY_INDEX = "RemoveOwlElfByIndex";

	public const string ADD_PUMPKIN = "AddPumpkin";

	public const string CREATE_THUNDER = "CreateThunder";

	public const string CREATE_FLY_SWORD = "CreateFlySword";

	public const string CREATE_ENTITY_MONSTER = "CreateEntityMonster";

	public const string CREATE_BULLET = "CreateBullet";

	public const string CREATE_SPECIAL_ENTITY_ATTACK = "CreateSpecialEntityAttack";

	public const string CALL_ENTITY = "CallEntity";

	public const string SET_OBSTACLE_COLLIDER_ENABLE = "SetObstacleCollider";

	public const string FORCE_SYNC_POSITION = "ForceSyncPosition";

	public const string CREATE_BULLETS = "CreateBullets";

	public const string SYNC_DIZZY = "SyncDizzy";

	public const string ADD_ARCHERO_SHIELD = "AddArcheroShield";

	public const string ARCHERO_SHIELD_REBOUND_BULLET = "ArcheroShieldReboundBullet";

	public const string ANTI_CHEAT_OPPONENT_HIT = "AntiCheatOpponentHit";

	public const string ANTI_CHEAT_OPPONENT_ATTR = "AntiCheatOpponentAttr";

	public const string ANTI_CHEAT_OPPONENT_HP = "AntiCheatOpponentHp";

	public const string CREATE_CAT_BULLET = "CreateCatBullet";

	public const string SYNC_EXPLODE_EFFECT = "SyncExplodeEffect";

	public const string CREATE_BULLET_1194 = "CreateBullet1194";

	public const string SWORD_CHANGE_WEAPON = "SwordChangeWeapon";

	public const string DROP_CUSTOM_HP = "DropCustomHp";

	public const string DROP_HP = "DropHP";

	public const string DROP_MP = "DropMP";

	public const string BOMB_BULLET_CNT = "BOMB_BULLET_CNT";

	public const string CREATE_PART_BODY_1827 = "CREATE_PART_BODY_1827";

	public const string CREATE_SEA_HORSE_BULLET = "CREATE_SEA_HORSE_BULLET";

	public const string CREATE_MAP_SEA_HORSE_BULLET = "CREATE_MAP_SEA_HORSE_BULLET";

	public const string CREATE_TARANIS_SHIELD_BULLET = "CREATE_TARANIS_SHIELD_BULLET";

	public const string CREATE_TARANIS_CYCLONE_BULLET = "CREATE_TARANIS_CYCLONE_BULLET";

	public const string CREATE_TARANIS_SPEAR_BULLET = "CREATE_TARANIS_SPEAR_BULLET";

	public const string SYNC_ELAINE_SAKURA_COUNT = "SYNC_ELAINE_SAKURA_COUNT";

	public const string SYNC_MONKEY_HAIR_COUNT = "SYNC_MONKEY_HAIR_COUNT";

	public const string CREATE_SHADOW_WARRIOR = "CREATE_SHADOW_WARRIOR";

	public const string CREATE_SHINGEN_BULLET = "CREATE_SHINGEN_BULLET";

	public const string SYNC_SHINGEN_BULLET_CONFIG = "SYNC_SHINGEN_BULLET_CONFIG";

	public const string SYNC_CUMULATED_PERCENT_1548 = "SYNC_CUMULATED_PERCENT_1548";

	public const string SHARI_CURSED_STAFF = "SHARI_CURSED_STAFF";

	public const string SYNC_PVP_AURA_DESTROY = "SYNC_PVP_AURA_DESTROY";

	public const string SYNC_BULLET_1510 = "SYNC_BULLET_1510";

	public const string SYNC_THUNDER_BALL_LINES_1549 = "SYNC_THUNDER_BALL_LINES_1549";

	public const string CREATE_GUGU_BULLET = "CREATE_OWL_BULLET";

	public const string CREATE_BOBO_BEAM_BULLET = "CREATE_BOBO_BEAM_BULLET";

	public const string CREATE_SKILL_AXE_BULLET = "CREATE_SKILL_AXE_BULLET";

	public const string SYNC_PVP_ENTITY_SHOW_ACTIVITY = "SYNC_PVP_ENTITY_SHOW_ACTIVITY";

	public const string SYNC_VINE_MOVE = "SYNC_VINE_MOVE";

	public const string CREATE_TIGER_BULLETS = "CREATE_TIGER_BULLETS";

	public const string CREATE_WUKONG_STICK_BULLET = "CREATE_WUKONG_STICK_BULLET";

	public const string CREATE_WUKONG_SKILL_STICK_BULLET = "CREATE_WUKONG_SKILL_STICK_BULLET";

	public const string CREATE_CHICKEN_LEG = "CREATE_CHICKEN_LEG";

	public const string CREATE_1890_PART_BODY = "CREATE_1890_PART_BODY";

	public const string CREATE_COMMON_PART_BODY = "CREATE_COMMON_PART_BODY";

	public const string SYNC_ROTATE_CANDY = "SYNC_ROTATE_CANDY";

	public const string SYNC_DRAGGERS = "SYNC_DRAGGERS";

	public const string SYNC_CHRISTMAS_STAR = "SYNC_CHRISTMAS_STAR";

	public const string CREATE_ROTATE_STAR = "CREATE_ROTATE_STAR";

	public const string CREATE_INK_DRAGON = "CREATE_INK_DRAGON";

	public const string CREATE_DRAGON_SOUL = "CREATE_DRAGON_SOUL";

	public const string SYNC_DRAGON_EFFECT = "SYNC_DRAGON_EFFECT";

	public const string SYNC_DRAGON_WEAPON_EFFECT = "SYNC_DRAGON_WEAPON_EFFECT";

	public const string SYNC_LANTERN_KATANA_EFFECT = "SYNC_LANTERN_KATANA_EFFECT";

	public const string CREATE_GACHA_EGG_BULLET = "CREATE_GACHA_EGG_BULLET";

	public const string SYNC_ROTATE_RADISH = "SYNC_ROTATE_RADISH";

	public const string CREATE_RADISH_METEOR = "CREATE_RADISH_METEOR";

	public const string CREATE_GACHA_EGG = "CREATE_GACHA_EGG";

	public const string CLEAR_GACHA_EGG = "CLEAR_GACHA_EGG";

	public const string CREATE_LIGHTING = "CREATE_LIGHTING";

	public const string CREATE_LIGHTINGSHIELD = "CREATE_LIGHTINGSHIELD";

	public const string SYNC_STORMENERGY = "SYNC_STORMENERGY";

	public const string SYNC_HAMMERMELEEBULLET = "SYNC_HAMMERMELEEBULLET";

	public const string SYNC_ROTATE_HAMMER = "SYNC_ROTATE_HAMMER";

	public const string SYNC_LIGHT_BULLET = "SYNC_LIGHT_BULLET";

	public const string MakeAllComboEffectInvisible = "SkillAlone1804-MakeAllComboEffectInvisible";

	public const string CurComboEffectVisible = "SkillAlone1804-CurComboEffectVisible";

	public const string SyncHammerHit = "SkillAlone1806-HammerHit";

	public const string SyncFlashHit = "SkillAlone1806-FlashHit";

	public const string SyncSuperWuKongState = "1813-SyncSuperWuKongState";

	public const string SyncFallStickBullet = "1813-SyncFallStickBullet";

	public const string SyncLightedFlags = "1813-SyncLightedFlags";

	public const string SyncSkill1816Ignite = "SyncSkill1816Ignite";

	public const string SyncSkill1817Boomerang = "SyncSkill1817Boomerang";

	public const string SyncSkill4062Bullet = "SyncSkill4062Bullet";

	public const string SyncSkill4063Bullet = "";

	public const string SyncSkill1962 = "SyncSkill1962";

	public const string SyncZeusThunderBeam = "SyncZeusThunderBeam";

	public const string SyncZeusFallThunder = "SyncZeusFallThunder";

	public const string SyncZeusThunderSpear = "SyncZeusThunderSpear";

	public const string SyncCreateZeusShieldHammer = "SyncCreateZeusShieldHammer";

	public const string SyncZeusShieldHammerResetTime = "SyncZeusShieldHammerResetTime";

	public const string SyncZeusShieldHammerModelStr = "SyncZeusShieldHammerModelStr";

	public const string SyncZeusBeamController = "SyncZeusBeamController";

	public const string SyncZeusCallCloud = "SyncZeusCallCloud";

	public const string SyncSkill2102 = "SyncSkill2102";

	public const string SyncSkill2102_EffectShow = "SyncSkill2102_EffectShow";

	public const string SyncSkill1964 = "SyncSkill1964";

	public const string SyncSkill1965_2 = "SyncSkill1965_2";

	public const string SyncSkill1967 = "SyncSkill1967";

	public const string SyncSkill1989 = "SyncSkill1989";

	public const string SyncMapGoods = "SyncMapGoods";

	public const string SyncSkill1983 = "SyncSkill1983";

	public const string SyncSkill1983Gourd = "SyncSkill1983Gourd";

	public const string SyncCapybaraPushSword = "SyncCapybaraPushSword";

	public const string SyncCapybaraPopSword = "SyncCapybaraPopSword";

	public const string SyncCapybaraMeteorAttack = "SyncCapybaraMeteorAttack";

	public const string SyncSkill2076 = "SyncSkill2076";

	public const string SyncSkill4086_Eff = "SyncSkill4086_Eff";

	public const string SyncSkill4067 = "SyncSkill4067";

	public const string SyncSkill4068 = "SyncSkill4068";

	public const string SyncSkill2123PartBody = "SyncSkill2123PartBody";

	public const string SyncSkill2123PartBodyExplode = "SyncSkill2123PartBodyExplode";

	public const string SyncSkill2126Wave = "SyncSkill2126Wave";

	public const string SyncSkill4087 = "SyncSkill4087";

	public const string SyncSkill4088 = "SyncSkill4088";

	public const string SyncSkill4089 = "SyncSkill4089";

	public const string SyncSKill2137SendBlackBall = "SyncSKill2137SendBlackBall";

	public const string SyncSKill2140SendFlySword = "SyncSKill2140SendFlySword";

	public const string SyncSKill2142SendFlySword = "SyncSKill2142SendFlySword";

	public const string SyncSkill2179Thunder = "SyncSkill2179Thunder";

	public const string SyncSkill2180BuffSKill = "SyncSkill2180BuffSKill";

	public const string SyncSkill2180BombSKill = "SyncSkill2180BombSKill";

	public const string SyncSkill2191 = "SyncSkill2191";

	public const string SyncSkill2199 = "SyncSkill2199";

	public const string SyncSkill2200 = "SyncSkill2200";

	public const string SyncArtifactCastSkill = "SyncArtifactCastSkill";

	public const string SyncArtifactEndSkill = "SyncArtifactEndSkill";

	public const string SyncArtifact301CreateSkillItem = "SyncArtifact301CreateSkillItem";

	public const string SyncArtifact301SkillItemSendBullet = "SyncArtifact301SkillItemSendBullet";

	public const string SyncArtifact101CreateSkillBullet = "SyncArtifact101CreateSkillBullet";

	public const string SyncArtifact201CreateSkillStartBullet = "SyncArtifact201CreateSkillStartBullet";

	public const string SyncArtifact303SkillStart = "SyncArtifact303SkillStart";

	public const string SyncArtifact303CreateSendBullet = "SyncArtifact303CreateSendBullet";

	public const string SyncArtifactSkill2238CreateHole = "SyncArtifactSkill2238CreateHole";

	public const string SyncOtherPlayerPVPWorshipOK = "SyncOtherPlayerPVPWorship";

	public const string SyncSkill2283_1 = "SyncSkill2283_1";

	public const string SyncSkill2283_2 = "SyncSkill2283_2";
}
