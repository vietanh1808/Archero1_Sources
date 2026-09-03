using TableTool;
using UnityEngine;

public abstract class AIMoveBase_Net : ActionBasic.ActionUIBase
{
	protected Operation_move Data;

	public string ClassName;

	public int ClassID;

	protected JoyData m_MoveData;

	protected bool m_IsMoveEnd;

	public AIMoveBase_Net(EntityBase entity)
	{
	}

	protected sealed override void OnInit()
	{
	}

	private void OnDizzy(bool value)
	{
	}

	protected override void OnEnd1()
	{
	}

	protected abstract void OnInitBase();

	public static ConditionBase GetConditionTime(int time)
	{
		return null;
	}

	public static ConditionBase GetConditionRandomTime(int min, int max)
	{
		return null;
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnForceEnd()
	{
	}

	protected override void OnEnd()
	{
	}

	protected virtual void MoveEventHandler(bool isMoving)
	{
	}

	protected MoveCommand SyncMovCmd(Vector3 startPos, bool isRoteMoveDirect, float moveSpeed)
	{
		return null;
	}

	protected StopMoveCommand SyncStopMovCmd(Vector3 stopPos)
	{
		return null;
	}

	protected ActionCommand SyncPlayAnimCmd(string actionName, bool isForcePlay = true)
	{
		return null;
	}

	protected RoteCommand SyncRotateCmd(float angle)
	{
		return null;
	}
}
