using DG.Tweening;
using Dxx.Util;
using UnityEngine;

public class SkillAlone1217 : SkillAloneBase
{
	private int m_nBuffId;

	private float m_fDistance;

	private SequencePool mSeqPool;

	private Bullet9003 bullet;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private bool OnCheckSuperSkill()
	{
		return false;
	}

	protected virtual void OnSuperSkill(bool value)
	{
	}

	private void SuperSkill()
	{
	}

	private Sequence Charge(float angle, Vector3 startPos, Vector3 endPos, Vector3 dir)
	{
		return null;
	}

	private Sequence Back(Vector3 startPos, float fAttackPrevTime, float angle)
	{
		return null;
	}

	protected virtual int GetBackBulletId()
	{
		return 0;
	}

	private BulletBase CreateBullet(int bulleId, float angle, Vector3 pos)
	{
		return null;
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void ResetSuperSkill()
	{
	}

	private bool OnCanSuperSkill()
	{
		return false;
	}
}
