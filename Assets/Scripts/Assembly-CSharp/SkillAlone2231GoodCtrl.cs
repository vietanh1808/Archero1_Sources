using UnityEngine;

public class SkillAlone2231GoodCtrl : SkillAloneAttrGoodBase
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

	private float skillDmgInterval;

	private Vector3 skillPos;

	private float skillRadius;

	private bool allowSendBulletDmg;

	private float noDmgAccumulateTime;

	private ParticleSystem curPar;

	private bool isPVEMode;

	private bool isSelf;

	private ArtifactType artifactType;

	private float blackHoleBulletDmgScale;

	private float skillLastTime;

	public void Refresh(ArtifactType artifactType, float blackHoleBulletDmgScale, float skillDmgInterval, float skillLastTime, Vector3 skillPos, float skillRadius, bool isPVEMode, bool isSelf)
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

	public void RecycleCurSkill()
	{
	}

	public bool IsActive()
	{
		return false;
	}
}
