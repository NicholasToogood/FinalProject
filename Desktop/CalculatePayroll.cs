using BusinessLayer;
using BusinessLayer.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Mail;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI;

namespace Desktop
{
    public partial class CalculatePayroll : Form
    {
        public CalculatePayroll()
        {
            InitializeComponent();
        }

        private void CalculatePayroll_Load(object sender, EventArgs e)
        {
            sendPayrollEmails();
            loadDataGrid();
        }
        private void loadDataGrid()
        {
            List <PayStub> payStubs = PaystubFactory.RetrievePayStubsToday();

            dataGridViewPayStubs.DataSource = payStubs;
        }

        private void sendPayrollEmails()
        {
            try
            {
                var date = DateTime.Now.ToShortDateString();

                List<Employee> employees = EmployeeFactory.RetrieveEmployeesByEmailNotification();
                foreach(Employee emp in employees)
                {
                    String empPayStub = createPayStub(emp);

                    
                    StringReader sr = new StringReader(empPayStub);

                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);
                        pdfDoc.Open();
                        htmlparser.Parse(sr);
                        pdfDoc.Close();
                        byte[] bytes = memoryStream.ToArray();
                        memoryStream.Close();

                        MailMessage message = new MailMessage();
                        message.To.Add(emp.EmailAddress);
                        message.From = new MailAddress("payroll@newroads.com");
                        message.Subject = "Pay Stub for " + date;
                        message.IsBodyHtml = true;
                        message.Body = "<h3>Please find attached PayStub.</h3>";
                        message.Attachments.Add(new Attachment(new MemoryStream(bytes), "iTextSharpPDF.pdf"));
                        SmtpClient smtpClient = new SmtpClient("localhost");
                        smtpClient.Send(message);
                    }
                    
                    //MailMessage mm = new MailMessage("payroll@newroads.com", emp.EmailAddress);
                    //mm.Subject = "Pay Stub for " + date;
                    //mm.IsBodyHtml = true;
                    //mm.Body = "<h3>Please find attached PayStub.</h3>";
                    //mm.Attachments.Add(new Attachment(new MemoryStream(bytes), "iTextSharpPDF.pdf"));
                    //mm.IsBodyHtml = true;
                    //SmtpClient smtp = new SmtpClient("local");
                    //smtp.Host = "smtp.gmail.com";
                    //smtp.EnableSsl = true;
                    //NetworkCredential NetworkCred = new NetworkCredential();
                    //NetworkCred.UserName = "sender@gmail.com";
                    //NetworkCred.Password = "<password>";
                    //smtp.UseDefaultCredentials = true;
                    //smtp.Credentials = NetworkCred;
                    //smtp.Port = 587;
                    //smtp.Send(mm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string createPayStub(Employee emp)
        {
            PayStub payStub = PaystubFactory.RetrievePayStubByID(emp.EmpID);

            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                {
                    StringBuilder sb = new StringBuilder();
                    //HEADER
                    sb.Append("<table width='100%' cellspacing='0' cellpadding='2'>");
                    sb.Append("<tr><td align='center' style='background-color: #18B5F0' colspan = '2'><b>Paystub</b></td></tr>");
                    sb.Append("<tr><td colspan = '2'></td></tr>");
                    sb.Append("<tr><td><b>Employee ID: </b>");
                    sb.Append(payStub.EmpID);
                    sb.Append("</td><td><b>Date: </b>");
                    sb.Append(payStub.CreationDate);
                    sb.Append(" </td></tr>");
                    sb.Append("<tr><td colspan = '2'><b>Employee Name : </b>");
                    sb.Append(emp.FirstName + ' ' + emp.LastName);
                    sb.Append("</td></tr>");
                    sb.Append("</table>");

                    sb.Append("<br />");

                    sb.Append("<table border = '1'>");
                    sb.Append("<tr>");
                    //COLUMN HEADERS
                        sb.Append("<th>Employee ID</th>");
                        sb.Append("<th>Bi-Weekly Rate</th>");
                        sb.Append("<th>Gross Pay</th>");

                        sb.Append("<th>");
                        sb.Append("Deductions");
                        sb.Append("</th>");

                        sb.Append("<th>");
                        sb.Append("CPP");
                        sb.Append("</th>");

                        sb.Append("<th>");
                        sb.Append("EI");
                        sb.Append("</th>");

                        sb.Append("<th>");
                        sb.Append("Company Pension Deductions");
                        sb.Append("</th>");
                    sb.Append("</tr>");

                    //BODY
                    sb.Append("<tr>");

                        sb.Append("<td>");
                        sb.Append(payStub.EmpID);
                        sb.Append("</td>");

                        sb.Append("<td>");
                        sb.Append(emp.BiWeeklyRate);
                        sb.Append("</td>");

                        sb.Append("<td>");
                        sb.Append(payStub.GrossPay);
                        sb.Append("</td>");

                        sb.Append("<td>");
                        sb.Append(payStub.Deductions);
                        sb.Append("</td>");

                        sb.Append("<td>");
                        sb.Append(payStub.CPP);
                        sb.Append("</td>");

                        sb.Append("<td>");
                        sb.Append(payStub.EI);
                        sb.Append("</td>");

                        sb.Append("<td>");
                        sb.Append(payStub.CompanyPensionDeduction);
                        sb.Append("</td>");

                    sb.Append("</tr>");
                    sb.Append("</table>");

                    sb.Append("<br />");

                    // YTD
                    sb.Append("<table border = '1'>");
                    sb.Append("<tr>");

                        sb.Append("<th>");
                        sb.Append("YTD Gross Pay");
                        sb.Append("</th>");

                        sb.Append("<th>");
                        sb.Append("YTD Deductions");
                        sb.Append("</th>");

                        sb.Append("<th>");
                        sb.Append("YTD CPP");
                        sb.Append("</th>");

                        sb.Append("<th>");
                        sb.Append("YTD EI");
                        sb.Append("</th>");

                        sb.Append("<th>");
                        sb.Append("YTD Company Pension Deductions");
                        sb.Append("</th>");
                    sb.Append("</tr>");

                    //BODY
                    sb.Append("<tr>");
                        sb.Append("<td>");
                        sb.Append(payStub.YTDGrossPay.ToString());
                        sb.Append("</td>");

                        sb.Append("<td>");
                        sb.Append(payStub.YTDDeductions.ToString());
                        sb.Append("</td>");

                        sb.Append("<td>");
                        sb.Append(payStub.YTDCPP.ToString());
                        sb.Append("</td>");

                        sb.Append("<td>");
                        sb.Append(payStub.YTDEI.ToString());
                        sb.Append("</td>");

                        sb.Append("<td>");
                        sb.Append(payStub.YTDCompanyPensionDeduction.ToString());
                        sb.Append("</td>");

                    sb.Append("</tr>");
                    sb.Append("</table>");

                    return sb.ToString();
                }
            }
            
        }
        
    }
}
