using UnityEngine;

public class AIThunderDragon : AIDragonBase
{
	private const int BULLET_ID = 1203;

	private const float WAIT_TIME = 0.5f;

	private Vector3 bulletPos;

	private Quaternion bulletRotation;

	private ActionBasic action;

	protected override void OnInit1()
	{
	}

	protected override AIBase.ActionSequence getAnimSequenceAction()
	{
		return null;
	}

	protected override void AfterSkillAttackPre()
	{
	}

	protected override void BeforeSkillDisappear()
	{
	}

	private void createThunderBullet()
	{
	}
}
