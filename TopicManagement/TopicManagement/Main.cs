using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopicManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Click(btnHome);
            pnlViewNL.Visible = true;
        }

        //Bật hiệu ứng tiêu đề
        private void Click(Button b) {
            b.BackColor = Color.FromArgb(9, 77, 121);
        }

        //Tắt hiệu ứng tiêu đề
        private void lostFocus(Button b1, Button b2, Button b3, Button b4, Button b5)
        {
            b1.BackColor = Color.FromArgb(37, 130, 189);
            b2.BackColor = Color.FromArgb(37, 130, 189);
            b3.BackColor = Color.FromArgb(37, 130, 189);
            b4.BackColor = Color.FromArgb(37, 130, 189);
            b5.BackColor = Color.FromArgb(37, 130, 189);
        }

        //Bật tùy chọn
        private void showOption(Button btn1, Label lbl1, Button btn2, Label lbl2, Button btn3) {
            btn1.Visible = true; lbl1.Visible = true; btn2.Visible = true;
            lbl2.Visible = true; btn3.Visible = true;
        }

        //Tắt tùy chọn
        private void hideOption(Button btn1, Label lbl1, Button btn2, Label lbl2, Button btn3) {
            btn1.Visible = false; btn2.Visible = false; btn3.Visible = false;
            lbl1.Visible = false; lbl2.Visible = false;
        }

        private void clickHome(object sender, EventArgs e)
        {
            Click(btnHome);
            lostFocus(btnLuanVan, btnNienLuan, btnAddNew, btnDoAn, btnStatistical);
        }

        private void clickLV(object sender, EventArgs e)
        {
            Click(btnLuanVan);
            lostFocus(btnHome, btnNienLuan, btnAddNew, btnDoAn, btnStatistical);
        }

        private void LeaveLV(object sender, EventArgs e)
        {
            hideOption(btnInputLV, lblLV1, btnEditLV, lblLV2, btnViewLV);
        }

        private void clickNL(object sender, EventArgs e)
        {
            Click(btnNienLuan);
            lostFocus(btnLuanVan, btnHome, btnAddNew, btnDoAn, btnStatistical);
        }

        private void leaveNL(object sender, EventArgs e)
        {
            hideOption(btnInputNL, lblNL1, btnEditNL, lblNL2, btnViewNL);
        }

        private void clickDA(object sender, EventArgs e)
        {
            Click(btnDoAn);
            lostFocus(btnLuanVan, btnNienLuan, btnAddNew, btnHome, btnStatistical);
        }

        private void leaveDA(object sender, EventArgs e)
        {
            hideOption(btnInputDA, lblDA1, btnEditDA, lblDA2, btnViewDA);
        }

        private void clickAddNew(object sender, EventArgs e)
        {
            Click(btnAddNew);
            lostFocus(btnLuanVan, btnNienLuan, btnHome, btnDoAn, btnStatistical);
            //Hiện panel Thêm mới
            this.pnlViewTM.Size = new System.Drawing.Size(1084,500);

        }

        private void clickSta(object sender, EventArgs e)
        {
            Click(btnStatistical);
            lostFocus(btnLuanVan, btnNienLuan, btnAddNew, btnDoAn, btnHome);
        }

        private void clickForm(object sender, MouseEventArgs e)
        {
            if (((MousePosition.X < 245) || (MousePosition.X > 395)) || ((MousePosition.Y < 45) || MousePosition.Y > 227))
                hideOption(btnInputLV, lblLV1, btnEditLV, lblLV2, btnViewLV);
            if (((MousePosition.X < 395) || (MousePosition.X > 545)) || ((MousePosition.Y < 45) || MousePosition.Y > 227))
                hideOption(btnInputNL, lblNL1, btnEditNL, lblNL2, btnViewNL);
            if (((MousePosition.X < 545) || (MousePosition.X > 695)) || ((MousePosition.Y < 45) || MousePosition.Y > 227))
                hideOption(btnInputDA, lblDA1, btnEditDA, lblDA2, btnViewDA);
        }

        private void enterLV(object sender, EventArgs e)
        {
            showOption(btnInputLV, lblLV1, btnEditLV, lblLV2, btnViewLV);
            hideOption(btnInputNL, lblNL1, btnEditNL, lblNL2, btnViewNL);
            hideOption(btnInputDA, lblDA1, btnEditDA, lblDA2, btnViewDA);
        }

        private void enterNL(object sender, EventArgs e)
        {
            showOption(btnInputNL, lblNL1, btnEditNL, lblNL2, btnViewNL);
            hideOption(btnInputLV, lblLV1, btnEditLV, lblLV2, btnViewLV);
            hideOption(btnInputDA, lblDA1, btnEditDA, lblDA2, btnViewDA);
        }

        private void enterDA(object sender, EventArgs e)
        {
            showOption(btnInputDA, lblDA1, btnEditDA, lblDA2, btnViewDA);
            hideOption(btnInputLV, lblLV1, btnEditLV, lblLV2, btnViewLV);
            hideOption(btnInputNL, lblNL1, btnEditNL, lblNL2, btnViewNL);
        }

        private void enterHome(object sender, EventArgs e)
        {
            hideOption(btnInputLV, lblLV1, btnEditLV, lblLV2, btnViewLV);
            hideOption(btnInputNL, lblNL1, btnEditNL, lblNL2, btnViewNL);
            hideOption(btnInputDA, lblDA1, btnEditDA, lblDA2, btnViewDA);
        }

        private void enterAddNew(object sender, EventArgs e)
        {
            hideOption(btnInputLV, lblLV1, btnEditLV, lblLV2, btnViewLV);
            hideOption(btnInputNL, lblNL1, btnEditNL, lblNL2, btnViewNL);
            hideOption(btnInputDA, lblDA1, btnEditDA, lblDA2, btnViewDA);
        }

        private void enterSta(object sender, EventArgs e)
        {
            hideOption(btnInputLV, lblLV1, btnEditLV, lblLV2, btnViewLV);
            hideOption(btnInputNL, lblNL1, btnEditNL, lblNL2, btnViewNL);
            hideOption(btnInputDA, lblDA1, btnEditDA, lblDA2, btnViewDA);
        }

        private void enterForm(object sender, EventArgs e)
        {
            hideOption(btnInputLV, lblLV1, btnEditLV, lblLV2, btnViewLV);
            hideOption(btnInputNL, lblNL1, btnEditNL, lblNL2, btnViewNL);
            hideOption(btnInputDA, lblDA1, btnEditDA, lblDA2, btnViewDA);
        }

        private void clickLVN(object sender, EventArgs e)
        {
            hideOption(btnInputLV, lblLV1, btnEditLV, lblLV2, btnViewLV);
            Click(btnLuanVan);
            lostFocus(btnHome, btnNienLuan, btnDoAn, btnAddNew, btnStatistical);
        }

        /**
         * Set bảng chế độ read only ("Luận văn","Niên luận","Đồ án")
         **/
        private void setViewTable(String topic)
        {
            if (dgvViewTopicNL.Visible == false)
                return;
            dgvViewTopicNL.Rows.Clear();
            if (topic != "Luận văn") {
                String sql = "Select t.topicid, topicname from topic t, topicdetail d, time ti " +
                    "where t.topicid = d.topicid and d.id = ti.id and typeoftopic=N'" + topic + "' " +
                    "and semester=" + cboViewSemesterNL.Text + " and schoolyear='" + cboViewSYNL.Text + "'";
                DataTable table = Database.fillDataToTable(sql);
                for (int i = 0; i < table.Rows.Count; i++) {
                    dgvViewTopicNL.Rows.Add();
                    dgvViewTopicNL.Rows[i].Cells[0].Value = table.Select()[i].ItemArray[0].ToString().Trim();
                    dgvViewTopicNL.Rows[i].Cells[1].Value = table.Select()[i].ItemArray[1].ToString().Trim();
                }
            }
        }

        private void setTableStudent()
        {
            String sql = "Select studentid, studentname, status, mark, specialized, email from topic t, topicdetail d, student s" +
                "where t.topicid = d.topicid and s.id = d.id and t.topicid = " + dgvViewTopicNL.SelectedCells.ToString();
            DataTable table = Database.fillDataToTable(sql);
            dgvViewStudentNL.DataSource = table;
        }

        private void pnlViewNL_VisibleChanged(object sender, EventArgs e)
        {
            setViewTable("Niên luận");
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		/*################################################################################*/
        //Quản lí Luận Văn
        //Xem
        private void ViewPnlTopic(String topic)
        {
            //Mở chế độ chỉ xem,ẩn các panel còn lại,load CSDL vào các dgvView
            String sql = "Select t.topicid, topicname from topic t, topicdetail d, time ti " +
                    "where t.topicid = d.topicid and d.id = ti.id and typeoftopic=N'" + topic + "' " +
                    "and semester=" + cboViewSemesterNL.Text + " and schoolyear='" + cboViewSYNL.Text + "'";
            DataTable table = Database.fillDataToTable(sql);
            if (topic == "Luận văn")
            {
                dgvViewTopicNL.Rows.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dgvViewTopicNL.Rows.Add();
                    dgvViewTopicNL.Rows[i].Cells[0].Value = table.Select()[i].ItemArray[0].ToString().Trim();
                    dgvViewTopicNL.Rows[i].Cells[1].Value = table.Select()[i].ItemArray[1].ToString().Trim();
                }
            }
            if (topic == "Niên luận")
            {
                dgvViewTopicNL.Rows.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dgvViewTopicNL.Rows.Add();
                    dgvViewTopicNL.Rows[i].Cells[0].Value = table.Select()[i].ItemArray[0].ToString().Trim();
                    dgvViewTopicNL.Rows[i].Cells[1].Value = table.Select()[i].ItemArray[1].ToString().Trim();
                }
            }
            if (topic == "Đồ án")
            {
                dgvViewTopicNL.Rows.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dgvViewTopicNL.Rows.Add();
                    dgvViewTopicNL.Rows[i].Cells[0].Value = table.Select()[i].ItemArray[0].ToString().Trim();
                    dgvViewTopicNL.Rows[i].Cells[1].Value = table.Select()[i].ItemArray[1].ToString().Trim();
                }
            }
        }
        private void btnViewLV_Click(object sender, EventArgs e)
        {
            ViewPnlTopic("Luận văn");
        }

        private void btnViewNL_Click(object sender, EventArgs e)
        {
            ViewPnlTopic("Niên Luận");
        }

        private void btnViewDA_Click(object sender, EventArgs e)
        {
            ViewPnlTopic("Đồ án");
        }
        //Quản lí Thêm mới
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Browse đến file cần import
            OpenFileDialog ofd = new OpenFileDialog();
            //Lấy đường dẫn file import vừa chọn
            txtFilePath.Text = ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : "";
        }
        private bool ValidInput()
        {
            if (txtFilePath.Text.Trim() == "")
            {
                MessageBox.Show("Xin vui lòng chọn file từ tập tin excel cần import");
                return false;
            }
            return true;
        }

        private void btnHuyImportTM_Click(object sender, EventArgs e)
        {
            txtFilePath.Text = "";
        }
        private DataTable ReadDataFromExcelFile()
        {   //Provider=Microsoft.ACE.OLEDB.12.0
            //Provider=Microsoft.Jet.OLEDB.4.0
            String conectionExcel = "Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties=Excel 8.0 ;Data Source=" + txtFilePath.Text.Trim();
            //Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(conectionExcel);
            DataTable data = null;
            try
            {
                //Mở kết nối
                oledbConn.Open();

                //Tạo đối tượng OleDBCommand và Query data từ sheet có tên là "Sheet1"
                OleDbCommand cmd = new OleDbCommand(@"SELECT * FROM [Sheet1$]", oledbConn);

                //Tạo đối tượng OleDbDataApdapter để thực thi việc lấy query lấy dữ liệu từ tập tin excel
                OleDbDataAdapter oleda = new OleDbDataAdapter();
                oleda.SelectCommand = cmd;

                //Tạo đối tượng Dataset để ghi dữ liệu từ excel
                DataSet ds = new DataSet();

                //Đổ dữ liệu từ tập tin excel vào DataSet
                oleda.Fill(ds);

                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Đóng chuỗi kết nỗi
                oledbConn.Close();
            }
            return data;
        }
		/*private void btnImport_Click_1(object sender, EventArgs e)
        {
            if (cbTypeList.Text == "danh sách sinh viên") {
                dataGridView2.Rows.Clear();
                dataGridView2.DataSource = ReadDataFromExcelFile().DefaultView;
            }
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = ReadDataFromExcelFile().DefaultView;
            }
            
        }*/
        private void ImportIntoDatabase(DataTable data)
        {
            if (data == null || data.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để import");
                return;
            }

        }
        
<<<<<<< HEAD
		/*private void btnImport_Click_1(object sender, EventArgs e)
        {
            if (cbTypeList.Text == "danh sách sinh viên") {
                dataGridView2.Rows.Clear();
                dataGridView2.DataSource = ReadDataFromExcelFile().DefaultView;
            }
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = ReadDataFromExcelFile().DefaultView;
            }
            
        }*/
=======
>>>>>>> origin/function
    }
}
