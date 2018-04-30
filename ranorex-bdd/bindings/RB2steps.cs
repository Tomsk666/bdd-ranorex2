/*
 * Created by Ranorex
 * User: Tom
 * Date: 31/03/2018
 * Time: 11:39
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using TechTalk.SpecFlow;
using Ranorex;
using NUnit.Framework;

namespace ranorex_bdd.bindings
{
    [Binding]
    public class RB2steps
    {

        [When("I connect with (.*)")]
        public void WhenIPressAdd(string user)
        {
            // TODO: implement act (action) logic

            Ranorex.Report.Info("this is the first step");
        }

        [Then("it works")]
        public void ThenTheResultShouldBe()
        {
        	Assert.That(true);
        	
        }
    }
}
