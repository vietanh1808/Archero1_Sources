using System.Collections.Generic;
using UnityEngine;

public class WingUpAttributePart : MonoBehaviour
{
	public WingUpAttrItem wingUpAttrItem;

	public DxxText titleTex;

	public RectTransform itemParent;

	private List<WingUpAttrItem> items;

	private LocalSave.WingOne wingOne;

	private bool isStar;

	public void Open(LocalSave.WingOne wing, bool isStar)
	{
	}

	public void Close()
	{
	}
}
