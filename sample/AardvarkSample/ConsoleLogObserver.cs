using System;
using Foundation;

using Square.Aardvark;

namespace AardvarkSample
{
	public class ConsoleLogObserver : NSObject, ILogObserver
	{
		public LogDistributor LogDistributor { get; set; }

		public void ObserveLogMessage (LogMessage logMessage)
		{
			Console.WriteLine ("ConsoleLogObserver: " + logMessage.Text);
		}
	}
}
