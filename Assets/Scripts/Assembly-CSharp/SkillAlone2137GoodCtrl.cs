using UnityEngine;

public class SkillAlone2137GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private ParticleSystem pvePar;

	[SerializeField]
	private ParticleSystem pvpSelfPar;

	[SerializeField]
	private ParticleSystem pvpEnemyPar;

	[SerializeField]
	private Transform skillParent;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private AutoDespawn autoDespawn;

	[SerializeField]
	private GameObject pveEffect;

	[SerializeField]
	private GameObject pvpEffect;

	[SerializeField]
	private GameObject pvpEffectSelf;

	[SerializeField]
	private GameObject pvpEffectEnemy;

	private float skillLastTime;

	private float skillDmgInterval;

	private Vector3 skillPos;

	private float skillRadius;

	private bool allowSendBulletDmg;

	private float noDmgAccumulateTime;

	private ParticleSystem curPar;

	private bool isPVEMode;

	private bool isSelf;

	public void Refresh(float skillLastTime, float skillDmgInterval, Vector3 skillPos, float skillRadius, bool isPVEMode, bool isSelf)
	{
	}

	private void RefreshPar()
	{
	}

	private void StartSendBullet()
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

	private void AttackEnemy(EntityBase entity)
	{
	}

	private void Update()
	{
	}
}
