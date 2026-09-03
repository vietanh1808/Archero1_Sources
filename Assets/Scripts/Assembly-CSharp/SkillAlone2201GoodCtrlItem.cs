using System;
using UnityEngine;

public class SkillAlone2201GoodCtrlItem : MonoBehaviour
{
	[SerializeField]
	private Transform parent;

	[SerializeField]
	private GameObject selfPar;

	[SerializeField]
	private GameObject enemyPar;

	private const float RotateTime = 0.5f;

	private Vector3 pos;

	private float radius;

	private EntityBase triggerEntity;

	private float autoSendBulletInterval;

	private float accumulateTime;

	private Action<BulletBase> onCreateBullet;

	private float checkSkillInterval;

	private float lastCheckSkillTime;

	private bool isSendingBullet;

	private ArtifactType artifactType;

	private float bulletDmgScale;

	private bool isSelf;

	private int index;

	public void Refresh(int index, bool isSelf, ArtifactType artifactType, Vector3 pos, float radius, EntityBase triggerEntity, float autoSendBulletInterval, Action<BulletBase> onCreateBullet, float bulletDmgScale)
	{
	}

	private void RefreshTrans()
	{
	}

	private void RefreshPar()
	{
	}

	private void Update()
	{
	}

	private void TryStartSendBullet()
	{
	}

	public void SendBullet(Vector3 startPos, float rotate)
	{
	}

	private void CreateBullet(Vector3 startPos, float rotate)
	{
	}

	public int GetIndex()
	{
		return 0;
	}

	private void SendArtifact301SkillItemSendBulletMsg(Vector3 pos, float rotate)
	{
	}

	private void SyncArtifact301SkillItemSendBulletMsg(Vector3 pos, float rotate, int index)
	{
	}

	public void Recycle()
	{
	}
}
