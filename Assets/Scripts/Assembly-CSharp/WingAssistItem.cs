using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WingAssistItem : MonoBehaviour
{
	public ButtonCtrl clickBtn;

	public GameObject lockObj;

	public GameObject UnLockObj;

	public DxxText starTex;

	public PauseUISkillIconCtrl skillIconCtrl;

	public Image wingIcon;

	private LocalSave.WingOne wing;

	private int seatIndex;

	public UnityEvent clickDo;

	public void Init(LocalSave.WingOne wingOne, int index)
	{
	}

	public void Refresh()
	{
	}

	public void OnClick()
	{
	}

	public void UnInit()
	{
	}
}
