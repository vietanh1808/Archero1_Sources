using UnityEngine;

public sealed class RefineSystemItem : MonoBehaviour
{
	public HellSystemItemData crtData;

	public DxxImage icon_Pos;

	public DxxImage icon_Star;

	public DxxText txt_Star;

	public DxxText txt_Add;

	public ButtonCtrl btn_Click;

	public void Init(HellSystemItemData itemData, HellSystemBuffType hType)
	{
	}

	public string GetSpriteName(int position)
	{
		return null;
	}
}
