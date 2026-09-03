using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1317 : SkillAloneBase
{
	private Dictionary<int, (int id, float dropRadius, float innerRadius, float innerhitratio, float outRadius, float outhitratio)> m_dicMapping;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnKillAction(EntityBase entity, Vector3 p, HitStruct hs)
	{
	}
}
