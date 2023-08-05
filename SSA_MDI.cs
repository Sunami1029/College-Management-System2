using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class SSA_MDI : Form
    {
        private int childFormNumber = 0;

        public SSA_MDI()
        {
            InitializeComponent();
        }
        public SSA_MDI(String user)
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void SSA_MDI_Load(object sender, EventArgs e)
        {

        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contactInfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cinfo fm = new Cinfo("Guest");
            this.Hide();
            fm.Show();
        }

        private void removeStudentyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void elearningEContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            e_learn fm = new e_learn();
            this.Hide();
            fm.Show();

        }

        private void admissionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adddmission_Info fm = new Adddmission_Info();
            this.Hide();
            fm.Show();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Results fm = new Results();
            this.Hide();
            fm.Show();
        }

        private void collegeHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histoclg FM = new Histoclg();
            this.Hide();
            FM.Show();
        }

        private void SSA_MDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            this.Hide();
            ab.Show();
        }

        private void nonTeachingStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NOn_Teaching fm = new NOn_Teaching("258");
            this.Hide();
            fm.Show();
        }

        private void teachingStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachingStaff fm = new TeachingStaff();
            this.Hide();
            fm.Show();
        }

        private void visionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vision fm = new Vision("Admin");
            this.Hide();
            fm.Show();
        }

        private void nAACToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vision fm = new Vision("Guest");
            this.Hide();
            fm.Show();
        }

        private void codeOFConductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vision fm = new Vision("1234");
            this.Hide();
            fm.Show();

        }

        private void bestPracticesOfTheColegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vision fm = new Vision("1433");
            this.Hide();
            fm.Show();
        }

        private void galaryImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cinfo fm = new Cinfo("Admin");
            this.Hide();
            fm.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 gn = new Form2();
            this.Hide();
            gn.Show();
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Syllabus dy = new Syllabus("Guest");
            this.Hide();
            dy.Show();
        }

        private void sTATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Syllabus dy = new Syllabus("Admin");
            this.Hide();
            dy.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentR sr = new StudentR();
            this.Hide();
            sr.Show();
        }

        private void guestFacultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NOn_Teaching fm = new NOn_Teaching("123");
            this.Hide();
            fm.Show();
        }

        private void aboutLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutLibrary ab = new AboutLibrary();
            this.Hide();
            ab.Show();
        }

        private void officeStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
