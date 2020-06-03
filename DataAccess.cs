using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
namespace SQL_TEST
{
    public class DataAccess
    {
        public List<Persoane> GetPersoane(string Nume)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProiectDB")))
            {
                var output = connection.Query<Persoane>($"select * from Persoane where Nume = '{ Nume}' ").ToList();
                return output;
            }
        }

        public void InsertPerson(string nume, string prenume, string email, string telefon)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProiectDB")))
            {
                List<Persoane> persoane = new List<Persoane>();
                persoane.Add(new Persoane{ Nume = nume, Prenume = prenume, Email = email, Telefon = telefon });
                connection.Execute("dbo.PNInsert @Nume, @Prenume, @Email, @Telefon", persoane);
            }
        }

        public void InsertAdress(string strada, string numar)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProiectDB")))
            {
                List<Adreseclass> adrese = new List<Adreseclass>();
                adrese.Add(new Adreseclass { Strada = strada, Numar = numar });
                connection.Execute("dbo.ADInsert @Strada, @Numar", adrese);
            }
        }

        public void InsertVehicle(string brand, string model, string an, string numar)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProiectDB")))
            {
                List<Vehiculeclass> vehicule = new List<Vehiculeclass>();
                vehicule.Add(new Vehiculeclass { Brand = brand, Model = model, An = an, Numar = numar });
                connection.Execute("dbo.VHInsert @Brand, @Model, @An, @Numar", vehicule);
            }
        }

        public List<Adreseclass> GetAdrese(string Strada)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProiectDB")))
            {
                var output = connection.Query<Adreseclass>($"select * from Adrese where Strada = '{ Strada}' ").ToList();
                return output;
            }
        }


        public List<Vehiculeclass> GetVehicule(string Brand)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProiectDB")))
            {
                var output = connection.Query<Vehiculeclass>($"select * from Vehicule where Brand = '{Brand}' ").ToList();
                return output;
            }

        }

    }
}
