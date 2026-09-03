using UnityEngine;

public class SkillAlone4001 : SkillAloneBase
{
	public const string OtherAttackPercent = "OtherAttack%";

	public const string ThunderRange = "Range";

	public const string EffectId = "EffectId";

	private float thunder_range;

	private float thunder_otherhit;

	private int effectId;

	protected override void OnInstall()
	{
	}

	private void Excute()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitWall(BulletBase bullet, Collider c)
	{
	}
}
