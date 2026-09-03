using UnityEngine;

public class SkillAlone2053GoodCtrl : EntityParentBase
{
	public static float laserIntervalTime;

	public static float laserDurationTime;

	public static float preLaserStartTime;

	[SerializeField]
	private SkillAlone2053HitCtrl m_hitCtrl;

	[SerializeField]
	public SkillAlone2053LaserHitCtrl m_laserHitCtrl;

	[SerializeField]
	private GameObject laserParent;

	public override void SetEntityParent(EntityBase entity)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnShieldHitPercentChanged(float value)
	{
	}

	private void Update()
	{
	}
}
