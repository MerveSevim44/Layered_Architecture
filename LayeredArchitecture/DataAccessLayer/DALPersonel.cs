using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
   public class DALPersonel
    {
        public static List<EntityPersonel> PersonelList()
        {
            List<EntityPersonel> values = new List<EntityPersonel>();
            SqlCommand cmd = new SqlCommand("select * from Info",Connection.con);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EntityPersonel person = new EntityPersonel();
                person.Name = reader["Name"].ToString();
                person.LastName = reader["Surname"].ToString();
                person.Id = int.Parse(reader["Id"].ToString());
                person.City = reader["City"].ToString();
                person.Salary = int.Parse(reader["Salary"].ToString());
                person.Task = reader["Task"].ToString();
                values.Add(person);

            }
            reader.Close();
            return values;

        }

        public static int PersonelAdd(EntityPersonel p)
        {
            SqlCommand cmd2 = new SqlCommand("insert into Info Name,Surname,City,Task,Salary values (@p1,@p2,@p3,@p4,@p5)",Connection.con);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }

            cmd2.Parameters.AddWithValue("@p1",p.Name);
            cmd2.Parameters.AddWithValue("@p2", p.LastName);
            cmd2.Parameters.AddWithValue("@p3", p.City);
            cmd2.Parameters.AddWithValue("@p4", p.Task);
            cmd2.Parameters.AddWithValue("@p5", p.Salary);
            return cmd2.ExecuteNonQuery();  
        }


        public static bool PersonelRemove(int p)
        {
            SqlCommand cmd3 = new SqlCommand("delete from Info where Id = @p1",Connection.con);

            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }

            cmd3.Parameters.AddWithValue("@p1",p);

            return cmd3.ExecuteNonQuery()>0;
        }

        public static bool UpdatePersonel(EntityPersonel p)
        {
            SqlCommand cmd4 = new SqlCommand("update Info set Name =@p1,Surname=@p2,City=@p3,Task=@p4,Salary=@p5 where Id=@p6",Connection.con);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.Parameters.AddWithValue("@p6",p.Id);
            cmd4.Parameters.AddWithValue("@p1",p.Name);
            cmd4.Parameters.AddWithValue("@p2",p.LastName);
            cmd4.Parameters.AddWithValue("@p3",p.City);
            cmd4.Parameters.AddWithValue("@p4",p.Task);
            cmd4.Parameters.AddWithValue("@p5",p.Salary);
            return cmd4.ExecuteNonQuery() > 0;

        }


    }


}

    
    
  
     
     
     





