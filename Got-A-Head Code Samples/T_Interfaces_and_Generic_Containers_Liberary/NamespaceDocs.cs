using System;
using System.Collections.Generic;
using System.Text;

namespace T_Interfaces_and_Generic_Containers_Liberary
{
    /// <summary>
    /// I started off by using <a href="https://xunit.net/docs/getting-started/netfx/visual-studio">this</a> web page to start generating my xUnit tests
    /// This project caused much angst and pain before I got it working.
    /// It was created by creating a new directory and then creating the proejct using the VS 2019 command line tool, moving to the folder
    /// and then using the command "dotnet new xunit".  This created a new project that I added into the solution as an existing project.
    /// The Key web pages I found that explained the problem were
    /// <a href="https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test">unit testing with donet text</a>
    /// and
    /// <a href="https://stackoverflow.com/questions/54770830/unable-to-find-testhost-dll-please-publish-your-test-project-and-retry">stack overflow thread on xunit failure to find testhost.dll</a>
    /// Hope this helps.
    /// <br></br>
    /// Then there is also this on <a href="https://stackoverflow.com/questions/39570641/xunit-theory-test-using-generics"> the use of xUnit with Generics</a>
    /// </summary>
    class NamespaceDocs
    {
    }
}
