using UnityEngine;

public class SkillAlone1096 : SkillAloneBase_EffectSkill
{
	private const string String_Time = "Time";

	protected const string String_Weight = "Weight";

	private const string String_AddHp = "AddHp%";

	private int time;

	private int Weight;

	private int AddHp;

	private long maxHP;

	private float mRebornStartTime;

	private AnimationCurve mRebornCurve;

	private const float mRebornAllTime = 1.5f;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void Excute(string str)
	{
	}

	protected override void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	protected override void OnTrigger(EntityBase entity)
	{
	}

	private void RebornUpdate()
	{
	}

	private void OnRebornUpdate(float delta)
	{
	}
}
