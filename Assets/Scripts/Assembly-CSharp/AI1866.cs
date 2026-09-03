using UnityEngine;

public class AI1866 : AIBase
{
	public class AI1866MoveToTargetPos : AIMoveToTargetPos
	{
		private EntityBase parent;

		public AI1866MoveToTargetPos(EntityBase entity)
			: base(null)
		{
		}

		protected override void OnInitBase()
		{
		}

		protected override bool isCloseEnough()
		{
			return false;
		}

		protected override void OnAfterMoveDirectionAssigned()
		{
		}

		protected override void correctMoveDir()
		{
		}
	}

	private const string UPDATE_NAME = "AI1866-Update";

	private EntityBase parent;

	private bool isAtkingState;

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private void onPVPGrassChanged()
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onUpdate(float delta)
	{
	}

	private bool havePvpTarget()
	{
		return false;
	}

	private ActionAttack getActionAtk()
	{
		return null;
	}

	private void normalMovAction()
	{
	}

	private ActionBase getActionMov()
	{
		return null;
	}

	private ActionBase getActionRotate2Target()
	{
		return null;
	}

	private Vector3 getTargetPos()
	{
		return default;
	}
}
