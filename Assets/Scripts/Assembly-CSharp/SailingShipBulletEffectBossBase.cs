using DG.Tweening;
using UnityEngine;

public class SailingShipBulletEffectBossBase : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem[] particleSystems;

	[SerializeField]
	private ParticleSystem trail;

	private Tween delayCall;

	public void Refresh()
	{
	}

	public void StartTrail()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
