using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RNC.Entities;
using RNC.Implementors;

namespace RNC
{
    public partial class MailSender : Form
    {
        private List<Member> recipients;
        //private List<Member> CCRecipients;
        private MainForm parentForm;
        private MemberImpl memberImpl;

        public MailSender(MainForm mainForm)
        {
            InitializeComponent();
            this.parentForm = mainForm;
            memberImpl = new MemberImpl();
            recipients = parentForm.SelectedMembers;
            foreach (Member member in recipients) {
                this.txtReceiver.Text += member.Email + ", ";
            }

            //This code autocompletes the receiver's details...but only the first!
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            List<Member> recipientsAuto = memberImpl.getAllMembers();
            foreach (Member member in recipientsAuto)
            {
                source.Add(member.Lastname + " " + member.Firstname + ": " + member.Email);
            }
            this.txtReceiver.AutoCompleteCustomSource = source;
            this.txtReceiver.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtReceiver.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("rmedard5@gmail.com", "00Derfine")
            };
            MailMessage message = new MailMessage();
            MailAddress from = new MailAddress("rmedard5@gmail.com", "Medard Rebero", System.Text.Encoding.UTF8);
            message.From = from;
            foreach (Member member in recipients) {
                MailAddress to = new MailAddress(member.Email);
                message.To.Add(to);
            }
            // Specify the message content.
            message.Body = this.txtAreaMessage.Text;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.Subject = this.txtSubject.Text;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            client.Send(message);
            // Clean up.
            message.Dispose();
        }

        private void MailSender_Load(object sender, EventArgs e)
        {

        }

        //private void textRecipientsChanged(object sender, EventArgs e)
        //{
        //    AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        //    List<Member> recipients = memberImpl.getmembersByNamesAndEmail_like(this.txtReceiver.Text);
        //    Console.WriteLine("habonetse...:" + recipients.Count);
        //    foreach (Member member in recipients) {
        //        source.Add(member.Lastname + " " + member.Firstname + ": " + member.Email);
        //    }
        //    this.txtReceiver.AutoCompleteCustomSource = source;
        //    this.txtReceiver.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    this.txtReceiver.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //}
    }
}
