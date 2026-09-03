using UnityEngine;
using XLua;

public class CustomRewardItem : MonoBehaviour
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtCount;

	[SerializeField]
	private DxxText txtBtnPrice;

	[SerializeField]
	private DxxText txtGuildBox;

	[SerializeField]
	private ButtonCtrl btnBuy;

	[SerializeField]
	private PropOneEquip propMain;

	[SerializeField]
	private RedNodeCtrl redNode;

	[SerializeField]
	private PropOneEquip[] optionalProps;

	[SerializeField]
	private DxxImage[] propFrames;

	[SerializeField]
	private GuildBoxButton btnGuildBox;

	[SerializeField]
	private ImageSwitcher switcher;

	private ActivityCustomRewardData data;

	public VIPFlagItem vipItem;

	public GameObject crit;

	public DxxText Text_X;

	public DxxText Text_Discount;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge __Hotfix0_RefreshUI;

	private static DelegateBridge __Hotfix0_OnClickBuy;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public void SetData(ActivityCustomRewardData customRewardData)
	{
	}

	private void RefreshUI()
	{
	}

	private void OnClickBuy()
	{
	}
}
