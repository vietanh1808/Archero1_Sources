namespace UnityEngine.UI.CoroutineTween
{
	public interface ITweenValue
	{
		bool ignoreTimeScale { get; }

		float duration { get; }

		void TweenValue(float floatPercentage);

		bool ValidTarget();
	}
}
