namespace TechTalk.JiraRestClient
{
    using System.Collections.Generic;

    internal class TransitionsContainer
    {
        public string expand { get; set; }

        public List<Transition> transitions { get; set; }
    }
}