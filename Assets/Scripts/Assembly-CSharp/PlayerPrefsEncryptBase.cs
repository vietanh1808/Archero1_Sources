public class PlayerPrefsEncryptBase
{
	private byte[] bytes_key;

	private byte[] bytes_iv;

	public PlayerPrefsEncryptBase(byte[] _key, byte[] _iv)
	{
	}

	public void SetInt(string key, int val)
	{
	}

	public int GetInt(string key, int defaultValue = 0)
	{
		return 0;
	}

	public void SetBool(string key, bool val)
	{
	}

	public bool GetBool(string key, bool defaultValue = false)
	{
		return false;
	}

	public void SetUInt(string key, uint val)
	{
	}

	public uint GetUInt(string key, uint defaultValue = 0u)
	{
		return 0u;
	}

	public void SetLong(string key, long val)
	{
	}

	public long GetLong(string key, long defaultValue = 0L)
	{
		return 0L;
	}

	public void SetULong(string key, ulong val)
	{
	}

	public ulong GetULong(string key, ulong defaultValue = 0uL)
	{
		return 0uL;
	}

	public void SetFloat(string key, float val)
	{
	}

	public float GetFloat(string key, float defaultValue = 0f)
	{
		return 0f;
	}

	public void SetString(string key, string val)
	{
	}

	public string GetString(string key, string defaultValue = "")
	{
		return null;
	}

	public bool HasKey(string key)
	{
		return false;
	}

	public void DeleteKey(string key)
	{
	}

	public void DeleteAll()
	{
	}

	public void Save()
	{
	}

	public string Decrypt(string encString)
	{
		return null;
	}

	public string Encrypt(string rawString)
	{
		return null;
	}

	private string GetHash(string key)
	{
		return null;
	}

	public string MD5Encrypt(string password, int bit = 32)
	{
		return null;
	}
}
