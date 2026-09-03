using UnityEngine;
using UnityEngine.UI;

public class ChangeSantaCompCtrl : MonoBehaviour
{
	private DIYEquipVO diyVO;

	public RedNodeCtrl redNodeCtrl;

	public Image img_icon;

	public Image img_plus;

	public Image img_selected;

	public ButtonCtrl btn_comp;

	[SerializeField]
	private Image qualityFrame;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void Refresh(ChangeSantaCompPanel panel, DIYEquipVO vo)
	{
	}
}
