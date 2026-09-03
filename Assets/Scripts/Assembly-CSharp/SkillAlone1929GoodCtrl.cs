using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1929GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform parent;

	[SerializeField]
	private Transform dmgCollider;

	[SerializeField]
	private Transform effect;

	private float radius;

	private float igniteDmgMult;

	private List<int> hitEnemy;

	private Vector3 pos;

	private int buffID;

	public void Refresh(float radius, float igniteDmgMult, int buffID, Vector3 pos)
	{
	}

	private void RefreshTrans()
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	protected override void TriggerStay(EntityBase entity)
	{
	}

	private bool CanAttackEnemy(int guid)
	{
		return false;
	}

	private void AttackEnemy(EntityBase entity)
	{
	}
}
