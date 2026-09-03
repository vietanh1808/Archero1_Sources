using UnityEngine;

public sealed class HeroCardOneCtrl : MonoBehaviour
{
	private static Material _gray;

	public HeroCardInfo CardData;

	public DxxImage CardImage;

	public ButtonCtrl SelectBtn;

	public DxxText RoleLevelText;

	public GameObject UpgradeNode;

	public DxxImage SelectBorder;

	public DxxText DiscountNum;

	public GameObject DiscountImage;

	public DxxText DiscountText;

	[SerializeField]
	private ButtonCtrl discountTip;

	public DxxImage RatingImage;

	public GameObject skinCollectRed;

	private bool isGuide_HeroAssist;

	public static Material GrayMaterial => null;

	public void Init(HeroCardInfo data, int selectId)
	{
	}

	public void SetGray(bool ifGray)
	{
	}

	public void UpdateIcon()
	{
	}

	public void SetUpgradeEnable(bool ifUpgrade)
	{
	}

	public void UpdateState(int selectIndex)
	{
	}

	public void OnClick()
	{
	}

	private void ClickTip()
	{
	}
}
