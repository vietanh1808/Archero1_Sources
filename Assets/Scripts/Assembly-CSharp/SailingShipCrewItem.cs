using System;
using UnityEngine;
using UnityEngine.UI;

public class SailingShipCrewItem : MonoBehaviour
{
	public DxxImage crewIcon;

	public DxxImage selectIcon;

	public DxxText crewStar;

	public ButtonCtrl btnCrew;

	public Image Image_Star;

	private int _crtCrewID;

	public void Init(int crewID, int roomID, int star, Action<int> onCrewClick = null, bool isInShowList = false)
	{
	}

	public void SetSelect(int crewID)
	{
	}
}
