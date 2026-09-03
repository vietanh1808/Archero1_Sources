using System;
using System.Collections.Generic;
using HeroCapybara;
using TableTool;
using UnityEngine;

public class BulletManager
{
	public class WeaponElement
	{
		public const int Normal = 0;

		public const int Thunder = 1;

		public const int Fire = 2;

		public const int Ice = 3;

		public const int Poison = 4;

		public const int Rock = 5;

		public const int Iron = 6;

		public const int Meteor = 7;

		public const int Virtual = 8;

		public const int Skull = 9;

		public const int Sword = 10;

		public const int Shadow = 11;

		public const int Emerald = 12;

		public const int Tyrant = 13;

		public const int IceThunderDragon = 14;

		public const int SingleSword = 1001;

		public const int DuelSword = 1002;

		public const int PVPBullet = 1003;

		public const int Katana = 1004;

		public const int EnergyCrossBow = 1005;

		public const int MelindaSkillBullet = 1006;

		public const int NearLeftFist = 1007;

		public const int NearRightFist = 1008;

		public const int NearHammer = 1009;

		public const int HammerFlash = 1010;

		public const int RotateHammer = 1011;

		public const int LanceShieldMelee = 1012;

		public const int LanceShieldCannon = 1013;

		public const int LanceShieldMeleeRush = 1014;

		public const int LanceShieldLaserReflect = 1015;

		public const int TridentDragon = 1016;

		public const int TridentTornado = 1017;

		public const int TridentDaggerLeft = 1018;

		public const int TridentDaggerRight = 1019;

		public const int TridentSweep = 1020;
	}

	private Action OnCache;

	public const int FlashChainBulletID = 9039;

	public int index;

	private List<int> meteorIds;

	private List<int> flySwordIds;

	private List<int> arthorFlySwordIds;

	private List<int> flashIds;

	private List<int> hammerRemoteIds;

	public int ZeusFallThunderBulletId;

	public const int ZeusSecondFallThunderBulletId = 1559;

	public const int ZeusThunderBeamBulletId = 1551;

	public const int ZeusRevengeThunderBulletId = 1552;

	public const int ZeusThunderSpearBulletId = 1554;

	public const int ZeusShieldHammerBulletId = 1555;

	public const int DeerMoonFallBulletId = 1560;

	public const int DemogorgonBulletId = 1564;

	public const int DemogorgonEnhancedBulletId = 1565;

	public const int DemogorgonPVPBulletId = 21564;

	public const int UnrealZeusBulletId = 1557;

	public const int UnrealZeusPVPBulletId = 21557;

	public const float ZeusFallThunderBulletPosY = -1.39f;

	public const float MoonFallBulletPosY = 0.5f;

	public const int MelindaHeroSkillBulletId = 7201;

	public const int ArthurImpulseBulletId = 1596;

	public int TridentGodSweepId;

	private List<int> hammerMeleeIds;

	private List<int> LanceShieldMeleeIds;

	private List<int> LanceShieldWithoutSkillMeleeIds;

	private List<int> LanceShieldRemoteIds;

	private List<int> LanceCannonIds;

	private List<int> TridentIds;

	private List<int> DoubleDaggerIds;

	public const int HeroCapybaraMeteorBulletId = 1578;

	public float[] HeroCapybaraMeteorEffectDegrees;

	public float HeroCapybaraSwordRadius;

	public int[] HeroCapybaraSwordDegrees;

	private List<int> flashChainBulletIds;

	private int[] katanaSpecialBullets;

	private int[] swordSpecialBulltets;

	public int WuKongTCPBulletId;

	private int[] fistSpecialBullets;

	private int[] CannonBulletIds;

	public int MaxHeroCapybaraSwordCount => 0;

	public string GetBulletModelString(Equip_WeaponSkin weaponSkinMeta, Weapon_weapon m_Data)
	{
		return null;
	}

	public BulletBase Get(int bulletID)
	{
		return null;
	}

	public void Cache(int bulletID, BulletBase b)
	{
	}

	public void Remove(int bulletID, BulletBase b)
	{
	}

	public void Clear(int bulletID)
	{
	}

	public void ClearPool()
	{
	}

	public void CacheAll()
	{
	}

	public BulletSlopeBase CreateSlopeBullet(EntityBase entity, int BulletID, Vector3 startpos, Vector3 endpos)
	{
		return null;
	}

	public BulletBase CreateBullet(EntityBase entity, int BulletID, Vector3 pos, float rota)
	{
		return null;
	}

	public BulletBase CreateBulletInternal(EntityBase entity, int BulletID, Vector3 pos, float rota, bool clear)
	{
		return null;
	}

	public BulletBase CreateBulletInternalWithParam(EntityBase entity, int BulletID, Vector3 pos, float rota, bool clear, object param)
	{
		return null;
	}

	public BulletBase CreateBulletInternal(EntityBase entity, int BulletID, Vector3 pos, Quaternion rota, bool clear, Transform parent = null)
	{
		return null;
	}

	public BulletBase CreateBulletInternalUsingLocal(EntityBase entity, int BulletID, Vector3 pos, Quaternion rota, bool clear, Transform parent)
	{
		return null;
	}

	public BulletBase CreateCallBullet(EntityBase entity, int BulletID, int callid, Vector3 startpos, Vector3 endpos)
	{
		return null;
	}

	public BulletBase CreateBullet(EntityBase entity, int BulletID)
	{
		return null;
	}

	public BulletBase CreateBullet(EntityBase entity, int BulletID, Vector3 pos, float rota, float speedRatio)
	{
		return null;
	}

	public void Release()
	{
	}

	public bool IsZeusFallThunderBullet(int bulletId)
	{
		return false;
	}

	public bool IsZeusShieldHammerBullet(int bulletId)
	{
		return false;
	}

	public bool IsZeusThunderSpearBullet(int bulletId)
	{
		return false;
	}

	public bool IsZeusThunderBeamBullet(int bulletId)
	{
		return false;
	}

	public bool IsFlashBulletIds(int bulletId)
	{
		return false;
	}

	public bool IsHammerRomoteIds(int bulletId)
	{
		return false;
	}

	public bool IsFlamingoMainBullet(int bulletId)
	{
		return false;
	}

	public bool IsHammerMeleeBullets(int bulletId)
	{
		return false;
	}

	public bool IsLanceShieldMeleeBullets(int bulletId)
	{
		return false;
	}

	public bool IsLanceShieldWithoutSkillMeleeBullets(int bulletId)
	{
		return false;
	}

	public bool IsLanceShieldRemoteBullets(int bulletId)
	{
		return false;
	}

	public bool IsLanceCannonBullets(int bulletId)
	{
		return false;
	}

	public bool IsTridentBullets(int bulletId)
	{
		return false;
	}

	public bool IsDoubleDaggerBullets(int bulletId)
	{
		return false;
	}

	public bool IsFlySwordBullet(int bulletId)
	{
		return false;
	}

	public bool IsArthorFlySword(int bulletId)
	{
		return false;
	}

	public bool IsBulletMeteorOrAerolite(int bulletId)
	{
		return false;
	}

	public bool IsHeroCapybaraMeteorBullet(int bulletId)
	{
		return false;
	}

	public bool IsFlashChainBullet(int bulletId)
	{
		return false;
	}

	public bool IsIceThunder_IceBullet(int bulletId)
	{
		return false;
	}

	public bool IsValidBullet(HitStruct hs)
	{
		return false;
	}

	public bool IsLightBullet(EntityBase entityBase, int bulletID)
	{
		return false;
	}

	public bool IsIceThunder_ThunderBullet(int bulletId)
	{
		return false;
	}

	public bool IsBulletMeteor(int bulletId)
	{
		return false;
	}

	public bool IsCatBullet(int bulletId)
	{
		return false;
	}

	public List<int> GetBulletMeteorIds()
	{
		return null;
	}

	public int GetLightBullet(EntityBase entityBase)
	{
		return 0;
	}

	public bool IsPlayerBulletByHitStruct(HitStruct hitStruct)
	{
		return false;
	}

	public bool IsPlayerBullet(int bulletId)
	{
		return false;
	}

	public BulletBase CreateFlashChainBullet(EntityBase m_Entity, Vector3 bulletDir, float initRatio = 1f, float decreaseRatio = 0.8f, float minRatio = 0.5f, int initEjectCount = 0, int bulletId = 9039)
	{
		return null;
	}

	private float getFlashChainBulletCDTime()
	{
		return 0f;
	}

	public bool IsNewPlay125SickleBullet(int bulletID)
	{
		return false;
	}

	public bool IsNewPlay125SwordBullet(int bulletID)
	{
		return false;
	}

	public bool IsNewPlay125BoomerangBullet(int bulletID)
	{
		return false;
	}

	public bool IsNewPlay125DaggerBullet(int bulletID)
	{
		return false;
	}

	public bool IsNewPlay125WandBullet(int bulletID)
	{
		return false;
	}

	public bool IsNewPlay125ElfBullet(int bulletID)
	{
		return false;
	}

	public GameObject CreateCapybaraSword()
	{
		return null;
	}

	public CapybaraSword CreateCapybaraSword(Transform parent, int swordDegree, int _index, float swordRadius)
	{
		return null;
	}

	public bool IsCannonBullet(int id)
	{
		return false;
	}

	public void SendBlackBallBullet(EntityBase sender, Vector3 targetPos, float blackBallStayLastTime, float blackHoleBulletHitEnemyInterval, bool needTryReSendBlackHole, bool isPVEMode, bool isSelf)
	{
	}

	public BulletBase SendMonsterKingFlySword(EntityBase sender, Vector3 startpos, float angle, float flySwordRatio, float flySwordInheritPlayerCritScale, float flySwordInheritPlayerCritValueScale, float flySwordExtraCritValue, float flySwordCritMaxValue)
	{
		return null;
	}
}
