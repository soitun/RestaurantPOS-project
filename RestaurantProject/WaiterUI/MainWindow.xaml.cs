﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WaiterUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

         

        public MainWindow()
        {



        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:mihoaka.database.windows.net,1433;Initial Catalog=Restaurant;Persist Security Info=False;User ID=sqladmin;Password=Mihoaka0215;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


            Int32 verify;
            string query1 = "Select * from Employee where id='" + txtId.Text + "' and Password='" + txtPass.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            con.Open();
            verify = Convert.ToInt32(cmd1.ExecuteScalar());
            con.Close();
            if (verify > 0)
            {
                MainMenu menuWin = new MainMenu();
                menuWin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect pasword or Id");
            }

        }
    }

    }
    
        
                




                
       
        