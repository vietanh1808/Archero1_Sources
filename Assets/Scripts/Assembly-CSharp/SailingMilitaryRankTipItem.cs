using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SailingMilitaryRankTipItem : MonoBehaviour
{
	[SerializeField]
	private Image _imgMilitaryRank;

	[SerializeField]
	private Image _imgMilitarySubRank;

	[SerializeField]
	private DxxText _textMilitaryRank;

	[SerializeField]
	private DxxText _textTips;

	public void Init(ShipBattle_Military data, int exp)
	{
	}
}
