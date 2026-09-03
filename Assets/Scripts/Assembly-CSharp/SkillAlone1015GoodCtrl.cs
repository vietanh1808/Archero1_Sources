using UnityEngine;

public class SkillAlone1015GoodCtrl : EntityParentBase
{
	[SerializeField]
	private SkillAlone1015HitCtrl m_hitCtrl;

	public override void SetEntityParent(EntityBase entity)
	{
	}

	private void OnDisable()
	{
	}

	private void OnShieldHitPercentChanged(float value)
	{
	}
}
