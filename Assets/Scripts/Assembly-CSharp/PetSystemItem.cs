using UnityEngine;

public sealed class PetSystemItem : MonoBehaviour
{
	private static Material _gray;

	public DxxImage CardBg;

	public DxxImage CardImage;

	public ButtonCtrl btn_Click;

	public DxxText RoleLevelText;

	public DxxText txt_Add;

	public DxxImage RatingImage;

	public DxxImage typeImage;

	public DxxImage image_Star;

	public DxxText txt_Star;

	public HellItemWearStateCtrl wearStateCtrl;

	private HellSystemItemData crtData;

	public static Material GrayMaterial => null;

	public void Init(HellSystemItemData data, HellSystemBuffType hType)
	{
	}

	public void SetGray(bool ifGray)
	{
	}
}
