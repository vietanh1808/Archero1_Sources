using System.Collections.Generic;
using UnityEngine;

public class EntityPartBody1842 : EntityPartBodyBase
{
	private const int BUFF_ID = 9103;

	private const int SHIELD_BUFF_ID = 9105;

	private EntityHero parent;

	private float radius;

	private int buff1;

	private int buff2;

	private Dictionary<int, bool> buffDict;

	private const string UPDATE_NAME = "EntityPartBody1842-Update";

	private Vector2Int XY;

	private int hittedCount;

	private float deltaAtkPercent;

	private bool addShieldBuff;

	private GameObject goDragonStone;

	private GameObject goBullet2Map;

	public float DeltaAtkPercent => 0f;

	public void SetXY(Vector2Int _xy)
	{
	}

	protected override void OnInitAfter()
	{
	}

	private void tryAddShield()
	{
	}

	private void initBullet2Map()
	{
	}

	public GameObject CreateCollider(string name, int layer)
	{
		return null;
	}

	protected override void OnDeInit()
	{
	}

	private void onUpdate(float delta)
	{
	}

	public void IncreaseHittedCount()
	{
	}

	private void tryAddBuff(int buffId)
	{
	}

	private void tryRemoveBuff(int buffId)
	{
	}

	private void tryAddDropHP()
	{
	}

	private void CreateDropHP(Vector3 dropHPPos)
	{
	}
}
