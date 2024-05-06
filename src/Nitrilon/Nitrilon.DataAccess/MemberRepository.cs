using Microsoft.Data.SqlClient;

using Nitrilon.Entities;

namespace Nitrilon.DataAccess
{
    public class MemberRepository: Repository
    {
        public MemberRepository() : base()
        {

        }

        public List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();
            List<Membership> memberships = new List<Membership>();

            string membershipSql = "SELECT * FROM Memberships;";
            string memberSql = "SELECT * FROM Members;";

            SqlDataReader membershipReader = Execute(membershipSql);
            SqlDataReader memberReader = Execute(memberSql);
            
            memberships = ExtractMemberships(membershipReader);
            members = ExtractMembers(memberReader, memberships);            

            return members;
        }

        private List<Membership> ExtractMemberships(SqlDataReader reader)
        {           
            List<Membership> memberships = new List<Membership>();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string name = Convert.ToString(reader["Name"]);
                string description = Convert.ToString(reader["Description"]);
                Membership membership = new(id, name, description);
                memberships.Add(membership);
            }
            return memberships;
        }

        private List<Member> ExtractMembers(SqlDataReader reader, List<Membership> memberships)
        {
            List<Member> members = new List<Member>();
            while(reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string name = Convert.ToString(reader["Fullname"]);
                DateTime enrollmentDate = Convert.ToDateTime(reader["EnrollmentDate"].ToString());
                int membershipId = Convert.ToInt32(reader["MembershipId"]);
                Membership membershipToAdd = default;
                foreach(Membership membership in memberships)
                {
                    if(membership.Id == membershipId)
                    {
                        membershipToAdd = membership;
                        break;
                    }
                }
                Member member = new(id, name, enrollmentDate, membershipToAdd);
                members.Add(member);
            }
            return members;
        }
    }
}
