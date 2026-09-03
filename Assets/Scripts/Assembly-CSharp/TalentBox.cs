using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class TalentBox : UITableViewCell
{
	public Image[] Line;

	public Image Item1;

	public Image Item2;

	public Image Icon;

	public Image Red;

	public Material Mat_Gray;

	public DxxText Text_ID;

	[SerializeField]
	private DxxText Text_Lv;

	private TalentUI ui;

	private int tid;

	public void init(TalentUI ui, int tid)
	{
	}

	public void FreshItem()
	{
	}

	public void onButtonClick()
	{
	}

	public void drawLine(bool u)
	{
	}

	public void calcuteLine(Vector3 position1, Vector3 position2, out float length, out float angel)
	{
		length = default;
		angel = default;
	}
}
