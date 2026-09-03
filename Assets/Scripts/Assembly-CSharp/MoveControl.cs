using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class MoveControl
{
	public enum EMoveDirection
	{
		Down = 0,
		Up = 1,
		Left = 2,
		Right = 3
	}

	protected EntityBase m_Entity;

	[SerializeField]
	private bool bMoveing;

	private bool bTouchMove;

	protected JoyData m_JoyData;

	protected bool bRegister;

	private float TouchStartTime;

	private Vector3 LastFramePosition;

	private bool m_bPlayWorkFlag;

	protected ObscuredVector3 MoveDirection;

	private float Moving_angle;

	public Vector3 CurMoveDirection
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public void Init(EntityBase entity)
	{
	}

	protected virtual void OnInit()
	{
	}

	private void AddMoveSpeedUpdate()
	{
	}

	public void Start()
	{
	}

	public void DeInit()
	{
	}

	public virtual void RegisterJoyEvent()
	{
	}

	protected virtual bool CanRegisterJoyTouch()
	{
		return false;
	}

	public virtual void RemoveJoyEvent()
	{
	}

	public void RemoveAllJoyEvents()
	{
	}

	public virtual float GetMoveSpeed()
	{
		return 0f;
	}

	protected virtual void OnMoveSpeedUpdate()
	{
	}

	protected void RevertJoyData(ref JoyData data)
	{
	}

	public void AIMoveStart(JoyData data)
	{
	}

	public virtual void OnMoveStart(JoyData data)
	{
	}

	public void AIMoving(JoyData data)
	{
	}

	public virtual void OnMoving(JoyData data)
	{
	}

	private void MoveStart(string action = "Run")
	{
	}

	protected virtual void MoveStartVirtual()
	{
	}

	public void SetPlayWalkSoundFlag(bool bPlay)
	{
	}

	private void Moving(JoyData data)
	{
	}

	public void AIMoveEnd(JoyData data)
	{
	}

	protected virtual void OnMoveEnd(JoyData data)
	{
	}

	protected virtual void MoveEndVirtual()
	{
	}

	protected virtual void MovingVirtual(JoyData data)
	{
	}

	public void OnMoveEnd()
	{
	}

	public void MoveEnd()
	{
	}

	public virtual void SetMoving(bool moving)
	{
	}

	public virtual bool GetMoving()
	{
		return false;
	}

	public virtual void UpdateProgress()
	{
	}

	public virtual void ResetRigidBody()
	{
	}
}
