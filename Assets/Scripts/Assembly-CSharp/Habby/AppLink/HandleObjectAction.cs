using System;

namespace Habby.AppLink
{
	public class HandleObjectAction : IHandleObject
	{
		private Action onHandle;

		public HandleObjectAction(Action pHandle)
		{
		}

		public bool HandleCall()
		{
			return false;
		}
	}
	public class HandleObjectAction<T> : IHandleObject
	{
		private Action<T> onHandle;

		private Func<T> dataFun;

		private Func<bool> canPush;

		public HandleObjectAction(Action<T> pHandle, Func<T> pDataFun, Func<bool> pCanPush = null)
		{
		}

		public bool HandleCall()
		{
			return false;
		}
	}
}
