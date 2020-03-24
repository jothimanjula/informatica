using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InfomaticsDataLayer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InformaticaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivemeetingController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Livemeeting>> GetLiveMeetingDetails()
        {
            List<Livemeeting> LiveMeetingList = null;
            try
            {
                using (var context = new INFOMATICSMEETINGContext())
                {
                    LiveMeetingList = InfomaticsDataLayer.DBOperations.GetLivemeetings();
                    if (LiveMeetingList == null)
                    {
                        return NotFound();
                    }                    
                }
            }
            catch(Exception ex)
            {
                // write in error log
            }
            return LiveMeetingList;
        }
        [HttpGet]
        public ActionResult <Livemeeting> GetLiveMeeting(int liveMeetingId)
        {
            Livemeeting liveMeeting = null;
            try { 
                using (var context = new INFOMATICSMEETINGContext())
                {
                    liveMeeting = InfomaticsDataLayer.DBOperations.GetLivemeeting(liveMeetingId);
                    if (liveMeeting == null)
                    {
                        return NotFound();
                    }                    
                }
            }
            catch (Exception ex)
            {
                // write in error log
            }
            return liveMeeting;
        }
        [HttpPost]
        public int AddPost(Livemeeting livemeeting)
        {
            int livemeetingId = 0;
            try
            {
                livemeetingId = InfomaticsDataLayer.DBOperations.AddLiveMeetings(livemeeting);
            }
            catch(Exception ex)
            {
                // write in error log
            }
            return livemeetingId;
        }

        [HttpPut("{id}")]
        public bool MeetingPut(Livemeeting liveMeeting)
        {
            bool isUpdated = false;
            try
            {
                isUpdated = InfomaticsDataLayer.DBOperations.UpdateLiveMeetings(liveMeeting);
            }
            catch(Exception ex)
            {
                //write in error log
            }
            return isUpdated;
        }
        
        [HttpDelete("{id}")]
        public bool Delete(Livemeeting liveMeeting)
        {
            bool isDeleted = false;
            try
            {
                isDeleted = InfomaticsDataLayer.DBOperations.UpdateLiveMeetings(liveMeeting);
            }
            catch (Exception ex)
            {
                //write in error log
            }
            return isDeleted;
        }
    }
}
