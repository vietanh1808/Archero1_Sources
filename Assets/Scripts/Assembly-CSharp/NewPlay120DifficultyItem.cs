using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class NewPlay120DifficultyItem : UITableViewCell, INewPlay120RefreshItem<NewPlay120DifficultyItemData>
{
	[SerializeField]
	private Image difficultyBG;

	[SerializeField]
	private Image difficultyLevelBG;

	[SerializeField]
	private Image levelBG;

	[SerializeField]
	private GameObject lockObj;

	[SerializeField]
	private GameObject unLockObj;

	[SerializeField]
	private DxxText lockDes;

	[SerializeField]
	private DxxText unlockDes;

	[SerializeField]
	private DxxText curDifficultyLevel;

	[SerializeField]
	private DxxText selectText;

	[SerializeField]
	private DxxText selectBtnName;

	[SerializeField]
	private ButtonCtrl selectBtn;

	private NewPlay120DifficultyItemData itemData;

	private NewPlay120DifficultyData DifficultyData => null;

	public void Init(NewPlay120DifficultyItemData itemData)
	{
	}

	public void RefreshItem(NewPlay120DifficultyItemData itemData)
	{
	}

	public void RefreshLanguage()
	{
	}

	private void Select()
	{
	}
}
