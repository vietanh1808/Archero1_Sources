using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingArenaNoteItem : UITableViewCell
{
	public GameObject AttackObj;

	public GameObject DefendObj;

	public HeadItem headItem;

	public ButtonCtrl Button_Head;

	public Image Icon_Military;

	public DxxText Text_Name;

	public DxxText Text_Power;

	public DxxText Text_Result;

	public DxxText Text_ScoreChange;

	public Color colorWin;

	public Color colorLose;

	private SailingArenaItemData itemData;

	public new void Awake()
	{
	}

	public void init(SailingArenaItemData data)
	{
	}

	private void onButtonHead()
	{
	}
}
