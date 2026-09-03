namespace Dxx
{
	public class Singleton<T> : Singletonable where T : Singletonable, new()
	{
		private static T _instance;

		public static T Instance => null;
	}
}
