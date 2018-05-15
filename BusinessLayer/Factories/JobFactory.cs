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

        public static Job JobByEmpID(int empID)
        {
            DataTable tmpTable = SqlLayer.HRSQL.RetrieveJobByEmpID(empID);
            Job retrievedJobs = new Job();
            retrievedJobs = JobByEmpIDRepackager(tmpTable);
            return retrievedJobs;
        }

        private static Job JobByEmpIDRepackager(DataTable myTable)
        {
            Job jobs = new Job();
            jobs.JobID = Convert.ToInt32(myTable.Rows[0]["jobId"]);
            jobs.JobTitle = myTable.Rows[0]["jobTitle"].ToString();
            jobs.MaxPay = Convert.ToDouble(myTable.Rows[0]["maxPay"]);
            
            return jobs;
        }
    }
}
