using UnityEngine;

public sealed class PetCardOneCtrl : MonoBehaviour
{
	private static Material _gray;

	public LocalSave.PetOne CardData;

	public DxxImage CardBg;

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

	public PetStarCtrl stars;

	public DxxImage typeImage;

	public GameObject switchObj;

	public DxxText switchText;

	public RedNodeCtrl unlockRed;

	public static Material GrayMaterial => null;

	public void Init(LocalSave.PetOne data)
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

	public void UpdateState()
	{
	}

	public void OnClick()
	{
	}

	private void ClickTip()
	{
	}
}
