using Dxx.Util;
using UnityEngine;

public class SailingShipEntityRandomMoveAni : MonoBehaviour
{
	[SerializeField]
	private Transform shipTrans;

	private const float RandomMoveDis = 35f;

	private const float MoveSpeed = 50f;

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
