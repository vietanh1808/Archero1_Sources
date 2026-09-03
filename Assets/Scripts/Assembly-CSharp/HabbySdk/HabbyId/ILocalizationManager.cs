using System;

namespace HabbySdk.HabbyId
{
	public interface ILocalizationManager
	{
		string GetText(int id);

		string GetText(int id, params object[] args);

		void RegisterOnLanguageChangedCallback(Action callback);

		void UnregisterOnLanguageChangedCallback(Action callback);
	}
}
