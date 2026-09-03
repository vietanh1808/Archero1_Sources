using TableTool;
using UnityEngine;
using XLua;

public class DailyTDPopDetailItem : MonoBehaviour
{
	public GameObject goVip;

	public DxxText txt_vipDesc;

	public DxxText txt_tdCoin;

	public DxxImage img_vip;

	public FitContentText txtDesc;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxImage imgIcon;

	[SerializeField]
	private GameObject goTick;

	[SerializeField]
	private GameObject goLock;

	[SerializeField]
	private ButtonCtrl btn;

	private int index;

	private DailyTDTopPanel panel;

	private int layerId;

	private Daily_DefenseTower config;

	private PVEStage_DefenseTower seasonConfig;

	private bool isLocked;

	private string lockedDesc;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnClick;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge __Hotfix0_get_isVipTower;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_GetSprite;

	private static DelegateBridge _c__Hotfix0_ctor;

	private bool isVipTower => false;

	private void Awake()
	{
	}

	private void OnClick()
	{
	}

	public void SetData(int index, int layerId, DailyTDTopPanel panel)
	{
	}

	public void Refresh()
	{
	}

	private Sprite GetSprite(string name)
	{
		return null;
	}
}
