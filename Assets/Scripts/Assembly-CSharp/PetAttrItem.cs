using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class PetAttrItem : UITableViewCell
{
	public RectTransform RTF;

	public Image Image_BG;

	public DxxText attrText;

	public GameObject allObj;

	public DxxText allText;

	private static readonly Color bgcolor;

	private static Color textcolor;

	private static Color imagecolor;

	private static Color whiteColor;

	public GameObject Locker;

	public GameObject Unlocker;

	public DxxText Text_NeedLevel;

	public GameObject StarPanel;

	public Image[] Img_Stars;

	public Animator UpgradeAnim;

	private PetAttrData data;

	public void init(PetAttrData data)
	{
	}

	public void CheckPlayLevelUp()
	{
	}
}
