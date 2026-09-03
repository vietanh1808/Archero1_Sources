using Dxx.Util;
using UnityEngine;

public class SailingShipEntityBeHitAni : MonoBehaviour
{
	[SerializeField]
	private Transform shipTrans;

	private const float BeHitAniTime = 0.3f;

	private const float BeHitStrength = 0.1f;

	private SequencePool pool;

	private bool isDoingAni;

	public void Refresh()
	{
	}

	public void PlayAni()
	{
	}

	public void StopAni()
	{
	}

	private void ResetAni()
	{
	}
}
