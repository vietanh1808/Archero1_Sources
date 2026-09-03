namespace HabbySdk.HabbyId
{
	public interface IChangeUI
	{
		void RegisterEvents();

		void UnRegisterEvents();

		void HandleLoginEvent(C2V_LoginEvent eventData);
	}
}
