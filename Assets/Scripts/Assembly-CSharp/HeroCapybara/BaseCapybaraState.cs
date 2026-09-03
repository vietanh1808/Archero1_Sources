using SimpleFSM;

namespace HeroCapybara
{
	public class BaseCapybaraState : IState
	{
		protected StateMachine m_StateMachine;

		protected StateController m_stateController;

		protected EntityBase m_Entity;

		protected HeroCapybaraSkillVO m_SkillVO;

		protected HeroCapybaraSkillArgs m_SkillArgs;

		public string Tag => null;

		public BaseCapybaraState(StateMachine stateMachine, EntityBase entity, StateController stateController)
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

		protected void Log(string info)
		{
		}

		protected void LogError(string info)
		{
		}

		public TryReleaseSwordVO TryReleaseSword()
		{
			return null;
		}

		protected virtual int getAtkIndex()
		{
			return 0;
		}
	}
}
