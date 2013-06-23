using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RNC.Entities;
using RNC.Implementors;

namespace RNC.Reporting
{
    public partial class MemberReportViewer : Form
    {
        private List<Member> printableList;
        private string reportOrder;

        public string ReportOrder
        {
            get { return reportOrder; }
            set { reportOrder = value; }
        }

        public List<Member> PrintableList
        {
            get { return printableList; }
            set { printableList = value; }
        }

        public MemberReportViewer()
        {
            InitializeComponent();
        }

        private void MemberReportViewer_Load(object sender, EventArgs e)
        {
            if (PrintableList.Count > 0 && this.printableList != null)
            {
                this.reportViewer1.LocalReport.DataSources.Clear(); //clear report
                //Bind reportviewer to report.rdlc
                if (this.reportOrder.Equals("0"))
                {
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "RNC.Reporting.GeneralReport.rdlc";
                }
                else if (this.reportOrder.Equals("01"))
                {
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "RNC.Reporting.GeneralReport_card.rdlc";
                }
                else if (this.reportOrder.Equals("02"))
                {
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "RNC.Reporting.GeneralReport_entry.rdlc";
                }
                else if (this.reportOrder.Equals("03"))
                {
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "RNC.Reporting.GeneralReport_percent.rdlc";
                }
                else if (this.reportOrder.Equals("012"))
                {
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "RNC.Reporting.GeneralReport_card_entry.rdlc";
                }
                else if (this.reportOrder.Equals("013"))
                {
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "RNC.Reporting.GeneralReport_card_percent.rdlc";
                }
                else if (this.reportOrder.Equals("023"))
                {
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "RNC.Reporting.GeneralReport_entry_percent.rdlc";
                }
                else if (this.reportOrder.Equals("0123"))
                {
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "RNC.Reporting.GeneralReport_card_entry_percent.rdlc";
                }

                Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("memberDS", this.PrintableList); // set the datasource

                this.reportViewer1.LocalReport.DataSources.Add(dataset);

                dataset.Value = this.PrintableList;

                this.reportViewer1.LocalReport.Refresh();

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
