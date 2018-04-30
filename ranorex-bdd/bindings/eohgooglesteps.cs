/*
 * Created by Ranorex
 * User: Tom
 * Date: 30/04/2018
 * Time: 09:37
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using TechTalk.SpecFlow;

namespace ranorex_bdd.bindings
{
    [Binding]
    public class eohgooglesteps
    {
        [Given("that I am on google")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator()
        {

            ScenarioContext.Current.Pending();
        }

        [When("I search for EOH")]
        public void WhenIPressAdd()
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("Its listed on page 1")]
        public void ThenTheResultShouldBe()
        {
            // TODO: implement assert (verification) logic
          
            ScenarioContext.Current.Pending();
        }
    }
}
