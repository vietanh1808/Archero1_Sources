using HabbySdk.HabbyStore;

public class ArcheroUserDataProvider : IHabbyStoreUserDataProvider
{
	public string GetAccessToken()
	{
		return null;
	}

	public string GetUserId()
	{
		return null;
	}

	public string GetAccountId()
	{
		return null;
	}

	public bool IsHabbyIdLoggedIn()
	{
		return false;
	}

	public bool IsHabbyIdEnabled()
	{
		return false;
	}
}
