using System.Collections.Generic;
using UnityEngine;

namespace Dxx.ThreadPool
{
	public class AsyncTaskWorker : MonoBehaviour
	{
		public delegate object DoInBackgroundDelegate();

		public delegate void OnPostExecuteDelegate(object result);

		private class AsyncTask
		{
			public DoInBackgroundDelegate doInBackground { get; set; }

			public OnPostExecuteDelegate onPostExecute { get; set; }

			public AsyncTaskWorker worker { get; set; }

			public bool isCompleted { get; set; }

			public object result { get; set; }

			public int index { get; set; }

			public AsyncTask(AsyncTaskWorker worker)
			{
			}

			public void Reset()
			{
			}
		}

		private const string Tag = "AsyncTaskWorker";

		private static GameObject _instance;

		private static List<AsyncTask> m_queueWorkers;

		private static Queue<AsyncTask> m_queneIdlers;

		private AsyncTask asyncTask { get; set; }

		public static AsyncTaskWorker Instance => null;

		private AsyncTaskWorker()
		{
		}

		private static AsyncTask GetIdler()
		{
			return null;
		}

		private static void AddWorker(AsyncTask worker)
		{
		}

		private static void RemoveWorker(AsyncTask worker)
		{
		}

		public AsyncTaskWorker SetDoInBackground(DoInBackgroundDelegate doInBackground)
		{
			return null;
		}

		public AsyncTaskWorker SetOnPostExecute(OnPostExecuteDelegate onPostExecute)
		{
			return null;
		}

		public AsyncTaskWorker Excute()
		{
			return null;
		}

		private void Update()
		{
		}
	}
}
