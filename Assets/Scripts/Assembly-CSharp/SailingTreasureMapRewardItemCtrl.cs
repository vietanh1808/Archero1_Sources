using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SailingTreasureMapRewardItemCtrl : MonoBehaviour
{
	[SerializeField]
	private Image _Geted;

	[SerializeField]
	private Transform _dropParent;

	[SerializeField]
	private DxxText _textRange;

	private PropOneEquip _equipOne;

	public void Init(Drop_DropModel.DropData dropData, bool claimed)
	{
	}
}
