using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Act4thBoxTaskItemCell : UITableViewCell
{
	public GameObject BG1;

	public GameObject BG2;

	public DxxText Text_Count;

	public DxxText Text_Title;

	public ButtonCtrl Button_Choose;

	public DxxText Text_Choose;

	public ButtonCtrl Button_Go;

	public DxxText Text_Go;

	public GameObject FinishObj;

	public Slider slider;

	public DxxText Slider_Count;

	public Color color1;

	public Color color2;

	public GameObject RedPoint;

	public Image Image_Icon;

	private Act4thBoxManager.BoxTaskData taskData;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonChoose;

	private static DelegateBridge __Hotfix0_onButtonGo;

	private static DelegateBridge _c__Hotfix0_ctor;

	public new void Awake()
	{
	}

	public void init(Act4thBoxManager.BoxTaskData data)
	{
	}

	private void onButtonChoose()
	{
	}

	private void onButtonGo()
	{
	}
}
