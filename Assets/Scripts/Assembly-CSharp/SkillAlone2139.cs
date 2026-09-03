using DG.Tweening;
using UnityEngine;

public class SkillAlone2139 : SkillAloneBase
{
	private int reSendBlackBallBulletProb;

	private float reSendBlackBallInterval;

	private Tween delayCall;

	private bool ReSendBlackBallCond => false;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnSendBlackHole(EntityBase sender, Vector3 targetPos)
	{
	}
}
