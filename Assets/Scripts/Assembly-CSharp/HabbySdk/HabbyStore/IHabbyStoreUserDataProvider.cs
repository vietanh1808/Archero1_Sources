namespace HabbySdk.HabbyStore
{
	public interface IHabbyStoreUserDataProvider
	{
		string GetAccessToken();

		string GetUserId();

		string GetAccountId();

		bool IsHabbyIdLoggedIn();

		bool IsHabbyIdEnabled();
	}
}
