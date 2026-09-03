using System;

namespace HeroCapybara
{
	public class ReleaseSwordController
	{
		private const string TAG = "[ReleaseSwordController]";

		private const string UPDATE_NAME = "ReleaseSwordController-Update";

		public SkillAlone2010 m_skillAlone;

		public EntityBase m_Entity;

		public Func<float> GetCDTime;

		public Action OnTryReleaseSword;

		private ConditionTime releaseSwordCD;

		private bool isEnabled;

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		private void onSwordChanged()
		{
		}

		public void OnUpdate(float delta)
		{
		}

		public void EnableCDTimer()
		{
		}

		private void checkIfEnableTimer()
		{
		}

		private void initCDTimer()
		{
		}

		private void destroyCDTimer()
		{
		}

		private void log(string info)
		{
		}
	}
}
