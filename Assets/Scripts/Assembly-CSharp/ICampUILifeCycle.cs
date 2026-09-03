using PureMVC.Interfaces;

public interface ICampUILifeCycle
{
	void OnOpen();

	void OnClose();

	void OnHandleNotification(INotification notification);
}
