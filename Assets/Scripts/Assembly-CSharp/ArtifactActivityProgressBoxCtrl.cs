using GameProtocol;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactActivityProgressBoxCtrl : UITableViewCell
{
	[SerializeField]
	private ButtonCtrl _btn;

	[SerializeField]
	private Image _imgBox;

	[SerializeField]
	private DxxText _textTalent;

	[SerializeField]
	private Image _imgProgress;

	[SerializeField]
	private Animation _animation;

	[SerializeField]
	private Animation _animation2;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private Transform parent1;

	[SerializeField]
	private Transform parent2;

	[SerializeField]
	private GameObject chestObj;

	[SerializeField]
	private Image _imgClaimed;

	private STActivityArtifactProgressRewardData _data;

	private LocalUnityObjctPool pool;

	public void Refresh(STActivityArtifactProgressRewardData data, float percent)
	{
	}

	private void OnClick()
	{
	}
}
