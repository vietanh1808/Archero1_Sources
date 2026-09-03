namespace Activity
{
	public interface IActivityData
	{
		bool EventExist();

		bool EventStart();

		bool EventEnd();

		bool EventShow();

		bool AnyRedNode();
	}
}
