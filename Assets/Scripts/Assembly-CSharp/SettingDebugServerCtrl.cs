using UnityEngine;

public class SettingDebugServerCtrl : MonoBehaviour
{
	public DxxInput mInput;

	public ButtonCtrl Button_Set;

	public ButtonCtrl Button_Clear;

	public ButtonCtrl Button_Formal;

	public ButtonCtrl Button_FormalPre;

	public ButtonCtrl Button_Test;

	[SerializeField]
	private ButtonCtrl _buttonDev;

	private void Awake()
	{
	}
}
