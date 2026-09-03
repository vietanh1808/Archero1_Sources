using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1946 : SkillAloneBase
{
	private class MeteorData
	{
		public int bulletid;

		public int createweight;

		public float hitratio;

		public float dropRadius;

		public MeteorData(string arg)
		{
		}
	}

	private float CONFIG_RATE;

	private float CONFIG_CD;

	private int CONFIG_MIN_CNT;

	private int CONFIG_MAX_CNT;

	private int CONFIG_CNT_PER_WAVE;

	private List<MeteorData> CONFIG_METEORS;

	private int m_nAllWeight;

	private float m_fLastTime;

	private ActionBasic action;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitEnemy(EntityBase entity, HitStruct ht, HittedData data)
	{
	}

	protected virtual void CreateStarBullet(int bulletId, Vector3 pos, float hitRatio)
	{
	}

	protected void DoCreateStarBullet(int bulletId, Vector3 pos, float hitRatio)
	{
	}
}
