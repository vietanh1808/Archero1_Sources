using UnityEngine;

public class DiamondPrivilegeUIPanel : MonoBehaviour
{
	[SerializeField]
	private DxxText txt_cardName;

	[SerializeField]
	private DxxText txt_status;

	[SerializeField]
	private DxxText txt_buyTitle;

	[SerializeField]
	private DxxText txt_buy;

	[SerializeField]
	private DxxText txt_price;

	[SerializeField]
	private DxxText txt_get;

	[SerializeField]
	private ButtonCtrl btn_Buy;

	[SerializeField]
	private Transform trans_Parent;

	[SerializeField]
	private PrivilegeItem item;

	[SerializeField]
	private PropOneEquip buyReward1;

	[SerializeField]
	private PropOneEquip buyReward2;

	[SerializeField]
	private RedNodeCtrl redNodeCtrl;

	[SerializeField]
	private DxxImage icon_RewardGot1;

	[SerializeField]
	private DxxImage icon_RewardGot2;

	[SerializeField]
	private FitContentText firstPrivilegeDesc;

	[SerializeField]
	private ButtonCtrl _firstPrivilegeBtn;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private DiamondPrivilegeData DiamondPrivilegeData => null;

	public void Init()
	{
	}

	private void OnBtnBuyClick()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshBtnTxtState()
	{
	}

	public void RefreshItem()
	{
	}

	public void RefreshText()
	{
	}

	public void OnLanguageChange()
	{
	}
}
