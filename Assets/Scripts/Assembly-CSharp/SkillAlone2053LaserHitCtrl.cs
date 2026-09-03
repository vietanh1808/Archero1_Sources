using UnityEngine;

public class SkillAlone2053LaserHitCtrl : MonoBehaviour
{
	[SerializeField]
	private Transform startNode;

	[SerializeField]
	private Transform endNode;

	[SerializeField]
	private LineRenderer laserLine;

	[SerializeField]
	private Transform startEff;

	[SerializeField]
	private Transform endEff;

	private Ray ray;

	private Vector3[] vectArr;

	private EntityBase m_Entity;

	public bool isInWall;

	public static int BuffId;

	public void Init(EntityBase entity)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void LateUpdate()
	{
	}
}
