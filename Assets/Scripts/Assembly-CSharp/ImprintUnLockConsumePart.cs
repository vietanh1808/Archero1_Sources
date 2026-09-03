using System;
using UnityEngine;
using UnityEngine.UI;

public class ImprintUnLockConsumePart : MonoBehaviour
{
	[Serializable]
	public class ImprintUnLockConsumeItem
	{
		public GameObject gameObject;

		public DxxText text;

		public Image image;
	}

	public PropOneEquip mEquip;

	public DxxText mText;

	public DxxText mTitleText;

	public GameObject matObj;

	public GameObject imprintObj;

	public ImprintItem[] mItems;

	public ImprintTips tips;

	public Image starIcon;

	private LocalSave.ImprintOne mData;

	public void Init(LocalSave.ImprintOne data)
	{
	}

	private void OnUnLockChange()
	{
	}

	private void OnDestroy()
	{
	}

	public void DeInit()
	{
	}
}
