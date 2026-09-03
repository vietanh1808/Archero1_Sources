namespace Habby.AssetExpress.Util
{
	public abstract class Singletone<T> where T : Singletone<T>
	{
		private static T instance;

		public static T Instance => null;

		protected void Destroy()
		{
		}
	}
}
