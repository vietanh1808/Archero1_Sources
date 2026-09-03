using System;
using UnityEngine;

public class SailingShipPetItem : MonoBehaviour
{
	public DxxImage petIcon;

	public DxxImage selectIcon;

	public DxxImage border;

	public DxxImage rating;

	public PetStarCtrl petStarCtrl;

	public PetLTStarCtrl petLTStarCtrl;

	public ButtonCtrl btnPet;

	private int _crtPetID;

	private LocalSave.PetOne _cardData;

	public void Init(int petID, int roomID, int star, Action<int> onPetClick = null, bool isInShowList = false)
	{
	}

	public void SetSelect(int petID)
	{
	}
}
