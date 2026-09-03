using UnityEngine;
using UnityEngine.UI;

public class HallComMonsterItem : MonoBehaviour
{
	[SerializeField]
	private Image image_Monster;

	[SerializeField]
	private Image image_Bg;

	[SerializeField]
	private Slider s_progress;

	[SerializeField]
	private DxxText text_progress;

	private int crtIndex;

	private HalloweenMonsterData crtData;

	public void Init(int index)
	{
	}

	public void Refresh()
	{
	}
}
