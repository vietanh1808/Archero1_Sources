using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class NewPlay126SkillGroup : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private NewPlay126SkillItem skillItem;

	[SerializeField]
	private Transform leftParent;

	[SerializeField]
	private Transform rightParent;

	private List<NewPlay126SkillItem> createItemList;

	private LocalUnityObjctPool pool;

	private NewPlay126SkillGroupData SkillGroupData => null;

	private bool IsLeft => false;

	public void OnInit()
	{
	}

	private void InitPool()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshStatus()
	{
	}

	public void RefreshItemStatus()
	{
	}
}
