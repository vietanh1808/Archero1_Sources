using UnityEngine;
using UnityEngine.UI;

public class SailingMilitaryRankUpgradeUICtrl : MonoBehaviour
{
	[SerializeField]
	private TapToCloseCtrl mCloseCtrl;

	[SerializeField]
	private Image _imgMilitaryRank;

	[SerializeField]
	private DxxText _textMilitaryRankName;

	[SerializeField]
	private DxxText _textAttrName;

	[SerializeField]
	private DxxText _textAttrValue;

	[SerializeField]
	private DxxText _textPreAttrValue;

	public void Init(int lv)
	{
	}
}
