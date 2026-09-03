namespace NewPlay125
{
	public abstract class BaseVO
	{
		protected string LOG_TAG => null;

		public abstract void Init();

		public abstract void DeInit();

		public abstract void RestoreFromCache();

		protected void Log(string info)
		{
		}

		protected void LogError(string errorInfo)
		{
		}
	}
}
