using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CampTileArrowAni : MonoBehaviour
{
	[SerializeField]
	private GameObject ironArrow;

	[SerializeField]
	private GameObject goldArrow;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private TrailRenderer trailRenderer1;

	[SerializeField]
	private TrailRenderer trailRenderer2;

	private Vector3 startPos;

	private Vector3 endPos;

	private CampTileArrowType arrowType;

	private Tweener arrowAni;

	private Vector3 middlePos;

	private bool isUsing;

	private Vector3 previousPosition;

	private float arrowFlyXStrength;

	public Tweener PlayAni(CampTileArrowType arrowType, Vector3 start, Vector3 end, float arrowFlyXStrength)
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

	public void RefreshOrder(Graphic graphic, int addOrder)
	{
	}
}
