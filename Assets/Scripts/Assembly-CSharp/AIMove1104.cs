using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class AIMove1104 : AIJumpMoveBase
{
	private float delaytime;

	private float starttime;

	public float alltime;

	private bool bPlaySkill;

	private string oldAnimName;

	private const string JUMP_ANIM = "Attack 03";

	private Vector3 targetPos;

	private Vector3 highestPos;

	private float highestPercent;

	private Sequence seq;

	private float totalAnimTime;

	private float deltaSpeed;

	private float stallTime;

	private float totalFrames;

	private float newStallTime;

	private const int BULLET_ID = 5304;

	private int totalCount;

	private float totalAngle;

	private List<GameObject> redLineList;

	private float lineWidth;

	private Vector3 entityDir;

	private Vector3 bulletPos;

	private bool changeAnimSpeed;

	private const float EXPLOSION_RADIUS = 3f;

	private int ATTACK_TIMES;

	public AIMove1104(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void recoverAnimSpeed()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void MoveNormal()
	{
	}

	private void createRedLine(Vector3 dir)
	{
	}

	private void createRedLines()
	{
	}

	private void clearRedLine(GameObject _redLine)
	{
	}

	private void clearRedLines()
	{
	}

	private void createBullets()
	{
	}

	private void OnFly()
	{
	}

	protected override void OnEnd()
	{
	}

	protected void ShowExplodeEffect()
	{
	}
}
