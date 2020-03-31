using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace UISpecs.StepDefinition
{
    [Binding]
    public sealed class Hooks
    {// For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Before Scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("After Scenario");
        }
    }
}
