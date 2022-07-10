using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHLibrary
{
    internal struct Vacancy
    {
        string id;
        string name;
        string salary_from;
        string salary_to;
        string employer_name;
        string address;
        string info;

        public Vacancy(dynamic jsonObj)
        {
            this.id = jsonObj.id;
            this.name = jsonObj.name;

            if (jsonObj.salary != null)
            {
                this.salary_from = (jsonObj.salary.from == null)? "No data" : jsonObj.salary_from;
                this.salary_to = (jsonObj.salary.to == null)? "No data" : jsonObj.salary_to;
            }
            else
            {
                this.salary_from = "No data";
                this.salary_to = "No data";
            }
            this.employer_name = jsonObj.employer_name;

            if (jsonObj.address != null)
                this.address = jsonObj.address.city + " " + jsonObj.address.street + " " + jsonObj.address.building;
            else
                this.address = "No data";

            if (jsonObj.address != null)
                this.info = jsonObj.description;
            else
                this.info = "No data";
            
        }

    }
}
