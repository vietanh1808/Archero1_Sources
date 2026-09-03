using System;
using System.Collections.Generic;

public interface IHabbyIdIntegration
{
	string GameId { get; }

	string Language { get; }

	string GetGameAccountId();

	string GetGameUserId();

	bool CheckHabbyIdLogin();

	void TrackEvent(string eventName, Dictionary<string, object> eventProps);

	void ShowLoading(bool show);

	void OnStateChange();

	void LoginHabbyId(string authCode, LoginMode mode, Action<bool, int> callback);

	void LogoutHabbyId(Action<bool, int> callback);
}
