using System;
using DG.Tweening;
using UnityEngine;

public class SkillAloneWuKongAI : SkillAloneBase
{
	protected float stickDis;

	protected float unitThickness;

	public const string SKILL_IDLE = "SkillIdle";

	private float skillIdleTime;

	protected Func<Vector3, Quaternion, BulletBase> OnCreateBullet;

	public WuKongStickMid stick;

	public float stickLength;

	public float stickEndLength;

	protected float stickLossyScaleZ;

	protected ActionBasic ai;

	private Transform StickNodeTrans;

	protected float defaultAnimSpeePercent;

	private Sequence scaleSeq;

	protected virtual float StickThickness => 0f;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	public void setBoxCollider(BulletBase bullet, float newStickLength)
	{
	}

	public void doScaleAnim(Vector3 endScale, float time)
	{
	}

	public void KillScaleAnim()
	{
	}

	protected void initIdleAnim()
	{
	}

	public void forceResetScale()
	{
	}

	protected virtual void addClips()
	{
	}

	protected void initStickInfo()
	{
	}
}
