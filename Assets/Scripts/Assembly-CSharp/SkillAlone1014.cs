using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SkillAlone1014 : SkillAloneBase
{
	private GameObject good;

	protected ParticleSystem mParticle;

	private SkillAlone1014Ctrl ctrl;

	private AutoDespawn mAutoDespawn;

	private Sequence seq;

	private Vector3 m_pos;

	private float createdis;

	private List<GameObject> curGoodList;

	private GameObject curCloneGood;

	private float m_fTime;

	protected virtual int EffectID => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void KillSequence()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnPositionBy(Vector3 p)
	{
	}

	protected virtual GameObject CreateSkillAlone()
	{
		return null;
	}

	protected virtual void CreateSkillOne(GameObject curSkillOne)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	public int GetEffectID()
	{
		return 0;
	}
}
