using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSkinWeaponItem : MonoBehaviour
{
	public Transform weaponRoot;

	[SerializeField]
	private Graphic target;

	private GameObject weaponobj;

	protected int weaponid;

	protected int weaponHandId;

	protected bool bShow;

	private SequencePool mSeqPool;

	public void Init()
	{
	}

	public void Show(bool value)
	{
	}

	public void InitWeapon(int weaponType, int weaponid)
	{
	}

	protected int GetWeaponHandId(int weaponId)
	{
		return 0;
	}

	public void IsShowWeapon(bool isHide)
	{
	}

	public void SetWeaponColor(int colorID)
	{
	}
}
