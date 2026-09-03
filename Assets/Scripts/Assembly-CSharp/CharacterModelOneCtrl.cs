using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class CharacterModelOneCtrl : MonoBehaviour
{
	public PlayerCharacter_Character tableData;

	public Transform modelParent;

	public GameObject model;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Choose;

	private static Dictionary<int, GameObject> modelDic;

	private PlayerCharacter_Character mData;

	private int mIndex;

	private ScrollIntCharacterModelCtrl m_scroll;

	public static void OnClose()
	{
	}

	public void Init(int index, PlayerCharacter_Character data)
	{
	}

	public void CreatModel()
	{
	}

	public void SetScrollView(ScrollIntCharacterModelCtrl scroll)
	{
	}

	public void Refresh()
	{
	}

	private string GetBodyString(string value)
	{
		return null;
	}
}
