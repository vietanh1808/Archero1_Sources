using UnityEngine;

public class SkillAlone9021 : SkillAloneBase
{
	private float AttackRisePerPercent;

	private float HitReducePerPercent;

	private float AddBuffHPPercent;

	private float LowestHPPercent;

	private int BuffId;

	private int EffLevel1;

	private int EffLevel2;

	private int EffLevel3;

	private float preAddAttack;

	private float preAddHitReduce;

	private int curBuffLevel;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnKillAction(EntityBase entity, Vector3 HittedDirection, HitStruct hs)
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void UpdateAttr()
	{
	}

	private void UpdateBuffEffLevel(int level)
	{
	}
}
