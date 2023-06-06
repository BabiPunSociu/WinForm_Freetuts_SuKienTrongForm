using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoBan_SuKienTrongForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đưa ra thông báo, nếu không muốn mở form thì KHÔNG MỞ
            if(MessageBox.Show("Bạn có muốn mở chương trình","Hỏi người dùng",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                Dispose();  // Loại bỏ --- Giải phóng bộ nhớ vì một số dữ liệu CLR không GC được
            }    
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn phải nhập họ tên");
                txtHoTen.Focus();
                return;
            }

            MessageBox.Show("Haluuuuuu " + txtHoTen.Text);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Nhấn tổ hợp Alt + H đưa ra thông báo "Haluuuu Thu Hien Vu"

            // Lưu ý cần bật KeyPreview = true trước khi chạy form để nhập được bàn phím vào form
            if(e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
            {
                MessageBox.Show("Haluuuuu Thu Hien Vu");
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Chọn yes -> Thoát
                this.Close();           // Đóng form hiện tại
                Application.Exit();     // Dừng chương trình
            }    
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MessageBox.Show("Bạn vừa click chuột trái");
            if(e.Button == MouseButtons.Right)
                MessageBox.Show("Bạn vừa click chuột phải");
            if(e.Button == MouseButtons.Middle)
                MessageBox.Show("Bạn vừa click chuột giữa");
        }
    }
}
