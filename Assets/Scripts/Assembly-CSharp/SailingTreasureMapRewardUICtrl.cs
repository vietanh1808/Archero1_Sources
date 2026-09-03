using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SailingTreasureMapRewardUICtrl : MonoBehaviour
{
	[SerializeField]
	private RectTransform _content;

	[SerializeField]
	private ButtonCtrl _btnGet;

	[SerializeField]
	private Image _imgBox;

	[SerializeField]
	private DxxText _textGet;

	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private DxxText _textDesc;

	[SerializeField]
	private Image _imageTarget;

	[SerializeField]
	private SailingTreasureMapRewardItemCtrl _copyOne;

	[SerializeField]
	private Transform _rewardParent1;

	[SerializeField]
	private Transform _rewardParent2;

	[SerializeField]
	private DxxText _textRewardPreviewTitle;

	[SerializeField]
	private Animation _animation;

	private LocalUnityObjctPool _pool;

	private ShipBattle_TreasureMap _data;

	public void Init()
	{
	}

	public void Open(ShipBattle_TreasureMap data, bool claimed)
	{
	}

	private void UpdateRewards(bool claimed)
	{
	}

	private void OnClickGet()
	{
	}

	public void CloseUI()
	{
	}

	public void OnLanguageChanged()
	{
	}

	private void OnDestroy()
	{
	}
}
