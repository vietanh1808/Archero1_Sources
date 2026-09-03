using SimpleFSM;
using UnityEngine;

namespace HeroCapybara
{
	public class MeteorState : BaseCapybaraState
	{
		private ReleaseSwordController m_releaseController;

		public MeteorState(StateMachine stateMachine, EntityBase entity, StateController stateController)
			: base(null, null, null)
		{
		}

		public override void Enter()
		{
		}

		public override void Execute()
		{
		}

		public override void Exit()
		{
		}

		private void onReleaseSword()
		{
		}

		private void onExitMeteorState()
		{
		}

		private void explode(Vector3 centerPos, float explodeRadius, float atkPercent)
		{
		}

		private float getCDTime()
		{
			return 0f;
		}

		protected override int getAtkIndex()
		{
			return 0;
		}
	}
}
