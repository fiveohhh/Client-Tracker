using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Client_Tracker
{
    /// <summary>
    /// Information about the person using client tracker
    /// </summary>
    public class ClientTrackerUser
    {
        /// <summary>
        /// Users First Name
        /// </summary>
        public string FirstName { get;  set; }

        /// <summary>
        /// Users Last Name
        /// </summary>
        public string LastName { get;  set; }

        public ClientTrackerUser(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public ClientTrackerUser()
        {
        }

    }

    /// <summary>
    /// Everything pertaining to an individual client
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Clients First Name
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Clients Last Name
        /// </summary>
        public string LastName { get; private set; }

        /// <summary>
        /// Holds a list of all the WorkDone entries for this client
        /// </summary>
        public List<WorkEntry> AllWorkDone { get; private set; }

        /// <summary>
        /// Notes pertaining to individual client, can only access through GetNotes and AddNote
        /// </summary>
        private List<string> Notes;

        public Client(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            AllWorkDone = new List<WorkEntry>();
            Notes = new List<string>();
        }

        public Client()
        {
        }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
            set
            {
                throw new Exception("Cannot set Full Name");
            }
        }

        public void AddWorkEntry(WorkEntry workEntry, ClientTrackerUser user)
        {
            AllWorkDone.Add(workEntry);
        }

        /// <summary>
        /// Gets a list of notes for this client
        /// </summary>
        /// <returns>List of notes about this client</returns>
        public List<string> GetNotes()
        {
            return Notes;
        }

        /// <summary>
        /// Adds a note to a Client
        /// </summary>
        /// <param name="note">Note to add</param>
        public void AddNote(string note)
        {
            string noteAndTimeStamp = DateTime.Now.ToString() + note;
            Notes.Add(noteAndTimeStamp);
        }
    }

    /// <summary>
    /// Helper function
    /// Used to serialize and deserialize client info
    /// </summary>
    public class ClientData
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public List<string> Notes { get; set; }
        public List<WorkEntry> WorkDone { get; set; }
        public ClientData(string firstName, string lastName, List<string> notes, List<WorkEntry> workDone)
        {
            FirstName = firstName;
            Lastname = lastName;
            Notes = notes;
            WorkDone = workDone;
        }
        public ClientData(Client client)
        {
            FirstName = client.FirstName;
            Lastname = client.LastName;
            Notes = client.GetNotes();
            WorkDone = client.AllWorkDone;
        }
        public ClientData()
        {}
    }

    /// <summary>
    /// an entry for work done.
    /// </summary>
    [Serializable()]
    public class WorkEntry
    {
        /// <summary>
        /// User that submitted the work done
        /// </summary>
        ClientTrackerUser User { get; set; }

        /// <summary>
        /// Time work was started
        /// </summary>
        public DateTime StartTime { get;  set; }

        /// <summary>
        /// Total Time worked on this client during this WorkEntry
        /// </summary>
        [XmlIgnore]
        public TimeSpan TimeWorked { get;  set; }

        /// <summary>
        /// Used for serialization
        /// </summary>
        public string Duration
        {
            get
            {
                return TimeWorked.Duration().ToString();
            }
            set
            {
                TimeWorked = TimeSpan.Parse(value);
            }
        }

        /// <summary>
        /// Notes about what was done during this work entry
        /// </summary>
        public string Notes { get;  set; }

        /// <summary>
        /// Type of work done during this WorkEntry
        /// </summary>
        public TypesOfWork TypeOfWorkDone { get;  set; }

        public WorkEntry(DateTime startTime, TimeSpan timeWorked, string notes, ClientTrackerUser user)
            : this(startTime, timeWorked, notes, user, TypesOfWork.NOTSPECIFIED)
        {
        }

        public WorkEntry(DateTime startTime, TimeSpan timeWorked, string notes, ClientTrackerUser user, TypesOfWork typeOfWork)
        {
            User = user;
            TypeOfWorkDone = typeOfWork;
            StartTime = startTime;
            TimeWorked = timeWorked;
            Notes = notes;
        }

        public WorkEntry()
        {
        }


    }

    /// <summary>
    /// Holds data while Client is in hold area.
    /// </summary>
    public class HoldData
    {
        public Client Client { get; private set; }
        public TimeSpan ElapsedTime { get; private set; }
        public DateTime StartTime { get; private set; }
        public string Notes { get; private set; }
        public TypesOfWork WorkType { get; private set; }

        public HoldData(ClientActions ca)
        {
            Client = ca.GetClient();
            ElapsedTime = ca.GetElapsedTime();
            StartTime = ca.GetStartTime();
            Notes = ca.GetNotes();
            WorkType = ca.GetTypeOfWork();
        }
    }

    public enum TypesOfWork
    {
        NOTSPECIFIED, PHONE, IN_OFFICE, COURT
    }
}
