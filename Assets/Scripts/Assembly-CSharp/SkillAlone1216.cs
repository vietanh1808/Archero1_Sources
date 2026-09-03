using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1216 : SkillAloneBase
{
	private class KillRecoverParam
	{
		public int m_nWeaponId;

		public float m_fPercent;

		public float m_fAdd;
	}

	private Dictionary<int, KillRecoverParam> m_dicKillRecoverParams;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnKillEnemy(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}
}
