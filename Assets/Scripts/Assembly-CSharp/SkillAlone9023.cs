using UnityEngine;

public class SkillAlone9023 : SkillAloneBase
{
	private float CDTime;

	private float duration;

	private float durationAdd;

	private float durationMax;

	private int buffId;

	private float preBuffStartTime;

	private float preBuffEndTime;

	private float durationExra;

	private bool isBuffOn;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private float GetRealDuration()
	{
		return 0f;
	}

	private void OnKillAction(EntityBase entity, Vector3 HittedDirection, HitStruct hs)
	{
	}

	private void onHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}
}
