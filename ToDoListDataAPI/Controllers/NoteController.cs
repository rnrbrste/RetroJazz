using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security.Claims;
using System.IdentityModel.Tokens;
using System.Diagnostics;
using RetroDataAPI.Models;
using System.Configuration;
using System.Data.Linq;
using RetroJazz;

namespace RetroDataAPI.Controllers
{
    public class NoteController : ApiController
    {
        //test
        // Uncomment following lines for service principal authentication
        //private static string trustedCallerClientId = ConfigurationManager.AppSettings["todo:TrustedCallerClientId"];
        //private static string trustedCallerServicePrincipalId = ConfigurationManager.AppSettings["todo:TrustedCallerServicePrincipalId"];

        //private static Dictionary<int, ToDoItem> mockData = new Dictionary<int, ToDoItem>();

        static NoteController()
        {
            //mockData.Add(0, new ToDoItem { ID = 0, Owner = "*", Description = "feed the dog" });
            //mockData.Add(1, new ToDoItem { ID = 1, Owner = "*", Description = "take the dog on a walk" });
        }

        private static void CheckCallerId()
        {
            // Uncomment following lines for service principal authentication
            //string currentCallerClientId = ClaimsPrincipal.Current.FindFirst("appid").Value;
            //string currentCallerServicePrincipalId = ClaimsPrincipal.Current.FindFirst("http://schemas.microsoft.com/identity/claims/objectidentifier").Value;
            //if (currentCallerClientId != trustedCallerClientId || currentCallerServicePrincipalId != trustedCallerServicePrincipalId)
            //{
            //    throw new HttpResponseException(new HttpResponseMessage { StatusCode = HttpStatusCode.Unauthorized, ReasonPhrase = "The appID or service principal ID is not the expected value." });
            //}
        }

        // GET: api/Note
        public IEnumerable<Notes> Get(int owner)
        {
            CheckCallerId();
            using (var context = new RetroContext.RetroDataContext())
            {
                context.DeferredLoadingEnabled = false;
                IEnumerable<Notes> ownersnotes = from note in context.Notes
                                           where note.CreatedBy == owner
                                 select note;
                return ownersnotes.ToList();
            }
        }

        // GET: api/Note/5
        public Notes GetById(int owner, int id)
        {
            CheckCallerId();

            using (var context = new RetroContext.RetroDataContext())
            {
                var ownersnotes = from note in context.Notes
                                  where note.CreatedBy == owner
                                  && note.Id == id
                                  select note;
                return ownersnotes.First();
            }
        }

        // post: api/Note
        public void post(Notes note)
        {
            CheckCallerId();

            using (var context = new RetroContext.RetroDataContext())
            {
                context.Notes.InsertOnSubmit(note);
                try
                {
                    context.SubmitChanges();
                }
                catch (Exception)
                {
                    //log
                    context.SubmitChanges();
                }
            }
        }

        // put: api/Note
        public void Put(Notes note)
        {
            CheckCallerId();
       
            using (var context = new RetroContext.RetroDataContext())
            {
                Notes xnote = context.Notes.First(a => (a.CreatedBy == note.CreatedBy) && a.Id == note.Id);
                if(note != null && xnote != null)
                {
                    xnote.Note = note.Note;
                }
                context.SubmitChanges();
            }
        }

        // DELETE: api/Note/5
        public void Delete(int owner, int id)
        {
            CheckCallerId();

            using (var context = new RetroContext.RetroDataContext())
            {
                Notes note = context.Notes.First(a => (a.CreatedBy == owner) && a.Id == id);
                if (note != null)
                {
                    context.Notes.DeleteOnSubmit(note);
                }
                context.SubmitChanges();
            }
        }
    }
}

