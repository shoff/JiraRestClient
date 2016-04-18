namespace TechTalk.JiraRestClient
{
    using System;

    public class IssueRef
    {
        public string id { get; set; }
        public string key { get; set; }

        internal string JiraIdentifier
        {
            get { return String.IsNullOrWhiteSpace(this.id) ? this.key : this.id; }
        }
    }
}