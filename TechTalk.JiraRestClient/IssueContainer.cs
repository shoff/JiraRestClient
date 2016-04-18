namespace TechTalk.JiraRestClient
{
    using System.Collections.Generic;

    internal class IssueContainer<TIssueFields>
        where TIssueFields : IssueFields, new()
    {
        public string expand { get; set; }

        public int maxResults { get; set; }
        public int total { get; set; }
        public int startAt { get; set; }

        public List<Issue<TIssueFields>> issues { get; set; }
    }
}