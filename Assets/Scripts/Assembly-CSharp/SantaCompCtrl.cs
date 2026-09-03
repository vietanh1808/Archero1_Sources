using UnityEngine;
using UnityEngine.UI;

public class SantaCompCtrl : MonoBehaviour
{
	private DIYEquipVO diyVO;

	public Image img_plus;

	public Image img_icon;

	public ButtonCtrl btn_comp;

	[SerializeField]
	private Image frame;

	[SerializeField]
	private RedNodeCtrl redNodeCtrl;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void Refresh(DIYEquipVO vo)
	{
	}

	private bool HaveBetterComp(DIYEquipVO comp)
	{
		return false;
	}
}
