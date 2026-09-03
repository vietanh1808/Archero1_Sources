namespace NewPlay125
{
	public abstract class BaseController
	{
		protected string LOG_TAG => null;

		protected NewPlay125Manager manager => null;

		public abstract void InitGame();

		public abstract void DeInitGame();

		public abstract void RestoreFromCache();

		public abstract void Sync2Cache();

		protected void Log(string msg)
		{
		}

		protected void LogError(string msg)
		{
		}
	}
}
