using UnityEngine;
using UnityEngine.UI;
using XLua;

public class TileBubble : MonoBehaviour
{
	public GameObject BG_Empty;

	public GameObject BG_Full;

	public GameObject Icon;

	public GameObject battle;

	public SpriteRenderer render;

	public Image bg_Full;

	public DxxText Txt_Progress;

	public Button button;

	private TileBubbleData data;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonClick;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(TileBubbleData data)
	{
	}

	public void onButtonClick()
	{
	}
}
