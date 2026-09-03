using UnityEngine.Events;
using UnityEngine.UI;

public class DxxInput : InputField
{
	public DxxText Text_InputTips;

	private UnityAction<string> _onChange;

	public UnityAction<string> onChange
	{
		set
		{
		}
	}
}
