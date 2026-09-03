using DG.Tweening;
using UnityEngine;

public class SkillAlone1308GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private AutoDespawn autoDespawn;

	[SerializeField]
	private ParticleSystem loopPar;

	[SerializeField]
	private ParticleSystem fadePar;

	private Tween delayCall;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SetParActive(bool isActive)
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}
}
