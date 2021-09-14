using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabtenam
{
    public class human
    {
        public int id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string  codemeli { get; set; }
        public byte age { get; set; }

        
        public bool exist(string value)
        {
            
            db data = new db();
            var q = from i in data.jadval where i.codemeli == value select i;
            if (q.Count() != 0)
            {
                return true;
                
                
            }
            return false;
            

        }

        public string rigster(human value)
        {
            db data = new db();
            if (value.age >= 18)
            {
                if (exist(value.codemeli) != true)
                {
                    data.jadval.Add(value);
                    data.SaveChanges();
                    return ("ثبت نام کاربر با موفقیت انجام شد");
                }
                else
                {
                    return "این کاربر از قبل وجود دارد ";

                }
            }
            return "حداقل سن برای ثبت نام 18 سال میباشد";


        }
        public List<human> search (string value)
        {
            db data = new db();
            var q = data.jadval.Where(i => i.codemeli.Contains(value) || i.name.Contains(value) || i.family.Contains(value));
            return q.ToList();

        }

    }
}
