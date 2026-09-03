using System.Collections.Generic;
using System.Text;
using TableTool;
using UnityEngine;

public class LanguageManager
{
	public const string CN_s = "CN_s";

	public const string CN_t = "CN_t";

	public const string EN = "EN";

	public const string FR = "FR";

	public const string DE = "DE";

	public const string ID = "ID";

	public const string JP = "JP";

	public const string KR = "KR";

	public const string PT_BR = "PT_BR";

	public const string RU = "RU";

	public const string ES_ES = "ES_ES";

	public const string AR = "AR";

	public const string TH = "TH";

	public const string VI = "VI";

	public const string ITALIAN = "ITALIAN";

	public const string TURKISH = "TURKISH";

	public static Dictionary<string, string> languagedic;

	public static Dictionary<string, string> LanguageToTranslate;

	public static Dictionary<SystemLanguage, string> m_LanguageIDMap;

	public static Dictionary<string, string> LangCodeMap;

	private SystemLanguage CurrentLanguage;

	private Dictionary<string, Language_lauguage> m_LanguageList;

	private int argsLength;

	private int geti;

	private string containstring;

	private string currentstring;

	private StringBuilder sb;

	private Dictionary<int, string> mStageIndexs;

	public string Level => null;

	public string Count => null;

	public string getTranslatekey()
	{
		return null;
	}

	public static bool IsCurrentLanguageChinese()
	{
		return false;
	}

	public static string GetLanguageName(string key)
	{
		return null;
	}

	public static string GetCurrentLangCode()
	{
		return null;
	}

	public string GetLanguageByTIDNotArabic2(string tid)
	{
		return null;
	}

	public string GetLanguageByTIDNotArabic(string tid, params object[] args)
	{
		return null;
	}

	public string GetLanguageByTID(string tid, params object[] args)
	{
		return null;
	}

	public string GetChineseLanguageByTID(string tid)
	{
		return null;
	}

	public string GetLanguageByTIDNotFormater(string tid)
	{
		return null;
	}

	public bool IsLanguageKeyContains(string sorKey)
	{
		return false;
	}

	public string GetEquipSpecialInfo(int equipid)
	{
		return null;
	}

	private int get_skill_languageid(int skillId)
	{
		return 0;
	}

	public string GetSkillName(int skillId, params object[] args)
	{
		return null;
	}

	public string GetSkillContent(int skillId, params object[] args)
	{
		return null;
	}

	public string GetSkillNameNotArabic(int skillId, params object[] args)
	{
		return null;
	}

	public string GetSkillContentNotArabic(int skillId, params object[] args)
	{
		return null;
	}

	private string GetString(Language_lauguage language)
	{
		return null;
	}

	public void ChangeLanguage(string language)
	{
	}

	public SystemLanguage GetLanguage()
	{
		return SystemLanguage.Afrikaans;
	}

	public string GetLanguageString()
	{
		return null;
	}

	public bool IsArabic()
	{
		return false;
	}

	public string GetColorText(string text, string pColorStr, bool withSpace = true)
	{
		return null;
	}

	public string GetLanguageUpdate(string value)
	{
		return null;
	}

	public string GetRomanNumber(int value)
	{
		return null;
	}

	public string GetSecond(int second)
	{
		return null;
	}

	public string GetCountDown(long time)
	{
		return null;
	}

	public string GetCountDownOnlyNum(long time)
	{
		return null;
	}

	public string GetServerMaintain(long time)
	{
		return null;
	}

	public string GetCountDownMinute(long time)
	{
		return null;
	}

	public string GetStageLayer(int MaxLevel, GameMode mode = GameMode.eLevel)
	{
		return null;
	}
}
