using System;
using TechTalk.SpecFlow;
using lab_3.Support;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using Gherkin.CucumberMessages.Types;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.Net;

namespace lab_3.StepDefinitions
{
    [Binding]
    public class CatAPIStepDefinitions: Client
    {
        [Then(@"the response status code should be 200")]
        public void ThenTheResponseStatusShould()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

    }
}
