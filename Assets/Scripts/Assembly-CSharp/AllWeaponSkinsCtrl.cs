using System;
using UnityEngine;

public class AllWeaponSkinsCtrl : MonoBehaviour
{
	public Action<EventWeaponSkinCtrl> OnWeaponSkinTriggered;

	public Transform BottomTrans;

	private EventWeaponSkinCtrl[] weaponSkinCtrls;

	private bool deinit;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Init(int[] WeaponSkinIds)
	{
	}

	public void DeInit()
	{
	}

	public void PlayDisappearAnim(int weaponSkinId)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void initWeaponSkinCtrls(int[] WeaponSkinIds)
	{
	}
}
