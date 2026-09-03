using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImprintAttributePart : MonoBehaviour
{
	public ButtonCtrl tipsBtn;

	public ButtonCtrl expandBtn;

	public DxxText text_title;

	public ImprintAttributeItem itemCopy;

	public GameObject maskObj;

	public RectTransform itemParent;

	public RectTransform bgRect;

	public ScrollRect scroll;

	public ImprintTips tips;

	private float ExpandHight;

	private float NotExpandHight;

	private List<ImprintAttributeItem> items;

	private bool isExpand;

	public void Init()
	{
	}

	public void Open()
	{
	}

	public void Refresh()
	{
	}

	public void Expand()
	{
	}

	public void OnLanguageChange()
	{
	}
}
