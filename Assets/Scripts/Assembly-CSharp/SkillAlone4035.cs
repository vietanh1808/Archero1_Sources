using System.Collections.Generic;
using UnityEngine;

public class SkillAlone4035 : SkillAlone1033_Net
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

	protected override bool CanCallOne(EntityBase entity)
	{
		return false;
	}

	protected override CreatePartBodyCommand CreatePartBodyCommand(in Vector3 pos)
	{
		return null;
	}

	protected override void CallOne(EntityBase entity)
	{
	}

	private void OnRemoveEvent(EntityPartBodyBase entity, int id)
	{
	}
}
