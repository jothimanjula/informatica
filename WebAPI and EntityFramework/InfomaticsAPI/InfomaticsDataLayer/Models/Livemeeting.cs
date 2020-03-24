using System;
using System.Collections.Generic;

namespace InfomaticsDataLayer.Models
{
    public partial class Livemeeting
    {
        public int LiveMeetingId { get; set; }
        public string LiveMeetingSubject { get; set; }
        public string LiveMeetingAttendees { get; set; }
        public string LiveMeetingAgenda { get; set; }
        public DateTime LiveMeetingDate { get; set; }
        public TimeSpan LiveMeetingStartTime { get; set; }
        public TimeSpan LiveMeetingEndTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
    }
}
