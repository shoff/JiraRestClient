namespace TechTalk.JiraRestClient
{
    using System;
    using System.Collections.Generic;

    public class IssueFields
    {
        public IssueFields()
        {
            this.status = new Status();
            this.timetracking = new Timetracking();

            this.labels = new List<String>();
            this.comments = new List<Comment>();
            this.issuelinks = new List<IssueLink>();
            this.attachment = new List<Attachment>();
            this.watchers = new List<JiraUser>();
        }

        public String summary { get; set; }
        public String description { get; set; }
        public Timetracking timetracking { get; set; }
        public Status status { get; set; }

        public JiraUser reporter { get; set; }
        public JiraUser assignee { get; set; }
        public List<JiraUser> watchers { get; set; }

        public List<String> labels { get; set; }
        public List<Comment> comments { get; set; }
        public List<IssueLink> issuelinks { get; set; }
        public List<Attachment> attachment { get; set; }
    }
}