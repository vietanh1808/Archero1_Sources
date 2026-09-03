using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
[RequireComponent(typeof(Animator))]
public class ToggleCtrl : UIBehaviour
{
	private const string ISON_TRIGGER = "IsOn";

	private bool m_UseAnimation;

	private Toggle m_Toggle;

	private Animator m_Animator;

	public bool useAnimation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Toggle toggle => null;

	public Animator animator => null;

	protected override void Awake()
	{
	}

	private void OnValueChange(bool isOn)
	{
	}
}
