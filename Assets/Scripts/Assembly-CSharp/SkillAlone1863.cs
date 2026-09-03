using UnityEngine;

public class SkillAlone1863 : SkillAlonePetBase
{
	private float atkPercent;

	protected float buffTime;

	private float radius;

	private int debuffId;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	protected virtual void onShieldDestroyed(CommonHitCtrl hitCtrl)
	{
	}

	protected virtual void OnHitEnemy(EntityBase enemy)
	{
	}

	protected virtual float getBuffTime(EntityBase enemy)
	{
		return 0f;
	}

	private void playExplodeEffect(Vector3 explosionCenter)
	{
	}
}
