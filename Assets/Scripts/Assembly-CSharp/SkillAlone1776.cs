using DG.Tweening;
using UnityEngine;

public class SkillAlone1776 : SkillAloneBase
{
	private float maxDis;

	private int buffId;

	private float atkPercent;

	private float explodePercent;

	private float atkRadius;

	private float minExplodeRadius;

	private float maxExplodeRadius;

	private float explodeRadius;

	private const string UPDATE_NAME = "SkillAlone1776-UPDATE";

	private const string SKILL_MOVING = "SkillMoving";

	private const string SKILL_MOVE_PRE = "SkillMovePrev";

	private const string SKILL_MOVE_END = "SkillMoveEnd";

	private const string CLOUD_PRE = "Cloud_Prev";

	private const string CLOUD_MOVING = "Cloud_Moving";

	private const string CLOUD_END = "Cloud_End";

	public const float CLOUD_HEIGHT = 1f;

	private ActionMovingDis movingDis;

	private Animation cloudAnim;

	private bool IsMoving;

	private Tweener floatTweener;

	private Tween delayTween;

	private bool isUsingFist;

	private Tween shrinkTween;

	private const float StickHeight = 6f;

	private GameObject WuKongCloud;

	private float cloudPreTime;

	private float skillPreTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void parseAtkPercentArgs(string[] args)
	{
	}

	private void parseExplodeArgs(string[] args)
	{
	}

	private void OnMoving(JoyData data)
	{
	}

	private void onUpdate(float obj)
	{
	}

	private void onMove(bool isMoving)
	{
	}

	private void createWuKongStickBulletWrapper()
	{
	}

	private void createWuKongStickBullet(Vector3 bulletPos)
	{
	}

	private void onReachMaxDis()
	{
	}

	private void initExtraAnimations()
	{
	}

	private void initWuKongCloud()
	{
	}

	private Vector3 getCloudScale()
	{
		return default;
	}
}
