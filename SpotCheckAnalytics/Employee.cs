using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotCheckAnalytics
{
    class Employee 
    {
        string name = "";
        int exceeds = 0;
        int rectifys = 0;
        int fails = 0;
        int streak = 0;
        int totalChecks = 0;
        List<SpotCheck> empChecks = new List<SpotCheck>();
      
        public void addCheck(SpotCheck check)
        {
            empChecks.Add(check);
        }
        public List<SpotCheck> getChecks()
        {
            return empChecks;
        }
        public void sortChecks()
        {
            empChecks = (List<SpotCheck>)empChecks.OrderBy(o => o.date).ToList() ;
        }
        public int calcStreak()
        {
            streak = 0;
            for(int i = empChecks.Count - 1; i >=0; i--)
            {
                if (empChecks[i].getScore().Equals("Exceeds"))
                {
                    streak++;
                }else
                {
                    break;
                }
            }
            return streak;
        }
        public void setTotalChecks()
        {
            totalChecks = exceeds + rectifys + fails;
        }
        public int getTotalChecks()
        {
            return totalChecks;
        }
        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }
        public void setExceeds(int e)
        {
            exceeds = e;
        }
        public int getExceeds()
        {
            return exceeds;
        }
        public void setRectify(int e)
        {
            rectifys = e;
        }
        public int getRectifys()
        {
            return rectifys;
        }
        public void setFails(int e)
        {
            fails = e;
        }
        public int getFails()
        {
            return fails;
        }
    }
}
