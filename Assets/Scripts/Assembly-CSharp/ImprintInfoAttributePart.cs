using System.Collections.Generic;
using UnityEngine;

public class ImprintInfoAttributePart : MonoBehaviour
{
	public DxxText Text_Title;

	public ImprintInfoAttributeItem itemCopy;

	private List<ImprintInfoAttributeItem> m_listItems;

	protected LocalSave.ImprintOne m_data;

	protected List<ImprintInfoAttributeItem.AttrInfo> infoList;

	protected bool m_isShowAdd;

	public void Init()
	{
	}

	public void Refresh(LocalSave.ImprintOne data, bool showAdd = true)
	{
	}

	public void OnLevelChange()
	{
	}

	public virtual void OnRefreshData()
	{
	}

	public void RefreshUI()
	{
	}

	private void OnDestroy()
	{
	}

	public void DeInit()
	{
	}
}
