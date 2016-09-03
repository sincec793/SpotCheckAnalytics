using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotCheckAnalytics
{
    class SpotCheck
    {
        public DateTime date;
        string score;
        public void setDate(string d)
        {
            if (d.Contains("/"))
            {
                date = Convert.ToDateTime(d);
            }else
            {
                date = DateTime.FromOADate(Convert.ToInt64(d));
            }
           
        }
        public DateTime getDate()
        {
            return date;
        }
        public void setScore(string s)
        {
            score = s;
        }
        public string getScore()
        {
            return score;
        }
    }
}
