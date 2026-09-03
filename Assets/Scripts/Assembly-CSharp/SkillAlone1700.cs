using System.Collections.Generic;

public class SkillAlone1700 : SkillAlone1078
{
	private int[] CONFIG_BulletIds;

	private float CONFIG_DropRadius;

	private float CONFIG_BulletRadius;

	private int CONFIG_MinNum;

	private int CONFIG_MaxNum;

	private float CONFIG_HitRatio;

	private List<int> m_listSkillIds;

	private float m_fLastSlopeTime;

	protected override bool Condition => false;

	protected override int MinNum => 0;

	protected override int MaxNum => 0;

	protected override float DropRadius => 0f;

	protected override float HitRatio => 0f;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHit(EntityBase _entity, EElementType elementType)
	{
	}
}
