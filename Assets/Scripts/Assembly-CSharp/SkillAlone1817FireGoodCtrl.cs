using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1817FireGoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform parent;

	[SerializeField]
	private ParticleSystem particle2;

	[SerializeField]
	private ParticleSystem particle3;

	[SerializeField]
	private ParticleSystem blueParticle2;

	[SerializeField]
	private ParticleSystem blueParticle3;

	[SerializeField]
	private GameObject redParticle;

	[SerializeField]
	private GameObject blueParticle;

	private SkillAlone1817Data data;

	private float rotate;

	private Dictionary<int, float> hitEnemy;

	private float particle2OriginLength;

	private float particle3OriginLength;

	private float particle2OriginWidth;

	private float particle3OriginWidth;

	private bool isUseRed;

	public void Refresh(SkillAlone1817Data data, float rotate, bool isUseRed)
	{
	}

	private void RefreshTrans()
	{
	}

	private void RefreshSize()
	{
	}

	private void RefreshStatus()
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	private bool CanAttackEnemy(int enemyGuid)
	{
		return false;
	}
}
