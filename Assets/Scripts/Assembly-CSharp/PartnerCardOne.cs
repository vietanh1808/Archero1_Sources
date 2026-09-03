using UnityEngine;
using UnityEngine.UI;

public class PartnerCardOne : MonoBehaviour
{
	public delegate void OnClickDelegate(PartnerCardOne card);

	private static Material _gray;

	[SerializeField]
	private DxxImage CardImage;

	[SerializeField]
	private ButtonCtrl SelectBtn;

	[SerializeField]
	private DxxText RoleLevelText;

	[SerializeField]
	private DxxImage LevelBg;

	[SerializeField]
	private DxxImage SelectImg;

	[SerializeField]
	private Image ImgStar;

	[SerializeField]
	private DxxText TextStar;

	private HeroCardInfo CardData;

	private OnClickDelegate onClickAction;

	public static Material GrayMaterial => null;

	private bool Selected => false;

	public int Id => 0;

	public int Index { get; set; }

	public void Init(int index, HeroCardInfo data, OnClickDelegate onClickAction)
	{
	}

	private void SetGray(bool ifGray)
	{
	}

	public void UpdateState()
	{
	}

	public void OnClick()
	{
	}
}
