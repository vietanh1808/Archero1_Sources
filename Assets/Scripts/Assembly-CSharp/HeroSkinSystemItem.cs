using UnityEngine;

public sealed class HeroSkinSystemItem : MonoBehaviour
{
	private Material _gray;

	public HellSystemItemData crtData;

	public DxxImage CardImage;

	public DxxText txt_Level;

	public DxxText txt_Add;

	public GameObject go_Level;

	public ButtonCtrl btn_Click;

	public HellItemWearStateCtrl wearStateCtrl;

	public Material GrayMaterial => null;

	public void Init(HellSystemItemData itemData, HellSystemBuffType hType)
	{
	}

	public void SetGray(bool ifGray)
	{
	}
}
