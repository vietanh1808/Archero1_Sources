using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;

public class SailingMonsterCommingMgr : SingletonNet<SailingMonsterCommingMgr, CReqShipBattleSeasonFire, CRespShipBattleSeasonFire>
{
	private List<SailingMonsterAchievementData> achievementDatas;

	private long PreTime;

	private long StartTime;

	private long attackEndTime;

	private long showEndTime;

	public int TotalDamage;

	public int CrtStage;

	public List<SailingRankShowItemData> RankShowData;

	public const float AniMCannonFlyTime = 0.55f;

	public const float AniMCannonFlyXStrength = 120f;

	public const float AniMCannonSendInterval = 0.2f;

	public const float AniShakeTargetTime = 1.2f;

	public const float AniShakeTargetStrength = 14f;

	public const int MCannonPartID = 8;

	public const float MCannonCountClickWaitTime = 0.2f;

	public const float MCannonCountChangeMaxTime = 0.4f;

	public const float MCannonCountChangeMaxSpeed = 7f;

	public const int ArrowBuyOneCount = 1;

	public const int ArrowBuyMoreCount = 10;

	public const int ArrowDamageDataConfigID = 3419;

	public const int ArrowBPAddDamageTypeID = 7;

	public const int ArrowBPGatherAllResourceID = 9;

	public long ShowEndTime => 0L;

	public long AttackEndTime => 0L;

	public bool IsOpen => false;

	public bool IsAttackOpen => false;

	public bool IsRewardShow => false;

	public bool IsPreAttack => false;

	public long PreLeftTime => 0L;

	public long AttackLeftTime => 0L;

	public long EndLeftTime => 0L;

	public int Rank { get; private set; }

	public long RankValue { get; private set; }

	public List<SailingMonsterShipAutoFireData> AutoFireData { get; private set; }

	public float MCannonBaseDamage => 0f;

	public (float, float) ArrowCriticalProb => default;

	public float OneNormalMCannonDiamondPrice => 0f;

	public float CanBuyNormalMCannonMaxCount => 0f;

	public float SendMCannonMaxCountOnce => 0f;

	private int MCannonHaveBuyCount { get; set; }

	private long MCannonLastBuyTime { get; set; }

	protected override string Name => null;

	public (float, float) ArrowRangeAddDamage(bool isCritical)
	{
		return default;
	}

	public float ArrowDamage(SailingMCannonType type, bool isCritical)
	{
		return 0f;
	}

	public (float, float) ArrowRangeDamage(SailingMCannonType type, bool isCritical)
	{
		return default;
	}

	public float MCannonShowDamage(SailingMCannonType type)
	{
		return 0f;
	}

	public float MCannonBaseDamageAdd(SailingMCannonType type)
	{
		return 0f;
	}

	public void UpdateMCannonData(int haveBuyCount, long buyTime)
	{
	}

	public long GetArrowLastBuyTime()
	{
		return 0L;
	}

	private (float, float) GetArrowRangeDamage(SailingMCannonType type, bool isCritical)
	{
		return default;
	}

	private float GetArrowMinDamage(SailingMCannonType type, bool isCritical)
	{
		return 0f;
	}

	private float GetArrowMaxDamage(SailingMCannonType type, bool isCritical)
	{
		return 0f;
	}

	private float GetMCannonShowDamage(SailingMCannonType type)
	{
		return 0f;
	}

	private (float, float) GetArrowCriticalProb()
	{
		return default;
	}

	private (float, float) GetArrowCriticalRangeDamage()
	{
		return default;
	}

	private (float, float) GetArrowUnCriticalRangeDamage()
	{
		return default;
	}

	private (int, int) GetArrowAttackDamage(SailingMCannonType arrowType, (int, int) statusCount)
	{
		return default;
	}

	private float GetArrowDamage(SailingMCannonType type, bool isCritical)
	{
		return 0f;
	}

	public List<SailingMonsterMCannonDamageData> GetArrowDamageData(List<SailingMonsterMCannonDamageData> arrowDamageData, int realIronArrowCount, int realGoldArrowCount, int serverTotalDamage)
	{
		return null;
	}

	private (int, int) GetArrowStatusCount(int curArrowTypeAllCount)
	{
		return default;
	}

	private List<SailingMonsterMCannonDamageData> GetCampTileArrowDamageData(SailingMCannonType arrowType, (int, int) arrowCount, (int, int) arrowAllDamage, int diffDamage)
	{
		return null;
	}

	protected override void Init()
	{
	}

	public void InitAutoFireData()
	{
	}

	protected override void Clear()
	{
	}

	protected override CReqShipBattleSeasonFire RequestPacket()
	{
		return null;
	}

	public override SendRequestTime RequestTime()
	{
		return SendRequestTime.None;
	}

	protected override bool AllowBurstRequest()
	{
		return false;
	}

	protected override bool RequestCond()
	{
		return false;
	}

	protected override void Response(NetResponse response, CRespShipBattleSeasonFire data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	private bool ValidResponse(NetResponse response, Action<bool> action)
	{
		return false;
	}

	private void showRewardWindow(STCommonData stcd, int type, Action action = null)
	{
	}

	public void ReqSailingMonsterMCannonFire(int normalCount, int premiumCount, Action<CRespShipBattleSeasonFire> success = null, Action<CRespShipBattleSeasonFire> failure = null)
	{
	}

	public void ReqSailingMonsterBuyMCannon(int buyCount, Action success = null, Action failure = null)
	{
	}

	public void ReqSailingMonsterAchievement(int id, Action<bool> action = null)
	{
	}

	private void SyncAchievementData(STCommonAchievementData[] aData)
	{
	}

	private void SyncRankShowData(STShipBattleSeasonFireRankInfo rData)
	{
	}

	public List<SailingMonsterAchievementData> GetAchievementDatas()
	{
		return null;
	}

	public int GetMCannonHaveBuyCount()
	{
		return 0;
	}

	public void PlayAni(CRespShipBattleSeasonFire response, int totalDamage, int oldLevel, List<SailingMonsterMCannonDamageData> damageData)
	{
	}

	private void SendPlayAni(CRespShipBattleSeasonFire response, int oldLevel, List<SailingMonsterMCannonDamageData> damageData)
	{
	}
}
