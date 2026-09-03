using System;
using XLua;

public class LuaAppFacade : AppFacade
{
	public static LuaEnv luaEnv;

	private LuaTable scriptEnv;

	private Action ondestroy;

	public void StartUp()
	{
	}

	public static void LuaHotFix()
	{
	}

	public void ShutDown()
	{
	}

	private string LoadLua(string filePath)
	{
		return null;
	}

	private byte[] Loader(ref string filePath)
	{
		return null;
	}

	private void RecursionLuaFilePath(string dirPath, string fileName, out string fileFullPath)
	{
		fileFullPath = null;
	}

	public static string GetTextForStreamingAssets(string path)
	{
		return null;
	}
}
