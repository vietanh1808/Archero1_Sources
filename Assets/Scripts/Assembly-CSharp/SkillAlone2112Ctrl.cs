using UnityEngine;

public class SkillAlone2112Ctrl : MonoBehaviour
{
	private EntityBase m_Entity;

	[SerializeField]
	private GameObject mFirecracker;

	[SerializeField]
	private GameObject mPreBomb;

	[SerializeField]
	private GameObject mBomb;

	private float m_fHitRatio;

	private ActionBasic mAction;

	public void Init(EntityBase entity, float cd, float range, float hitRatio)
	{
	}

	public void Deinit()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
