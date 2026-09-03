using UnityEngine;

public class SkillAlone2142 : SkillAloneBase
{
	protected float sendFlySwordInterval;

	private float flySwordRatio;

	private float sendExponent;

	private float sendMax;

	private float flySwordInheritPlayerCritScale;

	private float flySwordInheritPlayerCritValueScale;

	private float flySwordExtraCritValue;

	private float flySwordCritMaxValue;

	private long clockIndex;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void CheckCastSkill()
	{
	}

	protected virtual BulletBase CreateFlySword(EntityBase sender, Vector3 startpos, float angle)
	{
		return null;
	}

	private void LoadSkill()
	{
	}

	private float CalcCreateInterval(float curInterval)
	{
		return 0f;
	}

	private void SendCreateFlySwordMsg(EntityBase sender, Vector3 startPos, float angle)
	{
	}

	private void SyncCreateFlySwordMsg(EntityBase sender, Vector3 startPos, float angle)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
