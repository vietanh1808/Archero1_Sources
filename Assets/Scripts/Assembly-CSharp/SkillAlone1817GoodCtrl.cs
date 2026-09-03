using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1817GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private GameObject parent;

	[SerializeField]
	private Transform skillAloneTrans;

	[SerializeField]
	private Transform crateParent;

	[SerializeField]
	private Transform allParent;

	private SkillAlone1817Data data;

	private Vector3 pos;

	public const int effectID = 1818;

	private Dictionary<int, float> hitEnemy;

	public void Refresh(SkillAlone1817Data data, Vector3 pos, bool isUseRed)
	{
	}

	private void RefreshTrans()
	{
	}

	private void RefreshFire(bool isUseRed)
	{
	}

	private void RotateFire()
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	protected override void TriggerStay(EntityBase entity)
	{
	}

	private void CheckAttack(EntityBase entity)
	{
	}

	private bool CanAttackEnemy(int enemyGuid)
	{
		return false;
	}

	private void Update()
	{
	}

	public void Clear()
	{
	}
}
