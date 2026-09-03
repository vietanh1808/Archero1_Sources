using DG.Tweening;
using UnityEngine;

public class SailingMonsterMCannonAni : MonoBehaviour
{
	[SerializeField]
	private GameObject normalMCannon;

	[SerializeField]
	private GameObject premiumMCannon;

	[SerializeField]
	private Transform parent;

	private Vector3 startPos;

	private Vector3 endPos;

	private Transform _target;

	private SailingMCannonType arrowType;

	private Tweener arrowAni;

	private Vector3 middlePos;

	private bool isUsing;

	private Vector3 previousPosition;

	private float arrowFlyXStrength;

	private bool _isRefreshOrder;

	public Tweener PlayAni(SailingMCannonType arrowType, Vector3 start, Vector3 end, float arrowFlyXStrength)
	{
		return null;
	}

	public void UpdateRotation()
	{
	}

	public void StopAni()
	{
	}

	public bool IsUsing()
	{
		return false;
	}

	public void RefreshStatus()
	{
	}

	public Vector3[] GenerateRandomArcPath()
	{
		return null;
	}

	public void RefreshOrder()
	{
	}
}
