using System;
using UnityEngine;

public class CampTeachTabCtrl : MonoBehaviour
{
	public GameObject Go_Selected;

	public GameObject Go_UnSelected;

	public ButtonCtrl Button_Tab;

	private Action<int> _onClick;

	private int _index;

	public void Init(int index, Action<int> onClick)
	{
	}

	public void RefreshBtnStatus(int index)
	{
	}
}
