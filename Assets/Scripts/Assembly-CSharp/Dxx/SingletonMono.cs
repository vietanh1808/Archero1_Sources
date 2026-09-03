namespace Dxx
{
	public class SingletonMono<T> : SingletonableMono where T : SingletonableMono
	{
		private static T _instance;

		public static T Instance => null;
	}
}
