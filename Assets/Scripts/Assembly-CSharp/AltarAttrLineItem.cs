using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class AltarAttrLineItem : MonoBehaviour
{
	[SerializeField]
	private DxxText Text_Name;

	[SerializeField]
	private DxxText Text_Before;

	[SerializeField]
	private DxxText Text_After;

	[SerializeField]
	private Image Image_Arrow;

	public GameObject baseatt;

	public DxxText Text_Tips;

	public Animator mArrowAni;

	public Animation mAfterAni;

	private int type;

	private string infoformat;

	private float infostart;

	private float infoend;

	private bool isFloat;

	private int beforeValue;

	private int afterValue;

	public void init(AltarAttrData data)
	{
	}

	private void mode0(AltarAttrData data)
	{
	}

	private void mode1(AltarAttrData data)
	{
	}

	private void mode2(AltarAttrData data)
	{
	}

	public void UpdateUI(LocalSave.EquipOne mBefore, LocalSave.EquipOne mAfter, int index)
	{
	}

	private void refreshEffectSkill(int skillid)
	{
	}

	private void set_text_before(string value)
	{
	}

	private void set_text_after(string value)
	{
	}

	public void DoAnimation()
	{
	}

	public Sequence GetTweener()
	{
		return null;
	}
}
