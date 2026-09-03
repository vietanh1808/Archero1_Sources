using GameProtocol;
using UnityEngine;

public class PermanentPrivilegeUIPanel : MonoBehaviour
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText privilegeStatus;

	[SerializeField]
	private DxxText buyTitle;

	[SerializeField]
	private DxxText buyBtnName;

	[SerializeField]
	private PropOneEquip buyReward1;

	[SerializeField]
	private PropOneEquip buyReward2;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private PrivilegeItem item;

	[SerializeField]
	private DxxText activeText;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private PrivilegeManager PrivilegeManager => null;

	private PermanentPrivilegeData PermanentPrivilegeData => null;

	private void InitObjectPool()
	{
	}

	private void OnInit()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void Refresh()
	{
	}

	public void updateUI()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void Click()
	{
	}

	private void PurchaseReward()
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}

	private void onButtonStarBuy()
	{
	}
}
