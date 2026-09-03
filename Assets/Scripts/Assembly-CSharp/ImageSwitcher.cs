using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
	[SerializeField]
	private Image target;

	[SerializeField]
	private Sprite[] sprites;

	[SerializeField]
	private int index;

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}
}
