using UnityEngine;
using UnityEngine.Events;

public class ParticleSystemCallbackInvoker : MonoBehaviour
{
	public UnityEvent onParticleSystemStopped;

	private void OnParticleSystemStopped()
	{
	}
}
