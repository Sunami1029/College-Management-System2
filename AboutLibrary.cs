using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    partial class AboutLibrary : Form
    {
        public AboutLibrary()
        {
            InitializeComponent();
            this.Text = String.Format("SSA GFGC", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("SSA GFGC", AssemblyVersion);
            this.labelCopyright.Text = "About  College Library";
            this.labelCompanyName.Text = "Librarian-Manjunatha";
            this.textBoxDescription.Text = "The college library serves as an invaluable resource hub and an intellectual haven for students pursuing higher education. As a sanctuary of knowledge, it provides a diverse collection of books, journals, and digital resources that cater to student’s academic needs and intellectual curiosities across various disciplines. Beyond its extensive collection, the college library offers a conducive environment for research, study, and collaboration, fostering a culture of academic excellence and intellectual exploration. With its welcoming ambiance, knowledgeable staff, and state-of-the-art facilities, the college library stands as a vibrant center of learning, supporting students in their quest for knowledge and fostering a deep appreciation for the power of information.";
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void AboutLibrary_Load(object sender, EventArgs e)
        {

        }

        private void AboutLibrary_FormClosed(object sender, FormClosedEventArgs e)
        {
            SSA_MDI nm = new SSA_MDI();
            this.Hide();
            nm.Show();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SSA_MDI nm = new SSA_MDI();
            this.Hide();
            nm.Show();
        }
    }
}
