using Dxx.Util;
using UnityEngine;

public class SailingShipEntityFireAni : MonoBehaviour
{
	[SerializeField]
	private Transform shipTrans;

	[SerializeField]
	private float recoilDistance;

	[SerializeField]
	private float recoilDuration;

	[SerializeField]
	private float returnDuration;

	private SequencePool pool;

	private bool isDoingAni;

	public void Refresh()
	{
	}

	public void PlayAni(bool isDownPos)
	{
	}

	public void StopAni()
	{
	}

	private void ResetAni()
	{
	}
}
