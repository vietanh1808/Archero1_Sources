using Habby.Guild.Data;

public static class GuildExtension
{
	public static bool IsSelfIn(this GuildInfoData data)
	{
		return false;
	}

	public static bool IsApplied(this GuildInfoData data)
	{
		return false;
	}

	public static bool IsStranger(this GuildInfoData data)
	{
		return false;
	}

	public static bool IsOwnedByMe(this GuildInfoData data)
	{
		return false;
	}

	public static int GetMyPermissionLevel(this GuildInfoData data)
	{
		return 0;
	}

	public static int GetMemberLimit(this GuildInfoData data)
	{
		return 0;
	}

	public static int GetMemberLimit(this GuildListData.GuildListItem data)
	{
		return 0;
	}

	public static void GetMaxExpByLevel(int currentLevel, out int expToThisTotal, out int expThisToNext)
	{
		expToThisTotal = default;
		expThisToNext = default;
	}
}
