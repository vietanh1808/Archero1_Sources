using System.Collections.Generic;

public class SkillAlone1253 : SkillAlone1033
{
	private List<int> m_listPartSkills;

	private int m_nWeaponId;

	private bool m_bPartBodyRemoved;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void Excute(string str, bool bExcute = false)
	{
	}

	protected override EntityPartBodyBase CallOne(EntityBase entity, bool CallPlusOne = false)
	{
		return null;
	}

	protected override bool CanCallOne(EntityBase entity)
	{
		return false;
	}

	private void OnRemoveEvent(EntityPartBodyBase entity, int id)
	{
	}
}
