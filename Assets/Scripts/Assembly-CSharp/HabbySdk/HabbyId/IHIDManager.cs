using UnityEngine;

namespace HabbySdk.HabbyId
{
	public interface IHIDManager
	{
		bool IsSilentRefreshMode { get; set; }

		void OnEnterGame<T>(T instance) where T : MonoBehaviour, IHIDDriver;

		void Update();

		void Dispose();

		void OnClickHIDLogin();

		void OnClickHIDLoginSilent();

		void Log(string message);

		void LogError(string message);

		HabbyIdLoginData GetHabbyIdLoginData();
	}
}
