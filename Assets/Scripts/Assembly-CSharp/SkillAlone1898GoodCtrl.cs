using DG.Tweening;
using UnityEngine;

public class SkillAlone1898GoodCtrl : EntityParentBase
{
	[SerializeField]
	private ParticleSystem start;

	[SerializeField]
	private ParticleSystem loop;

	[SerializeField]
	private ParticleSystem end;

	[SerializeField]
	private BoxCollider collider;

	public const float AniTime = 0.6f;

	private Tween delayCall;

	public void Create()
	{
	}

	public void Recycle()
	{
	}

	public void RecycleImmediately()
	{
	}

	private void AllParticleInactive()
	{
	}
}
