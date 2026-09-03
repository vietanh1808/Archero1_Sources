namespace Habby.AssetExpress.IO
{
	public class JsonFileSaveLoad
	{
		public static void Save<T>(T t, string path)
		{
		}

		public static T Load<T>(string path)
		{
			return default;
		}

		public static bool HasSave(string filepath)
		{
			return false;
		}

		public static void Delete(string filepath)
		{
		}
	}
}
