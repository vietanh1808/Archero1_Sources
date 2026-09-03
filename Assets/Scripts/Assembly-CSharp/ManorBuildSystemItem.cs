using UnityEngine;

public sealed class ManorBuildSystemItem : MonoBehaviour
{
	private Material _gray;

	public HellSystemItemData crtData;

	public DxxImage icon_Build;

	public DxxImage icon_BuildBg;

	public DxxImage icon_Star;

	public DxxText txt_Star;

	public DxxText txt_level;

	public DxxText txt_Add;

	public GameObject go_Level;

	public GameObject go_Star;

	public ButtonCtrl btn_Click;

	public Material GrayMaterial => null;

	public void Init(HellSystemItemData itemData, HellSystemBuffType hType)
	{
	}
}
