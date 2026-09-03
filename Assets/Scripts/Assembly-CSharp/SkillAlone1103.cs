using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1103 : SkillAloneBase
{
	private new const string Tag = "SkillAlone1103";

	private const string String_Time = "Time";

	private const string String_SameDamageReducePercent = "SameDamageReduce%";

	private Dictionary<EntityBase, float> m_dicOnHitTimes;

	private float m_fTime;

	private float m_fReducePercent;

	protected override void OnInstall()
	{
	}

	private float onHitAction(EntityBase entity, HitStruct hit)
	{
		return 0f;
	}

	private void onKillAction(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}

	protected virtual void Excute(string str)
	{
	}

	protected override void OnUninstall()
	{
	}
}
