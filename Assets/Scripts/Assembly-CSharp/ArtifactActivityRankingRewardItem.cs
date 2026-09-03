using TableTool;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactActivityRankingRewardItem : UITableViewCell
{
	[SerializeField]
	private Image _imgCup;

	[SerializeField]
	private DxxText _textCupRank;

	[SerializeField]
	private GameObject _normalRank;

	[SerializeField]
	private DxxText _textNormalRank;

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private RectTransform _content;

	[SerializeField]
	private GameObject _selfRankReward;

	private LocalUnityObjctPool _pool;

	public void Refresh(Daily_TrialRank_128 data)
	{
	}
}
