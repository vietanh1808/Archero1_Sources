using System.Threading;

namespace Dxx.ThreadPool
{
	public class DxxThread
	{
		private const string Tag = "DxxThread";

		private DxxThreadPoolCallback m_doInBackground;

		private object m_result;

		private ManualResetEvent m_event;

		private Thread m_thread;

		private bool m_bCompleted;

		private ManualResetEvent Event => null;

		public bool IsBusy => false;

		public object GetResult()
		{
			return null;
		}

		public void SetDoInBackground(DxxThreadPoolCallback oInBackground)
		{
		}

		private void Work()
		{
		}

		public void Stop()
		{
		}

		public void Excute()
		{
		}

		public void Kill()
		{
		}
	}
}
