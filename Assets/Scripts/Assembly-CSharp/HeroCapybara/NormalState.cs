using SimpleFSM;
using UnityEngine;

namespace HeroCapybara
{
	public class NormalState : BaseCapybaraState
	{
		private const string UPDATE_NAME = "NormalState-Update";

		private ReleaseSwordController m_releaseController;

		public NormalState(StateMachine stateMachine, EntityBase entity, StateController stateController)
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

		private void initCallback()
		{
		}

		private void deinitCallback()
		{
		}

		private void OnAttack()
		{
		}

		private void OnKillAction(EntityBase enemy, Vector3 vector, HitStruct hs)
		{
		}

		private void tryCreateSword()
		{
		}

		private void onReleaseSword()
		{
		}

		private float getCDTime()
		{
			return 0f;
		}
	}
}
