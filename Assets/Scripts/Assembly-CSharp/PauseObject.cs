using UnityEngine;

public abstract class PauseObject : MonoBehaviour
{
	protected bool useLateUpdate;

	private int DeltaTime;

	private void Update()
	{
	}

	protected virtual void UpdateProcess()
	{
	}
}
