using System;
using System.Collections.Generic;
using System.Text;
using InfomaticsDataLayer.Models;
using System.Linq;

namespace InfomaticsDataLayer
{
    public static class DBOperations
    {
        public static List<Useraccounts> GetUsers()
        {
            List<Useraccounts> users = null;
            try
            {
                using (var context = new INFOMATICSMEETINGContext())
                {
                    users = context.Useraccounts.ToList();                    
                }
            }            
            catch(Exception ex)
            {
                // write in error log
            }
            return users;
        }

        public static List<Livemeeting> GetLivemeetings()
        {
            List<Livemeeting> livemeetingslist = null;
            try
            {
                using (var context = new INFOMATICSMEETINGContext())
                {
                    livemeetingslist = context.Livemeeting.ToList();
                    
                }
            }
            catch (Exception ex)
            {
                // write in error log
            }
            return livemeetingslist;
        }


        public static Livemeeting GetLivemeeting(int liveMeetingId)
        {
            Livemeeting livemeetingslist = null;
            try
            {
                using (var context = new INFOMATICSMEETINGContext())
                {
                    livemeetingslist = context.Livemeeting.Where(c => c.LiveMeetingId == liveMeetingId).Single();

                }
            }
            catch (Exception ex)
            {
                // write in error log
            }
            return livemeetingslist;
        }

        public static int AddLiveMeetings(Livemeeting liveMeeting)
        {
            int liveMeetingId = 0;
            try
            {
                using (var context = new INFOMATICSMEETINGContext())
                {
                    context.Livemeeting.Add(liveMeeting);
                    context.SaveChanges();
                    liveMeetingId = liveMeeting.LiveMeetingId;                    
                }
            }
            catch(Exception ex)
            {
                // write in error log
            }
            return liveMeetingId;
        }

        public static bool UpdateLiveMeetings(Livemeeting livemeeting)
        {
            bool result = false;
            try
            {
                using (var context = new INFOMATICSMEETINGContext())
                {
                    var meetingList = context.Livemeeting.First<Livemeeting>();
                    meetingList.LiveMeetingSubject = livemeeting.LiveMeetingSubject;
                    meetingList.LiveMeetingAgenda = livemeeting.LiveMeetingAgenda;
                    meetingList.LiveMeetingAttendees = livemeeting.LiveMeetingAttendees;
                    meetingList.LiveMeetingDate = livemeeting.LiveMeetingDate;
                    meetingList.LiveMeetingStartTime = livemeeting.LiveMeetingStartTime;
                    meetingList.LiveMeetingEndTime = livemeeting.LiveMeetingEndTime;
                    meetingList.ModifedBy = livemeeting.ModifedBy;
                    meetingList.ModifiedDate = livemeeting.ModifiedDate;
                    context.SaveChanges();                    
                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public static bool DeleteLiveMeetings(Livemeeting livemeeting)
        {
            bool result = false;
            try
            {
                using (var context = new INFOMATICSMEETINGContext())
                {
                    var meetingList = context.Livemeeting.First<Livemeeting>();
                    meetingList.DeletedBy = livemeeting.DeletedBy;
                    meetingList.DeletedDate = livemeeting.DeletedDate;
                    context.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
