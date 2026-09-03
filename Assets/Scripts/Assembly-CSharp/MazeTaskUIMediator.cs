using System.Collections.Generic;

public class MazeTaskUIMediator : MediatorBase
{
	public new const string NAME = "MazeTaskUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MazeTaskUIMediator()
		: base(null)
	{
	}
}
