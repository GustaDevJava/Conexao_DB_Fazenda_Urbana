using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Status
    {
        protected int id;
        protected string status;


        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }



        public string Statuss
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}
