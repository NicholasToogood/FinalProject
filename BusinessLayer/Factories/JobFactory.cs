using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Factories
{
    public class JobFactory
    {
        public static List<Job> JobsCreateList()
        {
            DataTable tmpTable = SqlLayer.HRSQL.RetrieveJobs();
            List<Job> retrievedJobs = new List<Job>();
            retrievedJobs = JobsRepackager(tmpTable);
            return retrievedJobs;
        }

        private static List<Job> JobsRepackager(DataTable myTable)
        {
            List<Job> jobs = new List<Job>();
            foreach (DataRow tempRow in myTable.Rows)
            {
                Job tmpJobs = new Job();
                tmpJobs.JobID = Convert.ToInt32(tempRow["jobId"]);
                tmpJobs.JobTitle = tempRow["jobTitle"].ToString();
                tmpJobs.MaxPay = Convert.ToDouble(tempRow["maxPay"]);

                jobs.Add(tmpJobs);
            }
            return jobs;
        }
    }
}
