using UnityEngine;
using UnityEngine.UI;

public class GrowthFundPanel : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btnBuyPremium;

	[SerializeField]
	private ButtonCtrl btnBuyNormal;

	[SerializeField]
	private DxxText txtBtnBuyPremium;

	[SerializeField]
	private DxxText txtBtnBuyNormal;

	[SerializeField]
	private DxxText txtPremium;

	[SerializeField]
	private DxxText txtNormal;

	[SerializeField]
	private DxxText txtFree;

	[SerializeField]
	private DxxText textBtnStarBuyPremium;

	[SerializeField]
	private DxxText textBtnStarBuyNormal;

	[SerializeField]
	private GameObject goBtnBuyPremium;

	[SerializeField]
	private GameObject goBtnBuyNormal;

	[SerializeField]
	private GameObject goBtnStarBuyPremium;

	[SerializeField]
	private GameObject goBtnStarBuyNormal;

	[SerializeField]
	private GrowthFundInfinity infinity;

	[SerializeField]
	private GrowthFundDetailPanel detailPanel;

	[SerializeField]
	private RectTransform rtBgLocked;

	[SerializeField]
	private RectTransform rtBar;

	public StarDiamondItem starDiamond;

	public ScrollRect scrollRect;

	public Image Image_TitleBG;

	public DxxText Text_Title;

	public Color[] titleColor;

	public Image Image_BGMask;

	public Color[] colorTop;

	public Color[] colorBottom;

	private int LastFundId;

	private bool IsPurchasedPremium => false;

	private bool IsPurchasedNormal => false;

	private void Awake()
	{
	}

	private void UpdateItem(int index, GrowthFundItem item)
	{
	}

	private void OnBtnBuyNormalClick()
	{
	}

	private void OnBtnBuyPremiumClick()
	{
	}

	public void Open()
	{
	}

	public void Refresh()
	{
	}

	public void Close()
	{
	}
}
