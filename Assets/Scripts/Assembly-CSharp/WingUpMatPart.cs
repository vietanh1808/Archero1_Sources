using UnityEngine;
using UnityEngine.UI;

public class WingUpMatPart : MonoBehaviour
{
	public Slider starSlider;

	public UISliderTween uISliderTween;

	public DxxText titleTex;

	public DxxText sliderTex;

	public PropOneEquip[] propOnes;

	private LocalSave.WingOne WingOne;

	private bool isStar;

	public void Open(LocalSave.WingOne wing, bool isStar)
	{
	}

	public void Refresh(bool isAni = false)
	{
	}

	private void OnLevelUp()
	{
	}

	private void OnStarUp()
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
