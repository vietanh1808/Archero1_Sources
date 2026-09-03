using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WingUpValueShowPart : MonoBehaviour
{
	public HeroPropInfoCtrl hpCtrl;

	public HeroPropInfoCtrl atkCtrl;

	public HeroLevelInfoCtrl levelCtrl;

	public GameObject starParent;

	public DxxText nameText;

	private List<Image> stars;

	private LocalSave.WingOne WingOne;

	private bool isStar;

	public void Init()
	{
	}

	public void Open(LocalSave.WingOne wing, bool isStar)
	{
	}

	private void Refresh(bool isPlayAni = false)
	{
	}

	public void OnLevelUp()
	{
	}

	public void OnStarUp()
	{
	}

	public void RegistEnent()
	{
	}

	public void UnRegistEvent()
	{
	}

	public void Close()
	{
	}
}
