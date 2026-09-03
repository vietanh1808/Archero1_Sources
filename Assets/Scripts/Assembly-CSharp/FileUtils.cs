using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

public class FileUtils
{
	public class ForceJSONSerializePrivatesResolver : DefaultContractResolver
	{
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}
	}

	public const string File_Equip = "localequip.txt";

	public const string File_Card = "File_Card";

	public const string File_Active = "File_Active";

	public const string File_Challenge = "File_Challenge";

	public const string File_TimeBox = "File_TimeBox";

	public const string File_Stage = "File_Stage";

	public const string File_Achieve = "File_Achieve1";

	public const string File_MysticShop = "File_MysticShop";

	public const string File_Extra = "File_Extra";

	public const string File_BoxDrop = "File_BoxDrop";

	public const string File_CardDrop = "File_CardDrop";

	public const string File_FakerStageDrop = "File_FakerStageDrop";

	public const string File_FakerEquipDrop = "File_FakerEquipDrop";

	public const string File_FakerCardDrop = "File_FakerCardDrop";

	public const string File_Shop = "File_Shop";

	public const string File_Mail = "mail.txt";

	public const string File_Harvest = "File_Harvest";

	public const string File_ChallengeMode = "File_ChallengeMode";

	public const string File_LocalSave = "localsave.txt";

	public const string File_Monster = "File_Monster.txt";

	public const string File_Guild = "File_Guild.txt";

	public const string File_Camp = "File_Camp.txt";

	public const string File_Sailing = "File_Sailing.txt";

	public const string File_MeadowBattle = "File_MeadowBattle.txt";

	public const string File_PVE = "File_PVE.txt";

	public const string File_Medal = "File_Medal.txt";

	public const string File_Manor = "File_Manor.txt";

	public const string File_Prop = "File_Prop.txt";

	public const string File_Pet = "File_Pet.txt";

	public const string File_Imprint = "File_Imprint.txt";

	public const string File_Belief = "File_Belief.txt";

	public const string File_Wing = "File_Wing.txt";

	public const string File_Artifact = "File_Artifact.txt";

	public static string EncryptKey;

	private static string _localpath;

	private static string _FilesDir;

	private static string _CacheDir;

	private static string _ExternalFilesDir;

	private static string _ExternalCacheDir;

	public static string EncryptKey2 => null;

	public static string LocalPath => null;

	private static string EncrpptKeyFunc()
	{
		return null;
	}

	private static string GetPathInternal()
	{
		return null;
	}

	private static bool isEncrypt()
	{
		return false;
	}

	public static string GetDataFolder()
	{
		return null;
	}

	public static string GetPath()
	{
		return null;
	}

	public static LocalSave.BattleInBase GetBattleIn()
	{
		return null;
	}

	private static void CleanBattleIn()
	{
	}

	public static string GetFullPath(string name)
	{
		return null;
	}

	public static T GetXml<T>(string name) where T : new()
	{
		return default;
	}

	public static void CreateWriteFile(string path, string info, bool isRelace = true)
	{
	}

	public static string GetSerializeEncrypt<T>(T t)
	{
		return null;
	}

	public static void WriteMD5(string name, byte[] bytes)
	{
	}

	public static byte[] ReadMD5(string name)
	{
		return null;
	}

	public static void CleanAllLocalFiles()
	{
	}

	public static void Clean(string path)
	{
	}

	public static bool GetXmlFileString(string path, Func<string, string> OnReadFile, out string encryptstr, out string unencryptstr)
	{
		encryptstr = null;
		unencryptstr = null;
		return false;
	}

	private static T ReadXmlFile<T>(string startname) where T : new()
	{
		return default;
	}

	public static string GetFileString(string path)
	{
		return null;
	}

	public static void WriteToFileByOverride(string content, string path)
	{
	}

	public static string GetConfig(string name)
	{
		return null;
	}

	private static string UTF8ByteArrayToString(byte[] characters)
	{
		return null;
	}

	private static byte[] StringToUTF8ByteArray(string pXmlString)
	{
		return null;
	}

	public static string SerializeObject<T>(object pObject)
	{
		return null;
	}

	private static object DeserializeObject<T>(string pXmlizedString)
	{
		return null;
	}

	public static string EncryptName(string value)
	{
		return null;
	}

	public static string Encrypt(string value)
	{
		return null;
	}

	public static string DesDecrypt(string value)
	{
		return null;
	}

	public static void ClearFile(string name)
	{
	}

	public static void CreateFile(string path, string name, string info, bool replace = true)
	{
	}

	public static void SaveFile(string name, byte[] info)
	{
	}

	private static void save_file_internal(string name, byte[] info)
	{
	}

	private static void save_file_internal(string name, string info)
	{
	}

	private static string GetEncryptPathWithoutName(string name)
	{
		return null;
	}

	public static void SaveFileAndMd5(string name, string value)
	{
	}

	private static string GetEncrpytPath(string path)
	{
		return null;
	}

	private static string GetEncryptFullPath(string path)
	{
		return null;
	}

	public static byte[] GetFileBytes(string dir, string name)
	{
		return null;
	}

	public static void DeleteFile(string path, string name)
	{
	}

	public static void WriteError(object str)
	{
	}

	public static void Write(string name, string str)
	{
	}
}
