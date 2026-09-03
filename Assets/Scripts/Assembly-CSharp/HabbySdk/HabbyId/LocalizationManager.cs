using System;
using System.Collections.Generic;
using UnityEngine;

namespace HabbySdk.HabbyId
{
	public class LocalizationManager : MonoBehaviour, ILocalizationManager
	{
		public TextAsset csvFile;

		public Font fontGlobal;

		protected int LanguageIndex;

		protected static Dictionary<string, int> LanguageCodeToIndex;

		protected const string DefaultLanguageCode = "en";

		protected Dictionary<int, string> CurrentLanguage;

		protected Dictionary<int, Dictionary<int, string>> AllLanguages;

		public void Init(string languageCode)
		{
		}

		public void ChangeLanguage(string languageCode)
		{
		}

		public void ChangeFont()
		{
		}

		public string GetText(int id)
		{
			return null;
		}

		public string GetText(int id, params object[] args)
		{
			return null;
		}

		public void RegisterOnLanguageChangedCallback(Action callback)
		{
		}

		public void UnregisterOnLanguageChangedCallback(Action callback)
		{
		}

		protected static int GetLanguageIndex(string languageCode)
		{
			return 0;
		}

		protected void LoadLanguage(int languageIndex)
		{
		}

		protected void LoadAllLanguages()
		{
		}
	}
}
