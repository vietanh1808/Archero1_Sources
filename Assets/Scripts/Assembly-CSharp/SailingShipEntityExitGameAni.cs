using System;
using Dxx.Util;
using UnityEngine;

public class SailingShipEntityExitGameAni : MonoBehaviour
{
	[SerializeField]
	private Transform shipTrans;

	private const float ExitGameTime = 1.5f;

	private const float ShipExitGameDistance = -800f;

	private SequencePool pool;

	private bool isDoingAni;

	public void Refresh()
	{
	}

	public void PlayAni(Action completeAniAction)
	{
	}

	public void StopAni()
	{
	}

	private void ResetAni()
	{
	}
}
