public interface IHabbyIdActions
{
	bool ShouldShowRedDot { get; }

	bool ShouldShowBindReward { get; }

	void Init(HabbyIdServer server);

	void SetLanguage(string language);

	void ClickLoginFromSetting();

	void ClickLoginFromSelectProgress();

	void ClickLoginFromStoreSilent();

	void ClickLogout();

	void SetEnabled(bool enable);

	HabbyIdDriver.HabbyIdState GetState();

	void RefreshRedDot();
}
