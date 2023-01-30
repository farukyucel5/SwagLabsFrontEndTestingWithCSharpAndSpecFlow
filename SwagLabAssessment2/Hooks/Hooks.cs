using SwagLabAssessment2.Drivers;
using TechTalk.SpecFlow;

namespace SwagLabAssessment2.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        

        [AfterScenario]
        public void AfterScenario()
        {
            DriverClass.Driver.Quit();
        }
    }
}