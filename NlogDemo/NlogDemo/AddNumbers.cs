using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace NlogDemo
{
    class AddNumbers
    {
        readonly Nlog nLog = new Nlog();
        public int Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                nLog.LogDebug("Debug Successfull : Sum()");
                nLog.LogError("Expecting null values");
                nLog.LogWarn("a or b should not equal to 0");
            }
            int c = a + b;
            nLog.LogDebug("Debug Successfull : Sum()");
            nLog.LogInfo("Sum method passed, Result" + c);
            return c;
        }
    }

}
