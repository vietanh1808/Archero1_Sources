using System.Collections.Generic;
using UnityEngine;

public class AI1846_TD : AIDizzyBase
{
	private const int TD_ID = 1846;

	public const int BULLET_ID = 1910;

	public const int BULLET_EFFECT_ID = 1001003;

	private int initMaxMine;

	private int initPerMine;

	private int initMinRadius;

	private int initMaxRadius;

	private float initMineTime;

	private float initMineEffectRadius;

	public Dictionary<string, List<float>> psDict;

	private float atkWaitTime;

	private int shotMines;

	public int MAX_MINE => 0;

	public int PER_MINE => 0;

	public int MIN_RADIUS => 0;

	public int MAX_RADIUS => 0;

	public float MINE_TIME => 0f;

	public float MineEffectRadius => 0f;

	protected override void OnInitOnce()
	{
	}

	private void initParameters()
	{
	}

	protected override void PopulateActions()
	{
	}

	public ActionBase GetActionAttackWrapper()
	{
		return null;
	}

	protected override void OnAIDeInit()
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	public void UpdateShotMines(int deltaCount)
	{
	}

	public int GetShotMines()
	{
		return 0;
	}

	public void UpdateMineDict(Vector2Int xy, bool value)
	{
	}

	private void initAtkWaitTime()
	{
	}

	protected void cacheDeadEffect()
	{
	}

	protected Transform getPsTrans()
	{
		return null;
	}
}
