using MyAlbumView.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAlbumView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "MyAlbum Manager";
            DataLoadInForSelect();
            LoadDataInComboBox();
            LoadCategoryNameInTreeView();
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.DragDrop += FlowLayoutPanel2_DragDrop;
            this.flowLayoutPanel2.DragEnter += FlowLayoutPanel2_DragEnter;
            this.SizeChanged += Form1_SizeChanged;
        }
        #region 不重要的功能
        private void Form1_SizeChanged(object sender, EventArgs e) //label Center
        {
            this.label2.Left = ((this.ClientSize.Width - label2.Size.Width) / 2);
        }
        #endregion

        #region MouseDropDropPictureAndEnterLeaveEvent/DeleteEvent
        private void FlowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        PictureBox pbx = null;
        Size pbxsize = new Size(200, 100);
        int PhotoID;
        private void FlowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);

            for (int i = 0; i < filenames.Length; i++)
            {
                pbx = new PictureBox(); //add
                pbx.Image = Image.FromFile(filenames[i]);
                pbx.SizeMode = PictureBoxSizeMode.StretchImage;
                pbx.Padding = new Padding(3);
                pbx.BackColor = Color.White;
                pbx.Size = pbxsize;
                pbx.ContextMenuStrip = contextMenuStrip1;
                pbx.MouseClick += Pbx_MouseClick;
                //pbx.MouseEnter += Pb_MouseEnter;
                //pbx.MouseLeave += Pb_MouseLeave;
                this.flowLayoutPanel2.Controls.Add(pbx);
            }
            this.label7.Visible = true;
            this.label7.Text = "左鍵點選您剛加入的圖片並按右鍵刪除";
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pbx.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] bytes = ms.GetBuffer();
                        string PhotoModifyDate = DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss");
                        PhotoModifyDate = DateTime.Now.ToShortTimeString();
                        command.CommandText = ("Insert into Photos (CategoryID,PhotoName,Picture,Description,CategoryName) output inserted.PhotoID values  (@CategoryID,@Photoname,@Picture,@Description,@CategoryName)");
                        command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = this.label4.Text;
                        command.Parameters.Add("@Photoname", SqlDbType.NVarChar, 50).Value = "";
                        command.Parameters.Add("@Picture", SqlDbType.VarBinary).Value = bytes;
                        command.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = "";
                        command.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 50).Value = this.label3.Text;
                        command.Parameters.Add("@Modifydate", SqlDbType.NVarChar, 50).Value = PhotoModifyDate;
                        command.Connection = conn;
                        conn.Open();
                        SqlDataReader dataReader = command.ExecuteReader();
                        dataReader.Read();
                        PhotoID = int.Parse(dataReader[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }
        int pbxclick = 2;
        private void Pbx_MouseClick(object sender, MouseEventArgs e)//MayHaveBug
        {
            if (pbxclick % 2 == 0)
            {
                int pdPictureIndexForDelete = this.flowLayoutPanel2.Controls.GetChildIndex((PictureBox)sender);
                ((PictureBox)sender).BackColor = Color.Yellow;
                ((PictureBox)sender).Padding = new Padding(8);

                this.deleteToolStripMenuItem.Click += delegate (object nouse, EventArgs nouse2)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                        {
                            conn.Open();
                            using (SqlCommand command = new SqlCommand("DELETE FROM Photos where photoID='" + PhotoID + "'", conn))
                            {
                                command.ExecuteNonQuery();
                            }
                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    foreach (Control x in this.flowLayoutPanel2.Controls)
                    {
                        if (((PictureBox)x).BackColor == Color.Yellow)
                        {
                            this.flowLayoutPanel2.Controls.Remove(x);
                        }
                    }
                    this.label7.Visible = false;
                };
                pbxclick += 1;
            }
            else
            {
                ((PictureBox)sender).BackColor = Color.White;
                ((PictureBox)sender).Padding = new Padding(3);
                pbxclick += 1;
            }
        }
    
        private void InsertpbToDB()//單一照片insert用
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        PictureBox pb = new PictureBox();
                        pb.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] bytes = ms.GetBuffer();
                        string PhotoModifyDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        PhotoModifyDate = DateTime.Now.ToShortTimeString();
                        command.CommandText = ("Insert into Photos (CategoryID,PhotoName,Picture,Description,CategoryName) values (@CategoryID,@Photoname,@Picture,@Description,@CategoryName)");
                        command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = this.label4.Text;
                        command.Parameters.Add("@Photoname", SqlDbType.NVarChar, 50).Value = "";
                        command.Parameters.Add("@Picture", SqlDbType.VarBinary).Value = bytes;
                        command.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = "";
                        command.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 50).Value = this.label3.Text;
                        command.Parameters.Add("@Modifydate", SqlDbType.NVarChar, 50).Value = PhotoModifyDate;
                        command.Connection = conn;
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pb_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.White;
        }

        private void Pb_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Red;
        }

        #endregion

        #region 將類別丟進TreeView
        private void LoadCategoryNameInTreeView()
        {
            DataView CategoryView = this.myAlbumManagementDataSet1.PhotoCategory.DefaultView;
            DataTable CategoryTable = CategoryView.ToTable(true, "CategoryName");
            for (int i = 0; i <= CategoryTable.Rows.Count - 1; i++)
            {
                this.treeView1.Nodes.Add(CategoryTable.Rows[i]["CategoryName"].ToString());
            }
        }
        #endregion

        #region 將類別丟進ComboBox
        private void LoadDataInComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("select distinct CategoryName  from PhotoCategory ", conn))
                    {
                        conn.Open();
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            this.comboBox1.Items.Clear();
                            while (dataReader.Read())
                            {
                                this.comboBox1.Items.Add(dataReader["CategoryName"]);
                            }
                            this.comboBox1.SelectedIndex = 0;
                        }
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        DataTable photoCategoryTable = null;
        DataTable PhotosTable = null;
        private void DataLoadInForSelect()
        {
            this.photosTableAdapter1.Fill(this.myAlbumManagementDataSet1.Photos);
            this.photoCategoryTableAdapter1.Fill(this.myAlbumManagementDataSet1.PhotoCategory);
            photoCategoryTable = this.myAlbumManagementDataSet1.PhotoCategory;
            PhotosTable = this.myAlbumManagementDataSet1.Photos;
        }
        #region 當comboBox被選擇時
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            Size size = new Size(150, 100);
            this.label3.Text = this.comboBox1.Text; //cuz combox.select.text not work
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandText = "Select p.picture from photos  as p  join PhotoCategory as pc on p.categoryID = pc.categoryID  where pc.CategoryName='" + this.label3.Text + "'";
                        sqlCommand.Connection = conn;
                        conn.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                byte[] bytes = ((byte[])dataReader["Picture"]);
                                PictureBox pb = new PictureBox();
                                MemoryStream ms = new MemoryStream(bytes);
                                pb = new PictureBox();
                                pb.BackColor = Color.White;
                                pb.Padding = new Padding(3);
                                pb.Size = size;
                                pb.MouseEnter += Pb_MouseEnter;
                                pb.MouseLeave += Pb_MouseLeave;
                                pb.Image = Image.FromStream(ms);
                                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                                this.flowLayoutPanel2.Controls.Add(pb);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandText = "Select CategoryID from photoCategory  where CategoryName='" + this.comboBox1.Text + "'";
                        sqlCommand.Connection = conn;
                        conn.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                this.label4.Text = (dataReader[0].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Disconnect確認修改後入DB(類別)
        private void photoCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoCategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumManagementDataSet1);
        }
        #endregion

        #region 當使用FolderBrowers時 (含圖片判斷條件與此專案共用/尚未加入刪除功能)
        string[] filenames;
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filenames = Directory.GetFiles(this.folderBrowserDialog1.SelectedPath);
                for (int i = 1; i < filenames.Length; i++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromFile(filenames[i]);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Padding = new Padding(3);
                    pb.BackColor = Color.White;
                    this.flowLayoutPanel2.Controls.Add(pb);
                    if (checkFileIsImage(filenames[index]))
                    {
                        pb.Image = Image.FromFile(filenames[index]);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;                                                               
                        index += 1;
                        InsertpbToDB();
                    }
                }
            }
        }

        public bool checkFileIsImage(string _file)
        {
            bool isImage = false;
            string str = Path.GetExtension(_file);
            if (str == ".jpg" | str == ".png" | str == ".bmp")
            {
                isImage = true;
            }
            return isImage;
        }
        #endregion

        #region Disconnect確認修改後入DB(圖片)
        private void button2_Click(object sender, EventArgs e) //確認修改
        {
            this.Validate();
            this.photosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumManagementDataSet1);
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.picturePictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        #region  當TreeView被選擇時
        PictureBox TreeViewPicBox = null;
        Size size = new Size(200, 100);
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandText = "Select picture from photos  where CategoryName='" + treeView1.SelectedNode.Text + "'";//todo
                        sqlCommand.Connection = conn;
                        conn.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                byte[] bytes = ((byte[])dataReader["picture"]);
                                MemoryStream ms = new MemoryStream(bytes);
                                TreeViewPicBox = new PictureBox();
                                TreeViewPicBox.Image = Image.FromStream(ms);
                                TreeViewPicBox.Size = size;
                                TreeViewPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                TreeViewPicBox.Click += TreeViewPicBox_Click;
                                TreeViewPicBox.Padding = new Padding(3);
                                TreeViewPicBox.BackColor = Color.White;
                                TreeViewPicBox.MouseEnter+= Pb_MouseEnter;
                                TreeViewPicBox.MouseLeave+= Pb_MouseLeave;
                                this.flowLayoutPanel1.Controls.Add(TreeViewPicBox);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region FormDetail Previouspage/NextPage
        int pdPictureIndex; //正在點到的圖片索引
        PhotoDetail pd;
        private void TreeViewPicBox_Click(object sender, EventArgs e) //Nextpage/Previouspage
        {
            pd = new PhotoDetail();
            pd.Show();
            pd.pictureBox1.Image = ((PictureBox)sender).Image;
            int pdPictureIndex = this.flowLayoutPanel1.Controls.GetChildIndex((PictureBox)sender);
            pd.toolStripButton3.Click += ToolStripButton3_Click;
            pd.toolStripButton2.Click += ToolStripButton2_Click;
            pd.toolStripButton4.Click += ToolStripButton4_Click;
        }
        private void ToolStripButton4_Click(object sender, EventArgs e) //Zoom in
        {
            //int W = int.Parse(pd.pictureBox1.Size.Width.ToString());
            //int H = int.Parse(pd.pictureBox1.Size.Height.ToString());
            //Size x;
            //W = W + 50;
            //Height = Height + 50;
            //x = new Size(W, H);
            //pd.pictureBox1.Size = x;
        }    
        
        
        private void ToolStripButton2_Click(object sender, EventArgs e) //Previouspage
        {
            if (pdPictureIndex > 0)
            {
                pdPictureIndex--;
                pd.pictureBox1.Image = ((PictureBox)this.flowLayoutPanel1.Controls[pdPictureIndex]).Image;
            }
            else
            {
                pdPictureIndex = this.flowLayoutPanel1.Controls.Count - 1;
                pd.pictureBox1.Image = ((PictureBox)this.flowLayoutPanel1.Controls[pdPictureIndex]).Image;
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e) //NextPage
        {
            if (pdPictureIndex < this.flowLayoutPanel1.Controls.Count - 1)
            {
                pdPictureIndex++;
                pd.pictureBox1.Image = ((PictureBox)this.flowLayoutPanel1.Controls[pdPictureIndex]).Image;
            }
            else
            {
                pdPictureIndex = 0;
                pd.pictureBox1.Image = ((PictureBox)this.flowLayoutPanel1.Controls[pdPictureIndex]).Image;
            }
        }
        #endregion

        #region 相片管理LabelLink
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlbumDataSetTools Adst = new AlbumDataSetTools();
            Adst.ShowDialog();
        }
        #endregion

    }
}
