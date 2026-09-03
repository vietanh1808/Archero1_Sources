using UnityEngine;

public class DSMMuzzle : MonoBehaviour
{
	[SerializeField]
	private GameObject prePremiumStartHitEffect;

	[SerializeField]
	private GameObject prePremiumLoopHitEffect;

	[SerializeField]
	private GameObject prePremiumEndHitEffect;

	[SerializeField]
	private GameObject preNormalStartHitEffect;

	[SerializeField]
	private GameObject preNormalLoopHitEffect;

	[SerializeField]
	private GameObject preNormalEndHitEffect;

	private SailingMCannonType _crtFireType;

	public void SetSailingMCannonType(SailingMCannonType crtFireType)
	{
	}

	public void ResetEffectStatus()
	{
	}

	public void PlayStartPreHit()
	{
	}

	public void PlayLoopPreHit()
	{
	}

	public void PlayEndPreHit()
	{
	}
}
