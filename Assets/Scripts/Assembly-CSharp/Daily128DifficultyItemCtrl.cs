using System;
using TableTool;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Daily128DifficultyItemCtrl : UITableViewCell
{
	[SerializeField]
	private Image _imgBg;

	[SerializeField]
	private Image _imgLeftBg;

	[SerializeField]
	private Image _imgSelected;

	[SerializeField]
	private DxxText _textDifficulty;

	[SerializeField]
	private DxxText _textUnlockTips;

	[SerializeField]
	private GameObject _goLockMask;

	[SerializeField]
	private ButtonCtrl _btnSelect;

	[SerializeField]
	private DxxText _textBtn;

	[SerializeField]
	private ScrollRect _scrollView;

	[SerializeField]
	private RectTransform _content;

	private Daily_TrialDifficulty_128 _data;

	private LocalUnityObjctPool _pool;

	public int ID => 0;

	public void Refresh(Daily_TrialDifficulty_128 data, Action<Daily128DifficultyItemCtrl> onClick)
	{
	}

	public void UpdateLockStatus(bool isUnlocked = true)
	{
	}

	public void UpdateSelectStatus()
	{
	}
}
