using System;
using UnityEngine;

public class SailingShipCrewRoomCtrl : MonoBehaviour
{
	public SailingShipCrewRoomItem[] roomItems;

	public SailingShipCrewRoomItem[] bpRoomItems;

	private SailingShipCrewRoomData CrtRoomData;

	public void Init(SailingShipCrewRoomData data, Action<int> crewRoomClicked, bool isFromCard = false, bool isOtherPlayer = false)
	{
	}
}
