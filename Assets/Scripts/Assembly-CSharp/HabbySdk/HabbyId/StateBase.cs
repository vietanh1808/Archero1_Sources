using UnityEngine;

namespace HabbySdk.HabbyId
{
	internal abstract class StateBase
	{
		protected FiniteStateMachine fsm;

		protected HIDDelegate callback;

		protected HIDManager hidManager => null;

		protected MonoBehaviour MonoDriver => null;

		protected IHIDDriver IhidDriver => null;

		public StateBase SetCallback(HIDDelegate callback)
		{
			return null;
		}

		public StateBase(FiniteStateMachine fsm)
		{
		}

		public virtual void Enter()
		{
		}

		public virtual void Execute()
		{
		}

		public virtual void Exit()
		{
		}
	}
}
