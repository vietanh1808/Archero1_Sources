using System.Collections.Generic;

public class SkillAlone1296 : SkillAloneBase
{
	private int m_nBuffId;

	private float m_fRate;

	private Dictionary<int, int> m_dicMapping;

	private int m_nDebuffId;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnCrit(EntityBase entity, long value)
	{
	}

	private (int, int) OnCreateCatBulletBefore(int id)
	{
		return default;
	}
}
