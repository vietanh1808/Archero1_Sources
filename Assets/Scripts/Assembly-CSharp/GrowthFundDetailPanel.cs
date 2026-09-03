using UnityEngine;
using UnityEngine.UI;

public class GrowthFundDetailPanel : MonoBehaviour
{
	[SerializeField]
	private DxxText txtPurchasePrice;

	[SerializeField]
	private DxxText txtRewardUnlocked;

	[SerializeField]
	private DxxText txtRewardTotal;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText starNumTex;

	[SerializeField]
	private GameObject goTemplate;

	[SerializeField]
	private GameObject goPurchase;

	[SerializeField]
	private GameObject starBuyObj;

	[SerializeField]
	private RectTransform unlockedRoot;

	[SerializeField]
	private RectTransform totalRoot;

	[SerializeField]
	private ScrollRect sr1;

	[SerializeField]
	private ScrollRect sr2;

	[SerializeField]
	private ButtonCtrl btnBuy;

	[SerializeField]
	private ButtonCtrl btnClose;

	private LocalUnityObjctPool pool;

	private string productId;

	public VIPFlagItem vipItem;

	private bool isPremium;

	private void Awake()
	{
	}

	private void Close()
	{
	}

	private void OnDisable()
	{
	}

	public void Open(bool isPremium)
	{
	}
}
