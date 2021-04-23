using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TrackTrace.Models
{
    public class Request
    {
        public long Id { get; set; }
        public string ReferenceId { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModificationDate { get; set; }
        public string Creator { get; set; }


    }
}

namespace TrackTrace
{

    /// <summary>
    /// See http://codingsonata.com/how-to-display-friendly-names-for-enumerations-in-csharp/
    /// </summary>
    public enum Status
    {
        [Description("New")]
        [EnumMember(Value = "New")]
        New,
        [Description("In progress")]
        [EnumMember(Value = "In progress")]
        In_progress,
        [Description("In review")]
        [EnumMember(Value = "In review")]
        Completed,
        Canceled,
        Planning,
        In_Review,
        [Description("Pending changes")]
        [EnumMember(Value = "Pending changes")]
        Pending_Changes,
        Approved
    }

}