using System.Collections.Generic;

public class SailingShipBattleMsgItemData
{
	public long CurTime { get; set; }

	public SailingShipBattleFighter Fighter { get; set; }

	public SailingShipBattleRecordType RecordType { get; set; }

	public int SendHitSlotPos { get; set; }

	public int HitTargetSlotPos { get; set; }

	public SailingShipBattleAttributeData AttributeData { get; set; }

	public SailingShipBattleBuffData BuffData { get; set; }

	public List<string> RemoveBuffData { get; set; }

	public Dictionary<string, long> EffectData { get; set; }

	public bool IsCrit => false;

	public float BulletFlyTime => 0f;

	public static SailingShipBattleMsgItemData Create(long curTime, SailingShipBattleFighter fighter, SailingShipBattleRecordType recordType, int sendHitSlotPos, int hitTargetSlotPos, SailingShipBattleAttributeData attributeData, SailingShipBattleBuffData buffData, List<string> removeBuffData, Dictionary<string, long> effectData)
	{
		return null;
	}

	public bool IsNeedPlayBattleMsg(float curTime)
	{
		return false;
	}

	private float GetBulletFlyTime()
	{
		return 0f;
	}

	public float GetBulletFinalHitDamage()
	{
		return 0f;
	}

	public float GetBulletHitCritScale()
	{
		return 0f;
	}

	public List<(SailingShipBattleFighter, int, long)> GetRecoverDurabilityData()
	{
		return null;
	}
}
