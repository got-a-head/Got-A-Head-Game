using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitUtils
{
    /// <summary>
    /// <a href="http://stackoverflow.com/questions/22093843"></a>
    /// <a href="https://stackoverflow.com/questions/22093843/pass-complex-parameters-to-theory"></a>
    /// </summary>
    public interface ITheoryDatum
    {
        object[] ToParameterArray();
    }
}
