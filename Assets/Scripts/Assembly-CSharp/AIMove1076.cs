using UnityEngine;

public class AIMove1076 : AIMove1071
{
	private const string COLLIDER_RESOURCE = "Game/SkillPrefab/CollisionCtrl1007";

	private GameObject mCollision;

	private bool m_bScale;

	private float m_fRatio;

	private float currentdis;

	private float createdis;

	private float angle;

	protected override int MoveEffectID => 0;

	public AIMove1076(EntityBase entity, float move2playerratio, int time, float createdis, float speedratio, bool shoot = true)
		: base(null, 0f, 0, 0f, shoot: false, addSkill: false)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void SetColliderScale(float value)
	{
	}

	private void CreateCollisionCtrl()
	{
	}

	private void CollisionEnter(Collision c)
	{
	}

	protected override void OnEnd()
	{
	}

	private void DestroyCollision()
	{
	}

	private void OnMoveBy(Vector3 move)
	{
	}

	private void CreateBullet2(float _angle)
	{
	}
}
