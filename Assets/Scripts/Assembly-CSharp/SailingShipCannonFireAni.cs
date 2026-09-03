using Dxx.Util;
using UnityEngine;

public class SailingShipCannonFireAni : MonoBehaviour
{
	[Header("炮身动画参数")]
	[SerializeField]
	private Transform cannonBarrel;

	[SerializeField]
	private float stretchScale;

	[SerializeField]
	private float squashScale;

	[SerializeField]
	private float stretchDuration;

	[SerializeField]
	private float squashDuration;

	[SerializeField]
	private float recoilDuration;

	private SequencePool seqPool;

	private void InitAni()
	{
	}

	public void Refresh()
	{
	}

	public void PlayAni()
	{
	}
}
