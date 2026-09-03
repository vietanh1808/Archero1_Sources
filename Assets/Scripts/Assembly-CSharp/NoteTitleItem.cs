using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class NoteTitleItem : UITableViewCell
{
	public RectTransform Panel;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public RectTransform RTF_Arrow;

	public Image Image_Mask;

	public Image scrollBar_Down;

	public Image scrollBar_Up;

	public Image Image_Red;

	private NoteItemData data;

	public new void Awake()
	{
	}

	public void init(NoteItemData data)
	{
	}

	public void onButtonTriangle()
	{
	}
}
