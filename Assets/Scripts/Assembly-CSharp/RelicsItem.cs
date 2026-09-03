using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class RelicsItem : UITableViewCell
{
	public Image Image_Icon;

	public Image Image_Plate;

	public Image Image_Light;

	public Image Image_Slider;

	public Image Image_Title;

	public Image Image_Mask;

	public GameObject Stars;

	public DxxText Text_Name;

	public DxxText Text_Level;

	public Slider slider;

	public DxxText Text_Silder;

	public Image Image_Fragment;

	public GameObject Fragment;

	public Material Mat_Gray;

	public GameObject RedPoint;

	public GameObject Panel;

	private int relicsId;

	private RelicsPanel.RelicsShowData rsdata;

	public void init(RelicsPanel.RelicsShowData data)
	{
	}

	private void initUI(int reid)
	{
	}

	private void showStar(int have)
	{
	}

	public void onButtonClick()
	{
	}

	private void freshRedPoint()
	{
	}

	public void showRedPoint(bool show)
	{
	}
}
