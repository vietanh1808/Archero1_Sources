using DG.Tweening;
using UnityEngine;

public class Bullet1543 : BulletParabolaBase
{
	private const float startScale = 0.5f;

	private const float endScale = 2.5f;

	private bool canFire;

	private long explodeAtk;

	private float explodeRadius;

	private int debuffId;

	private Tweener scaleTweener;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void setChildVisible(bool visible)
	{
	}

	protected override void ParabolaOver()
	{
	}

	public void SetExplodeArgs(long _explodeAtk, float _explodeRadius, int _debuffId)
	{
	}

	protected void OnHitEnemy(EntityBase enemy)
	{
	}

	private void playExplodeEffect(Vector3 explosionCenter)
	{
	}

	public void EnableFire(EntityBase target)
	{
	}

	public void DoScale(float animTime)
	{
	}

	private void clearScaleTweener()
	{
	}
}
