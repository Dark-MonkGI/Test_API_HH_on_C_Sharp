using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHLibrary
{
    public struct Vacancy
    {
        public string id { get; private set; }
        public string name { get; private set; }
        public string salary_from { get; private set; }
        public string salary_to { get; private set; }
        public string employer_name { get; private set; }
        public string address { get; private set; }
        public string info { get; private set; }

        public Vacancy(dynamic jsonObj)
        {
            this.id = jsonObj.id;
            this.name = jsonObj.name;

            if (jsonObj.salary != null)
            {
                this.salary_from = (jsonObj.salary.from == null)? " - " : jsonObj.salary.from;
                this.salary_to = (jsonObj.salary.to == null)? " - " : jsonObj.salary.to;
            }
            else
            {
                this.salary_from = " - ";
                this.salary_to = " - ";
            }
            this.employer_name = jsonObj.employer.name;

            if (jsonObj.address != null)
                this.address = jsonObj.address.city + " " + jsonObj.address.street + " " + jsonObj.address.building;
            else
                this.address = " - ";

            if (jsonObj.address != null)
                this.info = jsonObj.description;
            else
                this.info = " - ";

        }

    }
}
