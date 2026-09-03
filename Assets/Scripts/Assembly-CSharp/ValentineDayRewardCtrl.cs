using System;
using DG.Tweening;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ValentineDayRewardCtrl : MonoBehaviour
{
	[SerializeField]
	private PropOneEquip _propOneEquip;

	[SerializeField]
	private GameObject _goBlueRose;

	[SerializeField]
	private GameObject _goRedRose;

	[SerializeField]
	private DxxText _textBlueRoseCnt;

	[SerializeField]
	private DxxText _textRedRoseCnt;

	[SerializeField]
	private Image _imgBox;

	[SerializeField]
	private Image _imgClaimed;

	[SerializeField]
	private ButtonCtrl _boxButton;

	[SerializeField]
	private Animation _claimableAni;

	private Transform _shakeTarget;

	private Daily_LoverReward_111 _data;

	private Tween _shakeTween;

	private Vector3 _shakeOrigin;

	public Daily_LoverReward_111 Data => null;

	public void Init(Daily_LoverReward_111 data, Action<ValentineDayRewardCtrl> OnClick)
	{
	}

	public bool CheckProcess(out int blueRose, out int redRose)
	{
		blueRose = default;
		redRose = default;
		return false;
	}

	private void UpdateClaimVisual(bool claimed, bool claimable)
	{
	}
}
