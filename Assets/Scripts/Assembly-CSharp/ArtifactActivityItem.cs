using System;
using TableTool;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactActivityItem : UITableViewCell
{
	[SerializeField]
	private Image _icon;

	[SerializeField]
	private Text _textCoin;

	[SerializeField]
	private Text _textTalent;

	[SerializeField]
	private Text _textLevel;

	[SerializeField]
	private Text _textSelect;

	[SerializeField]
	private ButtonCtrl _btn;

	[SerializeField]
	private Image _imgSelected;

	[SerializeField]
	private DxxText _textRecommendTalentLevel;

	[SerializeField]
	private Image _imgMask;

	[SerializeField]
	private DxxText _textLockedTips;

	[SerializeField]
	private GameObject _artifactTips;

	[SerializeField]
	private DxxText _textArtifactTips;

	[SerializeField]
	private Transform _tRewardParent;

	[SerializeField]
	private ArtifactActivityRewardItem _copyOne;

	private Daily_TrialDifficulty_128 _data;

	private LocalUnityObjctPool _pool;

	private WaitForSeconds _wait;

	private Coroutine _coroutine;

	public int ID => 0;

	public void Refresh(Daily_TrialDifficulty_128 data, bool isMax, Action<ArtifactActivityItem> onClick)
	{
	}

	private void UpdateLockStatus()
	{
	}

	private void UpdateCd(long cd)
	{
	}

	public void UpdateSelectStatus()
	{
	}

	public void OnClickArtifactIcon()
	{
	}
}
