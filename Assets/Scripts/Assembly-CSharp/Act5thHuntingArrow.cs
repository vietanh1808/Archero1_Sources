using System.Collections.Generic;
using UnityEngine;

public class Act5thHuntingArrow : Act5thHuntingEntity, IAct5thHuntingArrow, IAct5thHuntingEntity
{
	[SerializeField]
	private BoxCollider2D boxCollider2D;

	private HashSet<int> markEnemy;

	private Act5thHuntingArrowData HuntingArrowData { get; set; }

	private float Width => 0f;

	private float Length => 0f;

	protected override bool CanBeAttack => false;

	protected override Act5thHuntingEntityType EntityType => Act5thHuntingEntityType.None;

	protected override void Init()
	{
	}

	public override void SetMoveRotate(float angle)
	{
	}

	public override Vector2 GetCurMoveDir()
	{
		return default;
	}

	public void Refresh(Act5thHuntingArrowData data)
	{
	}

	private void RefreshSize()
	{
	}

	public float GetWidth()
	{
		return 0f;
	}

	public float GetLength()
	{
		return 0f;
	}

	public HashSet<int> HaveMarkEnemy()
	{
		return null;
	}

	public override void OnCollideEntity(int triggerHashCode, float dmg)
	{
	}

	public override bool OnCollideWall(Vector2 wallVerticalDir)
	{
		return false;
	}

	public override void OnRecycleImmediately()
	{
	}

	public override void OnClearData()
	{
	}
}
