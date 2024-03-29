﻿using Projekt_DB.Tables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_DB.DAOs
{
    public class CustomerDAO
    {
        //Method to get all customers from the database
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection conn = DatabaseSingleton.GetInstance())
            {
                string query = "SELECT * FROM Customers";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerId = Convert.ToInt32(reader["customer_id"]);
                    customer.Name = reader["name"].ToString();
                    customer.Email = reader["email"].ToString();
                    customer.PhoneNumber = reader["phone_number"].ToString();
                    customer.Address = reader["address"].ToString();

                    customers.Add(customer);
                }

                reader.Close();
            }

            return customers;
        }
        
        //Method to add a customer to the database
        public void AddCustomer(Customer customer)
        {
            using (SqlConnection conn = DatabaseSingleton.GetInstance())
            {
                string query = "INSERT INTO Customers (name, email, phone_number, address) VALUES (@name, @email, @phoneNumber, @address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", customer.Name);
                cmd.Parameters.AddWithValue("@email", customer.Email);
                cmd.Parameters.AddWithValue("@phoneNumber", customer.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Customer added successfully");
        }
       
        //Method to update a customer in the database
        public void UpdateCustomerInfo(Customer customer)
        {
            using (SqlConnection conn = DatabaseSingleton.GetInstance())
            {
                string query = "UPDATE Customers SET name = @name, email = @email, phone_number = @phoneNumber, address = @address WHERE customer_id = @customerId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", customer.Name);
                cmd.Parameters.AddWithValue("@email", customer.Email);
                cmd.Parameters.AddWithValue("@phoneNumber", customer.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.Parameters.AddWithValue("@customerId", customer.CustomerId);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Customer info updated successfully");
        }
    }
}
