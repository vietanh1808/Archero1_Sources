using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class NewPlay125WeaponSkill : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private Transform showSkillItemParent;

	[SerializeField]
	private NewPlay125WeaponSkillItem showSkillItem;

	private List<NewPlay125WeaponSkillItem> createList;

	private LocalUnityObjctPool pool;

	private void InitPool()
	{
	}

	public void OnInit()
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

	public void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	public void Clear()
	{
	}
}
