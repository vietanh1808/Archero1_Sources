using SimpleFSM;

namespace HeroCapybara
{
	public class StateController
	{
		private const string UPDATE_NAME = "SkillAlone2010.StateController.Update";

		private const string TAG = "[StateController]";

		private HeroCapybaraSkillVO m_SkillVO;

		public EntityBase m_Entity;

		private StateMachine stateMachine;

		private IState normalState;

		private IState meteorState;

		public StateMachine StateMachine => null;

		public IState NormalState => null;

		public IState MeteorState => null;

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		private void OnUpdate(float delta)
		{
		}

		private void onSwordChanged()
		{
		}

		private void log(string msg)
		{
		}
	}
}
