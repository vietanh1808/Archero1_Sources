using UnityEngine;
using UnityEngine.UI;

public class ImprintLevelUpPart : MonoBehaviour
{
	public Slider levelSlider;

	public DxxText prossText;

	public Image star;

	public ImprintLevelUpConsumeItem[] consumeItems;

	public RectTransform sliderEffectObj;

	public Animator animator;

	private LocalSave.ImprintOne mData;

	public void Init(LocalSave.ImprintOne imprint)
	{
	}

	private void Refresh()
	{
	}

	private void OnLevelChange()
	{
	}

	private void OnDestroy()
	{
	}

	public void DeInit()
	{
	}
}
