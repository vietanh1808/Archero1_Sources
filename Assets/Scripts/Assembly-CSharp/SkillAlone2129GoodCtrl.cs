using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2129GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform parent;

	[SerializeField]
	private Transform dmgCollider;

	[SerializeField]
	private Transform effect;

	[SerializeField]
	private AutoDespawn autoDespawn;

	[SerializeField]
	private ParticleSystem normalParticle;

	[SerializeField]
	private ParticleSystem thunderParticle;

	[SerializeField]
	private ParticleSystem fireParticle;

	[SerializeField]
	private ParticleSystem iceParticle;

	[SerializeField]
	private ParticleSystem poisonParticle;

	[SerializeField]
	private ParticleSystem blackParticle;

	private EElementType skillElementType;

	private float skillLastTime;

	private float skillDmgInterval;

	private float skillRadius;

	private float igniteDmgMult;

	private Vector3 skillPos;

	private List<int> hitEnemy;

	private float attackTime;

	private float skillTime;

	private bool allowDmg;

	private float dmgAccumulateTime;

	private float noDmgAccumulateTime;

	private List<int> buffID;

	private bool allowCrit;

	public void Refresh(EElementType skillElementType, float skillLastTime, float skillDmgInterval, float skillRadius, float igniteDmgMult, List<int> buffID, bool allowCrit, Vector3 skillPos)
	{
	}

	private void StartDmg()
	{
	}

	private void RefreshTrans()
	{
	}

	private void RefreshAllPar()
	{
	}

	private ParticleSystem GetCurPar(EElementType elementType)
	{
		return null;
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

	private void Update()
	{
	}
}
