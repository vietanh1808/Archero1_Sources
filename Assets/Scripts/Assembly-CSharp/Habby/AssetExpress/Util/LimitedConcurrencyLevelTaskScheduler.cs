using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Habby.AssetExpress.Thread;

namespace Habby.AssetExpress.Util
{
	public class LimitedConcurrencyLevelTaskScheduler : TaskScheduler
	{
		[ThreadStatic]
		private static bool _currentThreadIsProcessingItems;

		private readonly LinkedList<Task> _tasks;

		private int _maxDegreeOfParallelism;

		private AtomicInteger _delegatesQueuedOrRunning;

		public sealed override int MaximumConcurrencyLevel => 0;

		public LimitedConcurrencyLevelTaskScheduler(int maxDegreeOfParallelism)
		{
		}

		public void ChangeMaxDegreeOfParallelism(int maxDegreeOfParallelism)
		{
		}

		protected void AddThread(int count)
		{
		}

		protected sealed override void QueueTask(Task task)
		{
		}

		private void NotifyThreadPoolOfPendingWork()
		{
		}

		protected sealed override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			return false;
		}

		protected sealed override bool TryDequeue(Task task)
		{
			return false;
		}

		protected sealed override IEnumerable<Task> GetScheduledTasks()
		{
			return null;
		}
	}
}
