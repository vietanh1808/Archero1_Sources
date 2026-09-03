using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "OBBCheckLanguage", menuName = "OBBCheck/OBBCheckLanguage", order = 1)]
public class CheckObbLanguage : ScriptableObject
{
	[Serializable]
	public class LanguageObject
	{
		public string Key;

		public string CN_s;

		public string CN_t;

		public string EN;

		public string AR;

		public string FR;

		public string DE;

		public string ID;

		public string JP;

		public string KR;

		public string PT_BR;

		public string RU;

		public string ES_ES;

		public string TH;

		public string VI;

		public string ITALIAN;

		public string TURKISH;

		public LanguageObject(string pFileName)
		{
		}
	}

	public LanguageObject[] languageArray;

	private Dictionary<string, LanguageObject> languageMap;

	private SystemLanguage CurrentLanguage;

	[NonSerialized]
	private bool inited;

	public void Init()
	{
	}

	public string GetLanguage(string pKey)
	{
		return null;
	}

	private string GetString(LanguageObject language)
	{
		return null;
	}
}
