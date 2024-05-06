using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nitrilon.Entities
{
    public class Member
    {
        private int id;
        private string name;
        private DateTime enrollmentDate;
        private Membership membership;

        public Member(int id, string name, DateTime enrollmentDate, Membership membership)
        {
            Id = id;
            Name = name;
            EnrollmentDate = enrollmentDate;
            Membership = membership;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime EnrollmentDate { get => enrollmentDate; set => enrollmentDate = value; }
        public Membership Membership { get => membership; set => membership = value; }
    }
}
