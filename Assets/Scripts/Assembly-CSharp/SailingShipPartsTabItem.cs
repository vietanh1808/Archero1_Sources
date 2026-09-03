using System;
using UnityEngine;

public class SailingShipPartsTabItem : MonoBehaviour
{
	public GameObject Go_Selected;

	public GameObject Go_UnSelected;

	public ButtonCtrl Btn_Parts;

	public Action<int> OnClickCallBack;

	public DxxImage PartIcon;

	public RedNodeCtrl redNode;

	public DxxText PartLevel;

	public Color SelectColor;

	public Color UnSelectColor;

	private int _index;

	private SailingShipPartItemData pData;

	public void Init(SailingShipPartItemData data)
	{
	}

	public void SetSelected(int partID)
	{
	}

	public void RefreshRedNode()
	{
	}
}
