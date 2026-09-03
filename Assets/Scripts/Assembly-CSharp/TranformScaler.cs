using UnityEngine;

public class TranformScaler : PauseObject
{
	[SerializeField]
	private float startScale;

	[SerializeField]
	private float endScale;

	[SerializeField]
	private float duration;

	private float startTime;

	public void Init(float startScale, float endScale, float duration)
	{
	}

	private void OnEnable()
	{
	}

	protected override void UpdateProcess()
	{
	}
}
