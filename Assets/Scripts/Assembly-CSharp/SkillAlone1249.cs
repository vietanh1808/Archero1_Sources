using System.Collections.Generic;

public class SkillAlone1249 : SkillAloneBase
{
	private class BuffData
	{
		public int Id;

		private int _count;

		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool Alive { get; private set; }

		public bool Check(int id, int max)
		{
			return false;
		}
	}

	private Dictionary<EntityBase, BuffData> m_dicEntityBuffs;

	private int m_nDebuffId;

	private int m_nDebuffId2;

	private int m_nBuffId;

	private int m_nDebuffMax;

	private float m_fRate;

	private float m_fKillSoliderRate;

	private float m_fKillBossRate;

	private float m_fAddTotalMax;

	private float m_fCritRateAddTotal;

	private float CritRateAddTotal
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void OnBuffRemoved(EntityBase entity, int buffId)
	{
	}

	private void CheckSelfBuff()
	{
	}

	private void OnEnemyDead(EntityBase entity)
	{
	}
}
