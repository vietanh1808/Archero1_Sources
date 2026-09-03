using System.Collections.Generic;

public class SkillAlone1670 : SkillAloneBase
{
	private List<int> m_listBullets;

	private float m_fRatio;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private float OnCalCritRate(HitStruct hs, EntityBase entity)
	{
		return 0f;
	}
}
