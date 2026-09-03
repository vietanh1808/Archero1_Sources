using System;

namespace Dxx.Util
{
	public class TimeRepeat
	{
		private float updatetime;

		private float starttime;

		private float delaytime;

		private bool firstdo;

		private Action mCallback;

		private string name;

		public string Name => null;

		public TimeRepeat(string name, float updatetime, Action callback, bool firstdo, float delaytime)
		{
		}

		private void Init(float updatetime, Action callback, bool firstdo, float delaytime)
		{
		}

		private void Register()
		{
		}

		public void UnRegister()
		{
		}

		private void Update(float delta)
		{
		}
	}
}
