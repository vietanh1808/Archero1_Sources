using UnityEngine;
using UnityEngine.UI;
using XLua;

public class HeroAttrItem : MonoBehaviour
{
	public class ShowData
	{
		public string effect;

		public int needLevel;

		public int curLevel;

		public bool assist;

		public int heroid;

		private static DelegateBridge _c__Hotfix0_ctor;
	}

	public RectTransform RTF;

	public GameObject locker;

	public DxxText attrText;

	public GameObject allObj;

	public DxxText allText;

	private static Color textcolor;

	private static Color imagecolor;

	private static Color whiteColor;

	public Image Image_Head;

	public Material Mat_Gray;

	public Image Image_Lv;

	public DxxText Text_Lv;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(ShowData data)
	{
	}
}
