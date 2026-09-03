using Habby.Guild.Data;
using UnityEngine;

public class GuildItem : MonoBehaviour
{
	[SerializeField]
	private GuildBadgeItem badgeItem;

	[SerializeField]
	private DxxText txtName;

	[SerializeField]
	private DxxText txtMemberCount;

	[SerializeField]
	private DxxText txtLevel;

	[SerializeField]
	private DxxText txtActivityValue;

	[SerializeField]
	private ButtonCtrl button;

	[SerializeField]
	private GameObject goAppliedMark;

	private GuildListData.GuildListItem data;

	private void Awake()
	{
	}

	public void SetData(GuildListData.GuildListItem data)
	{
	}

	public void OnLanguageChange()
	{
	}
}
