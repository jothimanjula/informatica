import { Time } from '@angular/common';

export class Livemeeting
    {
        public LiveMeetingId : number;
        public LiveMeetingSubject : string;
        public LiveMeetingAttendees : string;
        public LiveMeetingAgenda : String;
        public LiveMeetingDate : Date
        public LiveMeetingStartTime : Time;
        public LiveMeetingEndTime : Time;
        public CreatedDate : Date;
        public CreatedBy : string;
        public ModifiedDate : Date;
        public ModifedBy : string;
        public DeletedDate : Date;
        public DeletedBy : string;
    }