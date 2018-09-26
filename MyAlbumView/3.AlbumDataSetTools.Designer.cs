namespace MyAlbumView
{
    partial class AlbumDataSetTools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumDataSetTools));
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label categoryNameLabel;
            System.Windows.Forms.Label photoIDLabel;
            System.Windows.Forms.Label categoryIDLabel1;
            System.Windows.Forms.Label photoNameLabel;
            System.Windows.Forms.Label pictureLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label modifydateLabel;
            this.myAlbumManagementDataSet = new MyAlbumView.MyAlbumManagementDataSet();
            this.photoCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoCategoryTableAdapter = new MyAlbumView.MyAlbumManagementDataSetTableAdapters.PhotoCategoryTableAdapter();
            this.tableAdapterManager = new MyAlbumView.MyAlbumManagementDataSetTableAdapters.TableAdapterManager();
            this.photoCategoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.photoCategoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.photoCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photosTableAdapter = new MyAlbumView.MyAlbumManagementDataSetTableAdapters.PhotosTableAdapter();
            this.photosDataGridView = new System.Windows.Forms.DataGridView();
            this.categoryIDTextBox = new System.Windows.Forms.TextBox();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.photoIDTextBox = new System.Windows.Forms.TextBox();
            this.categoryIDTextBox1 = new System.Windows.Forms.TextBox();
            this.photoNameTextBox = new System.Windows.Forms.TextBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.modifydateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            categoryIDLabel = new System.Windows.Forms.Label();
            categoryNameLabel = new System.Windows.Forms.Label();
            photoIDLabel = new System.Windows.Forms.Label();
            categoryIDLabel1 = new System.Windows.Forms.Label();
            photoNameLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            modifydateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryBindingNavigator)).BeginInit();
            this.photoCategoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myAlbumManagementDataSet
            // 
            this.myAlbumManagementDataSet.DataSetName = "MyAlbumManagementDataSet";
            this.myAlbumManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // photoCategoryBindingSource
            // 
            this.photoCategoryBindingSource.DataMember = "PhotoCategory";
            this.photoCategoryBindingSource.DataSource = this.myAlbumManagementDataSet;
            // 
            // photoCategoryTableAdapter
            // 
            this.photoCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PhotoCategoryTableAdapter = this.photoCategoryTableAdapter;
            this.tableAdapterManager.PhotosTableAdapter = this.photosTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyAlbumView.MyAlbumManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // photoCategoryBindingNavigator
            // 
            this.photoCategoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.photoCategoryBindingNavigator.BindingSource = this.photoCategoryBindingSource;
            this.photoCategoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.photoCategoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.photoCategoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.photoCategoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.photoCategoryBindingNavigatorSaveItem});
            this.photoCategoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.photoCategoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.photoCategoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.photoCategoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.photoCategoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.photoCategoryBindingNavigator.Name = "photoCategoryBindingNavigator";
            this.photoCategoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.photoCategoryBindingNavigator.Size = new System.Drawing.Size(998, 31);
            this.photoCategoryBindingNavigator.TabIndex = 0;
            this.photoCategoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(40, 28);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // photoCategoryBindingNavigatorSaveItem
            // 
            this.photoCategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.photoCategoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("photoCategoryBindingNavigatorSaveItem.Image")));
            this.photoCategoryBindingNavigatorSaveItem.Name = "photoCategoryBindingNavigatorSaveItem";
            this.photoCategoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.photoCategoryBindingNavigatorSaveItem.Text = "儲存資料";
            this.photoCategoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.photoCategoryBindingNavigatorSaveItem_Click);
            // 
            // photoCategoryDataGridView
            // 
            this.photoCategoryDataGridView.AutoGenerateColumns = false;
            this.photoCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photoCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.photoCategoryDataGridView.DataSource = this.photoCategoryBindingSource;
            this.photoCategoryDataGridView.Location = new System.Drawing.Point(12, 151);
            this.photoCategoryDataGridView.Name = "photoCategoryDataGridView";
            this.photoCategoryDataGridView.RowTemplate.Height = 28;
            this.photoCategoryDataGridView.Size = new System.Drawing.Size(356, 368);
            this.photoCategoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CategoryName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // photosBindingSource
            // 
            this.photosBindingSource.DataMember = "Photos";
            this.photosBindingSource.DataSource = this.myAlbumManagementDataSet;
            // 
            // photosTableAdapter
            // 
            this.photosTableAdapter.ClearBeforeFill = true;
            // 
            // photosDataGridView
            // 
            this.photosDataGridView.AutoGenerateColumns = false;
            this.photosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.photosDataGridView.DataSource = this.photosBindingSource;
            this.photosDataGridView.Location = new System.Drawing.Point(431, 299);
            this.photosDataGridView.Name = "photosDataGridView";
            this.photosDataGridView.RowTemplate.Height = 28;
            this.photosDataGridView.Size = new System.Drawing.Size(544, 220);
            this.photosDataGridView.TabIndex = 2;
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(34, 66);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(98, 20);
            categoryIDLabel.TabIndex = 3;
            categoryIDLabel.Text = "Category ID:";
            // 
            // categoryIDTextBox
            // 
            this.categoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoCategoryBindingSource, "CategoryID", true));
            this.categoryIDTextBox.Location = new System.Drawing.Point(163, 63);
            this.categoryIDTextBox.Name = "categoryIDTextBox";
            this.categoryIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.categoryIDTextBox.TabIndex = 4;
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new System.Drawing.Point(34, 98);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new System.Drawing.Size(123, 20);
            categoryNameLabel.TabIndex = 5;
            categoryNameLabel.Text = "Category Name:";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoCategoryBindingSource, "CategoryName", true));
            this.categoryNameTextBox.Location = new System.Drawing.Point(163, 95);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.categoryNameTextBox.TabIndex = 6;
            // 
            // photoIDLabel
            // 
            photoIDLabel.AutoSize = true;
            photoIDLabel.Location = new System.Drawing.Point(450, 69);
            photoIDLabel.Name = "photoIDLabel";
            photoIDLabel.Size = new System.Drawing.Size(76, 20);
            photoIDLabel.TabIndex = 7;
            photoIDLabel.Text = "Photo ID:";
            // 
            // photoIDTextBox
            // 
            this.photoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "PhotoID", true));
            this.photoIDTextBox.Location = new System.Drawing.Point(557, 66);
            this.photoIDTextBox.Name = "photoIDTextBox";
            this.photoIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.photoIDTextBox.TabIndex = 8;
            // 
            // categoryIDLabel1
            // 
            categoryIDLabel1.AutoSize = true;
            categoryIDLabel1.Location = new System.Drawing.Point(450, 101);
            categoryIDLabel1.Name = "categoryIDLabel1";
            categoryIDLabel1.Size = new System.Drawing.Size(98, 20);
            categoryIDLabel1.TabIndex = 9;
            categoryIDLabel1.Text = "Category ID:";
            // 
            // categoryIDTextBox1
            // 
            this.categoryIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "CategoryID", true));
            this.categoryIDTextBox1.Location = new System.Drawing.Point(557, 98);
            this.categoryIDTextBox1.Name = "categoryIDTextBox1";
            this.categoryIDTextBox1.Size = new System.Drawing.Size(200, 26);
            this.categoryIDTextBox1.TabIndex = 10;
            // 
            // photoNameLabel
            // 
            photoNameLabel.AutoSize = true;
            photoNameLabel.Location = new System.Drawing.Point(450, 133);
            photoNameLabel.Name = "photoNameLabel";
            photoNameLabel.Size = new System.Drawing.Size(101, 20);
            photoNameLabel.TabIndex = 11;
            photoNameLabel.Text = "Photo Name:";
            // 
            // photoNameTextBox
            // 
            this.photoNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "PhotoName", true));
            this.photoNameTextBox.Location = new System.Drawing.Point(557, 130);
            this.photoNameTextBox.Name = "photoNameTextBox";
            this.photoNameTextBox.Size = new System.Drawing.Size(200, 26);
            this.photoNameTextBox.TabIndex = 12;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(759, 46);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(62, 20);
            pictureLabel.TabIndex = 13;
            pictureLabel.Text = "Picture:";
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photosBindingSource, "Picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(763, 69);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(200, 119);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 14;
            this.picturePictureBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(450, 165);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(557, 162);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 26);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // modifydateLabel
            // 
            modifydateLabel.AutoSize = true;
            modifydateLabel.Location = new System.Drawing.Point(450, 198);
            modifydateLabel.Name = "modifydateLabel";
            modifydateLabel.Size = new System.Drawing.Size(91, 20);
            modifydateLabel.TabIndex = 17;
            modifydateLabel.Text = "Modifydate:";
            // 
            // modifydateDateTimePicker
            // 
            this.modifydateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.photosBindingSource, "Modifydate", true));
            this.modifydateDateTimePicker.Location = new System.Drawing.Point(557, 194);
            this.modifydateDateTimePicker.Name = "modifydateDateTimePicker";
            this.modifydateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.modifydateDateTimePicker.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "加入照片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(763, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 31);
            this.button2.TabIndex = 20;
            this.button2.Text = "確定修改入DB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhotoID";
            this.dataGridViewTextBoxColumn3.HeaderText = "PhotoID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PhotoName";
            this.dataGridViewTextBoxColumn5.HeaderText = "PhotoName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Modifydate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Modifydate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // AlbumDataSetTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(photoIDLabel);
            this.Controls.Add(this.photoIDTextBox);
            this.Controls.Add(categoryIDLabel1);
            this.Controls.Add(this.categoryIDTextBox1);
            this.Controls.Add(photoNameLabel);
            this.Controls.Add(this.photoNameTextBox);
            this.Controls.Add(pictureLabel);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(modifydateLabel);
            this.Controls.Add(this.modifydateDateTimePicker);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDTextBox);
            this.Controls.Add(categoryNameLabel);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.photosDataGridView);
            this.Controls.Add(this.photoCategoryDataGridView);
            this.Controls.Add(this.photoCategoryBindingNavigator);
            this.Name = "AlbumDataSetTools";
            this.Text = "AlbumDataSetTools";
            this.Load += new System.EventHandler(this.AlbumDataSetTools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryBindingNavigator)).EndInit();
            this.photoCategoryBindingNavigator.ResumeLayout(false);
            this.photoCategoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyAlbumManagementDataSet myAlbumManagementDataSet;
        private System.Windows.Forms.BindingSource photoCategoryBindingSource;
        private MyAlbumManagementDataSetTableAdapters.PhotoCategoryTableAdapter photoCategoryTableAdapter;
        private MyAlbumManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator photoCategoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton photoCategoryBindingNavigatorSaveItem;
        private MyAlbumManagementDataSetTableAdapters.PhotosTableAdapter photosTableAdapter;
        private System.Windows.Forms.DataGridView photoCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource photosBindingSource;
        private System.Windows.Forms.DataGridView photosDataGridView;
        private System.Windows.Forms.TextBox categoryIDTextBox;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.TextBox photoIDTextBox;
        private System.Windows.Forms.TextBox categoryIDTextBox1;
        private System.Windows.Forms.TextBox photoNameTextBox;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker modifydateDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}