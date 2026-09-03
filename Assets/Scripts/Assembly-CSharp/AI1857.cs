using UnityEngine;

public class AI1857 : AIBase
{
	public class AI1853MoveToTargetPos : AIMoveToTargetPos
	{
		private EntityHero parent;

		public AI1853MoveToTargetPos(EntityBase entity)
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

	private const string UPDATE_NAME = "AI1857-Update";

	private EntityHero parent;

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

	private bool isParentMoving()
	{
		return false;
	}

	private Vector3 getTargetPos()
	{
		return default;
	}
}
