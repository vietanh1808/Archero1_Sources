using PureMVC.Interfaces;

public interface IUILifeCycle
{
	void OnInit();

	void OnOpen();

	void OnClose();

	void OnHandleNotification(INotification notification);

	void OnLanguageChange();
}
