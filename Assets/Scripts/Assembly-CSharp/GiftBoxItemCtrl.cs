using UnityEngine;
using UnityEngine.UI;
using XLua;

public class GiftBoxItemCtrl : MonoBehaviour
{
	public DxxText titleText;

	public DxxText okText;

	public GameObject[] rewards;

	public Slider slider;

	public DxxText Slider_Progress;

	public Image Image_HaveGet;

	public ButtonCtrl Button_Get;

	public Image Image_BG;

	public Image Image_Title;

	private GiftBoxManager.GiftItemData data;

	private GiftBoxManager.GiftBoxType type;

	private Color canGetColor;

	public Color[] normalColor;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_OnButtonGet;

	private static DelegateBridge __Hotfix0_freshItem;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(GiftBoxManager.GiftBoxType type, GiftBoxManager.GiftItemData data)
	{
	}

	public void OnButtonGet()
	{
	}

	public void freshItem()
	{
	}
}
