using ProjectNhom.Class;
using System;
using System.Collections.Generic;

namespace ProjectNhom.DAO
{
    public class ManagerEmployees : IManagerDAO
    {


        ADOSql sql;

        public ManagerEmployees()
        {
            // tao Object
            sql = new ADOSql();

            //ket noi 
            sql.connect();
        }

        #region IManagerDAO Members


        public List<Object> getAll()
        {
            System.Windows.Forms.MessageBox.Show("");
            List<Object> list = new List<Object>();

            //thuc thi query
            sql.executeQuery("SELECT * FROM Employess");

            // lay gia tri tra ve
            while (sql.result().Read())
            {
                Employees emp = new Employees();
                emp.setLastName(sql.result()[1].ToString());
                emp.setFirstName(sql.result()[2].ToString());
                emp.setTitle(sql.result()[3].ToString());
                emp.setTitleOfCourtesy(sql.result()[4].ToString());
                emp.setBirthday(sql.result()[5].ToString());
                emp.setHiredate(sql.result()[6].ToString());
                emp.setAddress(sql.result()[7].ToString());
                emp.setCity(sql.result()[8].ToString());
                emp.setRegion(sql.result()[9].ToString());
                emp.setPostcode(sql.result()[10].ToString());
                emp.setCountry(sql.result()[11].ToString());
                emp.setPhone(sql.result()[12].ToString());

                list.Add(emp);

            }

            sql.closeDataReader();

            return list;
        }

        public List<Object> search(int id)
        {
            List<Object> list=new List<Object>();
            sql.executeQuery("SELECT * FROM [TSQLFundamentals2008].[HR].[Employees] WHERE [empid]=" + id);

            while (sql.result().Read())
            {
                Employees emp = new Employees();
                emp.setId(int.Parse(sql.result()[0].ToString()));
                emp.setLastName(sql.result()[1].ToString());
                emp.setFirstName(sql.result()[2].ToString());
                emp.setTitle(sql.result()[3].ToString());
                emp.setTitleOfCourtesy(sql.result()[4].ToString());
                emp.setBirthday(sql.result()[5].ToString());
                emp.setHiredate(sql.result()[6].ToString());
                emp.setAddress(sql.result()[7].ToString());
                emp.setCity(sql.result()[8].ToString());
                emp.setRegion(sql.result()[9].ToString());
                emp.setPostcode(sql.result()[10].ToString());
                emp.setCountry(sql.result()[11].ToString());
                emp.setPhone(sql.result()[12].ToString());
                list.Add(emp);
            }
            sql.closeDataReader();

            return list;
        }

        public List<Object> search(string title)
        {
            sql.executeQuery("SELECT * FROM [TSQLFundamentals2008].[HR].[Employees] WHERE [title]='" + title+"'");

            
            List<Object> list = new List<Object>();
            while (sql.result().Read())
            {
                Employees emp = new Employees();
                emp.setId(int.Parse(sql.result()[0].ToString()));
                emp.setLastName(sql.result()[1].ToString());
                emp.setFirstName(sql.result()[2].ToString());
                emp.setTitle(sql.result()[3].ToString());
                emp.setTitleOfCourtesy(sql.result()[4].ToString());
                emp.setBirthday(sql.result()[5].ToString());
                emp.setHiredate(sql.result()[6].ToString());
                emp.setAddress(sql.result()[7].ToString());
                emp.setCity(sql.result()[8].ToString());
                emp.setRegion(sql.result()[9].ToString());
                emp.setPostcode(sql.result()[10].ToString());
                emp.setCountry(sql.result()[11].ToString());
                emp.setPhone(sql.result()[12].ToString());
                list.Add(emp);
            }
            sql.closeDataReader();

            return list;
        }

        public bool add(Object obj)
        {
            string sSql = @"INSERT INTO [TSQLFundamentals2008].[HR].[Employees]
           ([lastname]
           ,[firstname]
           ,[title]
           ,[titleofcourtesy]
           ,[birthdate]
           ,[hiredate]
           ,[address]
           ,[city]
           ,[region]
           ,[postalcode]
           ,[country]
           ,[phone])
     VALUES
           ('" + ((Employees)obj).getLastName() +
                  "','" + ((Employees)obj).getFirstName() +
                  "','"+((Employees)obj).getTitle()+
                  "','"+((Employees)obj).getTitleOfCourtesy()+
                  "','"+((Employees)obj).getBirthday()+
                  "','"+((Employees)obj).getHiredate()+
                  "','"+((Employees)obj).getAddress()+
                  "','"+((Employees)obj).getCity()+
                  "','"+((Employees)obj).getRegion()+
                  "','"+((Employees)obj).getPostcode()+
                  "','"+((Employees)obj).getCountry()+
                  "','"+((Employees)obj).getPhone()+"')";
            sql.executeNonQuery(sSql);
            sql.closeDataReader();

            return true;
        }

        public Object get(int id)
        {
            sql.executeQuery("SELECT * FROM [TSQLFundamentals2008].[HR].[Employees] WHERE [empid]=" + id);

            Employees emp = new Employees();

            sql.result().Read();

            emp.setLastName(sql.result()[1].ToString());
            emp.setFirstName(sql.result()[2].ToString());
            emp.setTitle(sql.result()[3].ToString());
            emp.setTitleOfCourtesy(sql.result()[4].ToString());
            emp.setBirthday(sql.result()[5].ToString());
            emp.setHiredate(sql.result()[6].ToString());
            emp.setAddress(sql.result()[7].ToString());
            emp.setCity(sql.result()[8].ToString());
            emp.setRegion(sql.result()[9].ToString());
            emp.setPostcode(sql.result()[10].ToString());
            emp.setCountry(sql.result()[11].ToString());
            emp.setPhone(sql.result()[12].ToString());


            sql.closeDataReader();
            return null;
        }

        public bool update(Object obj)
        {
            sql.executeNonQuery(@"UPDATE [TSQLFundamentals2008].[HR].[Employees]
               SET [lastname] = '" + ((Employees)obj).getLastName() +
                  "',[firstname] = '" + ((Employees)obj).getFirstName() +
                  "',[title] = '"+((Employees)obj).getTitle()+
                  "',[titleofcourtesy] = '"+((Employees)obj).getTitleOfCourtesy()+
                  "',[birthdate] = '"+((Employees)obj).getBirthday()+
                  "',[hiredate] = '"+((Employees)obj).getHiredate()+
                  "',[address] = '"+((Employees)obj).getAddress()+
                  "',[city] = '"+((Employees)obj).getCity()+
                  "',[region] = '"+((Employees)obj).getRegion()+
                  "',[postalcode] = '"+((Employees)obj).getPostcode()+
                  "',[country] = '"+((Employees)obj).getCountry()+
                  "',[phone] = '"+((Employees)obj).getPhone()+
              "' WHERE [empid]=" + ((Employees)obj).getEmpid());



            return true;
        }

        public bool delete(int id)
        {
            sql.executeNonQuery(@"DELETE FROM [TSQLFundamentals2008].[HR].[Employees] 
                WHERE [empid]=" + id);
            return true;
        }

        #endregion

    }
}
