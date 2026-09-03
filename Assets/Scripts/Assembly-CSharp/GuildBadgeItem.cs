using UnityEngine;

public class GuildBadgeItem : MonoBehaviour
{
	[SerializeField]
	private DxxImage imgBack;

	[SerializeField]
	private DxxImage imgFore;

	public GuildBadgeData data;

	public void Set(int backId, int foreId)
	{
	}

	public void Set(GuildBadgeData data)
	{
	}
}
