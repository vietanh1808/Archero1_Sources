using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2231 : SkillAlone2230
{
	private int blackHoleCreateCount;

	private float createblackHoleRadius;

	private float blackHoleRadius;

	private float blackHoleBulletHitEnemyInterval;

	private float blackHoleBulletDmgScale;

	public const int SkillEffectID = 2231;

	public const int BlackHoleBulletID = 5380;

	private List<SkillAlone2231GoodCtrl> allCreateSkill;

	protected override void OnInstall()
	{
	}

	protected override void SkillStart()
	{
	}

	protected override void SkillClear()
	{
	}

	private Vector3 CalcPoint(float radius, float angleDegrees)
	{
		return default;
	}
}
