using System.Collections.Generic;

namespace HabbySdk.HabbyId
{
	internal class FiniteStateMachine
	{
		internal HIDManager hidManager;

		private Dictionary<State, StateBase> states;

		private State currentState;

		public FiniteStateMachine(HIDManager hidManager)
		{
		}

		public StateBase GetState(State state)
		{
			return null;
		}

		public StateBase GetCurrentState()
		{
			return null;
		}

		public StateBase ChangeState(State newState)
		{
			return null;
		}

		public StateBase ChangeStateWithCallBack(HIDDelegate callBack, State newState)
		{
			return null;
		}

		public void Update()
		{
		}
	}
}
