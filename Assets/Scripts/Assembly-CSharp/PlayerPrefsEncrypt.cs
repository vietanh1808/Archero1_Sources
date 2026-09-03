public class PlayerPrefsEncrypt
{
	private static string sKEY;

	private static string sIV;

	public static void SetInt(string key, int val)
	{
	}

	public static int GetInt(string key, int defaultValue = 0)
	{
		return 0;
	}

	public static void SetBool(string key, bool val)
	{
	}

	public static bool GetBool(string key, bool defaultValue = false)
	{
		return false;
	}

	public static void SetUInt(string key, uint val)
	{
	}

	public static uint GetUInt(string key, uint defaultValue = 0u)
	{
		return 0u;
	}

	public static void SetLong(string key, long val)
	{
	}

	public static long GetLong(string key, long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetULong(string key, ulong val)
	{
	}

	public static ulong GetULong(string key, ulong defaultValue = 0uL)
	{
		return 0uL;
	}

	public static void SetFloat(string key, float val)
	{
	}

	public static float GetFloat(string key, float defaultValue = 0f)
	{
		return 0f;
	}

	public static void SetString(string key, string val)
	{
	}

	public static string GetString(string key, string defaultValue = "")
	{
		return null;
	}

	public static bool HasKey(string key)
	{
		return false;
	}

	public static void DeleteKey(string key)
	{
	}

	public static void DeleteAll()
	{
	}

	public static void Save()
	{
	}

	private static string Decrypt(string encString)
	{
		return null;
	}

	private static string Encrypt(string rawString)
	{
		return null;
	}

	private static string GetHash(string key)
	{
		return null;
	}

	public static string MD5Encrypt(string password, int bit = 32)
	{
		return null;
	}
}
