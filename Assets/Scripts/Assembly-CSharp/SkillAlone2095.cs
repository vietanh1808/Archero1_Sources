using UnityEngine;

public class SkillAlone2095 : SkillAlone1014
{
	private Vector3? skillEffectOriginScale;

	private Transform fireEffect;

	private float SkillRadius => 0f;

	protected float FireLastTime => 0f;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override GameObject CreateSkillAlone()
	{
		return null;
	}

	protected override void CreateSkillOne(GameObject curSkillOne)
	{
	}
}
