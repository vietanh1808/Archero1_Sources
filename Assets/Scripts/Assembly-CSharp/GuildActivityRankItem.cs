using System.Collections.Generic;
using Habby.Guild.Data;
using UnityEngine;

public class GuildActivityRankItem : MonoBehaviour
{
	[SerializeField]
	private ImageSwitcher switcher;

	[SerializeField]
	private DxxText txtIndex;

	[SerializeField]
	private DxxText txtName;

	[SerializeField]
	private RectTransform contributionRoot;

	[SerializeField]
	private GuildActivityMaterialItem template;

	[SerializeField]
	private HeadItem headItem;

	public void Set(int index, string userId, List<ActivityContributionRankingData.ActivityRankItem> contribution)
	{
	}

	private void SetUserInfo(string userId)
	{
	}

	private void SetContribution(List<ActivityContributionRankingData.ActivityRankItem> contribution)
	{
	}
}
