using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1816GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private GameObject parent;

	[SerializeField]
	private Transform skillAloneTrans;

	[SerializeField]
	private Transform particleTrans;

	[SerializeField]
	private ParticleSystem[] particle;

	private float radius;

	private float igniteDmgMult;

	private int igniteBuffID;

	private List<int> hitEnemy;

	private float changeSpeed;

	private Vector3 pos;

	private float originTime;

	public void Refresh(float radius, float speed, float igniteDmgMult, int igniteBuffID, Vector3 pos)
	{
	}

	private void RefreshTrans()
	{
	}

	private void RefreshSize(float scale)
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	private bool CanAttackEnemy(int guid)
	{
		return false;
	}

	public void Clear()
	{
	}

	private void Update()
	{
	}
}
