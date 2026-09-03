using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SuperRouletteBox : MonoBehaviour
{
	public Slider m_slider;

	public UISliderTween tween;

	[FormerlySerializedAs("m_List")]
	public List<SuperRouletteBoxOne> boxes;

	public SuperRewardCountInformation m_infomation;

	public DxxText txtCurrent;

	public void Init()
	{
	}

	public void OnOpen()
	{
	}

	public void updateUI()
	{
	}

	public void SetBtnMask()
	{
	}

	public void UpdateBtn()
	{
	}

	public void stopAllEff()
	{
	}

	private float GetSliderValue()
	{
		return 0f;
	}
}
