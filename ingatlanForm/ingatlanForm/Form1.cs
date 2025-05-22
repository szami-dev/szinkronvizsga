using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace ingatlanForm
{
    public partial class Ingatlanok : Form
    {
        static List<Seller> sellers = new List<Seller>();
        static List<Seller> activeSellers = new List<Seller>();
        static MySqlConnection kapcsolat;

        public Ingatlanok()
        {
            InitializeComponent();
            var builde = new MySqlConnectionStringBuilder { Server = "127.0.0.1", UserID = "root", Password="", Database="ingatlan"};
            kapcsolat = new MySqlConnection(builde.ConnectionString);
            kapcsolat.Open();
            sellers = fullRead();

            listBoxSellers.Items.Clear();
            foreach(Seller seller in sellers)
            {
                listBoxSellers.Items.Add(seller.Name);  
            }


        }   

        private void Ingatlanok_Load(object sender, EventArgs e)
        {
            btnSellers.BackColor = Color.LimeGreen;
            btnHirdetesek.Enabled = false;
        }
        static List<Seller> aktivRead()
        {
            List<Seller> a = new List<Seller>();
            var command = kapcsolat.CreateCommand();
            command.CommandText = "select * from sellers where id in (select sellerid from realestates) order by name";
            var reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                Seller tmp = new Seller();
                tmp.Id = reader.GetInt32("id");
                tmp.Name = reader.GetString("name");
                tmp.Phone = reader.GetString("phone");
                a.Add(tmp);
            }
            reader.Close();
            return a;

        }
        static List<Seller> fullRead()
        {
            List<Seller> a = new List<Seller>();
            var command = kapcsolat.CreateCommand();
            command.CommandText = "select * from sellers order by name";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Seller tmp = new Seller();
                tmp.Id = reader.GetInt32("id");
                tmp.Name = reader.GetString("name");
                tmp.Phone = reader.GetString("phone");
                a.Add(tmp);
            }
            reader.Close();
            return a;

        }


        class Ad
        {
            public int Area;
            public int Floors;
            public int Id;
            public int Rooms;
            public Category Category;
            public DateTime CreateAt;
            public string Description;
            public string ImageUrl;
            public string Latlong;
            public bool FreeOfCharge;
            public Seller Seller;
        }
        class Seller
        {
            public int Id { get; set; }
            public string Name;
            public string Phone;
        }
        class Category
        {
            public int Id;
            public string Name;
        }

        private void listBoxSellers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSellerName.Text = $"Az eladó neve {sellers[listBoxSellers.SelectedIndex].Name}";
            lblSellerPhone.Text = $"Az eladó neve {sellers[listBoxSellers.SelectedIndex].Phone}";
            btnHirdetesek.Enabled = true ;
        }

        private void btnHirdetesek_Click(object sender, EventArgs e)
        {





            var command = kapcsolat.CreateCommand();
            command.CommandText = $"select count(id) from realestates where sellerid = {sellers[listBoxSellers.SelectedIndex].Id}";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblCpunt.Text = $"Hirdetések száma: {reader.GetInt32(0)}";
            }
            reader.Close();


            var command2 = kapcsolat.CreateCommand();
            command2.CommandText = $"select * from realestates where sellerid = {sellers[listBoxSellers.SelectedIndex].Id}";
            var reader2 = command2.ExecuteReader();
            listBoxCordinates.Items.Clear();
            while (reader2.Read())
            {
              
                listBoxCordinates.Items.Add($"Hirdetés száma: {reader2.GetInt64("id")}");
                listBoxCordinates.Items.Add($"Szobák száma: {reader2.GetInt64("rooms")}");
                listBoxCordinates.Items.Add($"Terület: {reader2.GetInt64("area")}");
                listBoxCordinates.Items.Add($"Terület: {reader2.GetString("latlong")}");
                listBoxCordinates.Items.Add("");
                
            }
            reader.Close();













        }
        private void btnSellers_Click(object sender, EventArgs e)
        {
            if (btnSellers.BackColor == Color.Red)
            {
                btnSellers.BackColor = Color.LimeGreen;
                btnSellers.Text = "Aktív ügynökök";
                sellers = fullRead();
                listBoxSellers.Items.Clear();
                foreach (Seller seller in sellers)
                {
                    listBoxSellers.Items.Add(seller.Name);
                }
            }
            else
            {
                btnSellers.BackColor = Color.Red;
                btnSellers.Text = "Összes ügynök";
                sellers = aktivRead();
                listBoxSellers.Items.Clear();
                foreach (Seller seller in sellers)
                {
                    listBoxSellers.Items.Add(seller.Name);
                }
            }
        }
    }
}
