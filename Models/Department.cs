﻿namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department()
        {

        }

        public Department(int id, string Name)
        {

        }

        public void setId(int id)
        {
            this.Id = id;
        }

        public void setName(string name)
        {
            this.Name = name;
        }


    }
}
