using System.Collections.Generic;

public class HeroCapybaraSkillArgs
{
	public string TAG;

	public int[] SwordDegrees;

	public int MaxSwordCount;

	public float SwordRadius;

	public List<float> MeteorAtkPercents;

	public float AtkSwordRate;

	public float KillSwordRate;

	public float ReleaseSwordCD;

	public float ReleaseMeteorSwordCD;

	public float AtkSpeed2DeltaTimeRatio;

	public float MaxAtkSpeed2DeltaTimeRatio;

	public float ExplosionRadius;

	public float ExplosionAtkPercent;

	public int rewardSwordCount;

	public float reduceHP2AtkRatio;

	public float maxReduceHP2AtkPercent;

	public float dropHPRate;

	public int dropHPCount;

	public void ParseArgs(string[] ConfigArgs)
	{
	}

	private void checkIfValidMeteorAtkPercents()
	{
	}
}
