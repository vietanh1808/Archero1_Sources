using DG.Tweening;
using UnityEngine;

public class EventWeaponSkinCtrl : CommonHitCtrl
{
	[SerializeField]
	private Transform _weaponParent;

	[SerializeField]
	private GameObject _lock;

	private AllWeaponSkinsCtrl allWeaponSkinsCtrl;

	private int weaponSkinId;

	private GameObject goWeapon;

	private GameObject goEffect;

	private Tweener tweener;

	[HideInInspector]
	public int WeaponSkinId => 0;

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected override void OnTriggerEnter(Collider other)
	{
	}

	public void Init(int id)
	{
	}

	public void DestroyImmediate()
	{
	}

	public void PlayDisappearAnim()
	{
	}

	public void SetInvisible()
	{
	}

	private void killTweener()
	{
	}

	private void destroyInternal()
	{
	}

	private GameObject createWeapon(int weaponSkinId)
	{
		return null;
	}
}
