using System;
using UnityEngine;
using UnityEngine.UI;

public class RuneOneCtrl : MonoBehaviour
{
	public Action<int> OnSelect;

	public GameObject LockObj;

	public Text LockText;

	public Image RuneIcon;

	public GameObject SelectObj;

	public ButtonCtrl Btn;

	public int Id { get; private set; }

	public RuneGroup Data { get; private set; }

	private void Awake()
	{
	}

	public void InitData(int id, RuneGroup data, Action<int> onSelect)
	{
	}

	public void UpdateUIByData()
	{
	}

	public void Select(bool ifSelect)
	{
	}
}
