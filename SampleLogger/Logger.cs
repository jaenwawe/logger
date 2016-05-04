/*

This is a dumb example to make the logger harness work.. This should be removed... 

*/

namespace SampleLogger
{
    using System;

    public class Logger
    {
        public void Log(string errorMessage, LogLevelSampleEnum logLevel, Exception ex = null)
        {
            // this is a stub to allow us to do mean things....
            Console.WriteLine(errorMessage);
        }
    }

    public enum LogLevelSampleEnum
    {
        TestLevel1 = 1,

        TestLevel2 = 2,

        TestLevel3 = 3,

        TestLevel4 = 4
    }
}
