using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Act4thBoxQueueItem : MonoBehaviour
{
	public GameObject BG0;

	public GameObject BG1;

	public GameObject BG2;

	public Image Open_Icon;

	public DxxText Open_Text;

	public Image Ready_Icon;

	public DxxText Ready_Text;

	public DxxText Ready_NeedKey;

	public DxxText Ready_NeedTime;

	public RedNodeCtrl RedPoint;

	private Act4thBoxManager.QueueData data;

	private int pos;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_Update_Time;

	private static DelegateBridge __Hotfix0_onButtonClick;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(Act4thBoxManager.QueueData data, int pos)
	{
	}

	private void Update_Time()
	{
	}

	public void onButtonClick()
	{
	}
}
