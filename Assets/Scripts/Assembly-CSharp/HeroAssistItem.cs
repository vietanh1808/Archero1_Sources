using UnityEngine;
using UnityEngine.UI;
using XLua;

public class HeroAssistItem : MonoBehaviour
{
	public RawImage img_hero;

	protected HeroShow heroShow;

	public RectTransform ModelContainer;

	public GameObject Add;

	public GameObject Locker;

	public GameObject Shadow;

	public RectTransform RTF_Top;

	public RectTransform RTF_Bottom;

	public DxxText Text_TopName;

	public DxxText Text_TopLv;

	public DxxText Text_BottomName;

	public DxxText Text_BottomLv;

	public DxxText Text_BottomPos;

	public GameObject BottomLv;

	public Transform TF_Effect;

	private float bodyScale1;

	private float bodyScale2;

	private int leadid;

	private int heroid;

	private int index;

	public GameObject switch_guider;

	public DxxText Text_Switch;

	private int state;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonClick;

	private static DelegateBridge __Hotfix0_LoadModel;

	private static DelegateBridge __Hotfix0_createHeroModel;

	private static DelegateBridge __Hotfix0_createHeroShow;

	private static DelegateBridge __Hotfix0_setSwitchGuider;

	private static DelegateBridge __Hotfix0_closeModel;

	private static DelegateBridge __Hotfix0_PlayUpAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(int leadid, int heroid, int index)
	{
	}

	public void onButtonClick()
	{
	}

	private void LoadModel()
	{
	}

	private void createHeroModel(GameObject o2)
	{
	}

	private GameObject createHeroShow(GameObject o2)
	{
		return null;
	}

	public void setSwitchGuider(bool show)
	{
	}

	public void closeModel()
	{
	}

	public void PlayUpAni()
	{
	}
}
