using UnityEngine;

public class SkillAlone1981 : SkillAloneBase
{
	private float radius;

	private float dmgScale;

	private int triggerExplodeBulletID;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void HitAction(EntityBase attackTarget, HitStruct hs, HittedData hd)
	{
	}

	private void CastSkill(EntityBase self, Vector3 targetPos, int bulletID)
	{
	}
}
