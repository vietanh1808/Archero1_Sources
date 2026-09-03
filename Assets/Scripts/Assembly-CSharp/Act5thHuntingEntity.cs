using UnityEngine;

public abstract class Act5thHuntingEntity : MonoBehaviour, IAct5thHuntingEntity
{
	[SerializeField]
	protected RectTransform rectTransform;

	protected Act5thHuntingEntityData EntityData { get; set; }

	protected virtual float AttackValue => 0f;

	protected virtual float MoveSpeed => 0f;

	protected virtual float HPCount => 0f;

	protected virtual int ReboundCount => 0;

	protected Act5thHuntingManager HuntingManager => null;

	protected Act5thHuntingEntityManager HuntingEntityManager => null;

	protected float CurAngle { get; set; }

	protected abstract bool CanBeAttack { get; }

	protected abstract Act5thHuntingEntityType EntityType { get; }

	protected bool IsInit { get; set; }

	private float LastCheckTime { get; set; }

	protected Vector2 LastTriggerWall { get; set; }

	protected virtual void Init()
	{
	}

	public virtual void SetMoveRotate(float angle)
	{
	}

	public abstract Vector2 GetCurMoveDir();

	public Vector2 GetCurPos()
	{
		return default;
	}

	protected virtual float GetReboundAngle(Vector2 wallVerticalDir)
	{
		return 0f;
	}

	public void Refresh(Act5thHuntingEntityData data)
	{
	}

	public void SetPosition(Vector2 pos)
	{
	}

	protected virtual void OnCollideWallEnd()
	{
	}

	protected virtual void OnAliveEnd()
	{
	}

	protected virtual void OnDisappear()
	{
	}

	public float GetCollideDmg()
	{
		return 0f;
	}

	public bool GetAllowStatus(Act5thHuntingEntityStatus status)
	{
		return false;
	}

	public bool HaveData()
	{
		return false;
	}

	public virtual GameObject GetEntity()
	{
		return null;
	}

	public virtual Act5thHuntingEntityType GetEntityType()
	{
		return Act5thHuntingEntityType.None;
	}

	public virtual Vector2 GetAnchoredPos()
	{
		return default;
	}

	public virtual void OnCollideEntity(int triggerHashCode, float dmg)
	{
	}

	public virtual bool OnCollideWall(Vector2 wallVerticalDir)
	{
		return false;
	}

	public void OnMove(float deltaTime)
	{
	}

	public virtual void OnRecycle()
	{
	}

	public virtual void OnRecycleImmediately()
	{
	}

	public virtual void OnClearData()
	{
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
	}

	private void OnTriggerStay2D(Collider2D other)
	{
	}

	private void TriggerEntity(Collider2D col)
	{
	}

	private void CheckStatus()
	{
	}
}
