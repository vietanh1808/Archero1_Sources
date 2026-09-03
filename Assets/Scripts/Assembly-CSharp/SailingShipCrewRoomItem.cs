using System;
using UnityEngine;

public class SailingShipCrewRoomItem : MonoBehaviour
{
	public ButtonCtrl btnRoom;

	public SailingShipCrewItem crewItem;

	public SailingShipPetItem petItem;

	public DxxImage bpIcon;

	public RedNodeCtrl crewNode;

	private SailingShipCrewRoomItemData _data;

	public void Init(SailingShipCrewRoomItemData data, Action<int> roomClick, bool isOtherPlayer = false)
	{
	}

	public void RefreshNode(bool isOtherPlayer)
	{
	}
}
