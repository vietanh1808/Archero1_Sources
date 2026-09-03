using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class TalentScoreItemCell : UITableViewCell
{
	public DxxText Text_Rank;

	public Text Text_Title;

	public GameObject Finish;

	public PropOneEquip prop;

	[SerializeField]
	private GameObject LineTop;

	[SerializeField]
	private GameObject LineBottom;

	private int aid;

	public void init(int aid, int total)
	{
	}
}
