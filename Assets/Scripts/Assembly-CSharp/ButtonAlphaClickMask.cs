using UnityEngine;
using UnityEngine.UI;

public class ButtonAlphaClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	public bool isUsed;

	protected Image _image;

	public void Start()
	{
	}

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return false;
	}
}
