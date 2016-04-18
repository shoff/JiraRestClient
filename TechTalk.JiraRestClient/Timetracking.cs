namespace TechTalk.JiraRestClient
{
    using System.Globalization;

    public class Timetracking
    {
        private const decimal DayToSecFactor = 8*3600;
        public string originalEstimate { get; set; }
        public int originalEstimateSeconds { get; set; }

        public decimal originalEstimateDays
        {
            get { return this.originalEstimateSeconds/DayToSecFactor; }
            set
            {
                this.originalEstimate = string.Format(CultureInfo.InvariantCulture, "{0}d", value);
                this.originalEstimateSeconds = (int) (value*DayToSecFactor);
            }
        }
    }
}