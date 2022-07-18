
namespace Route_builder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.open_img_button = new System.Windows.Forms.Button();
            this.save_img_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ruler_cb = new System.Windows.Forms.CheckBox();
            this.finish_cb = new System.Windows.Forms.CheckBox();
            this.point_cb = new System.Windows.Forms.CheckBox();
            this.route_but = new System.Windows.Forms.Button();
            this.back_but = new System.Windows.Forms.Button();
            this.clear_but = new System.Windows.Forms.Button();
            this.optimize_graph_but = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.build_but = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.distance_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.map_scale_textBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.save_graph_in_DB = new System.Windows.Forms.Button();
            this.map_name_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_but = new System.Windows.Forms.Button();
            this.change_but = new System.Windows.Forms.Button();
            this.open_but = new System.Windows.Forms.Button();
            this.add_but = new System.Windows.Forms.Button();
            this.del_but = new System.Windows.Forms.Button();
            this.mapsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mapsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.open_img_button);
            this.splitContainer1.Panel2.Controls.Add(this.save_img_button);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(870, 450);
            this.splitContainer1.SplitterDistance = 670;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picturedox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox1_DragEnter);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // open_img_button
            // 
            this.open_img_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.open_img_button.Location = new System.Drawing.Point(4, 416);
            this.open_img_button.Name = "open_img_button";
            this.open_img_button.Size = new System.Drawing.Size(90, 29);
            this.open_img_button.TabIndex = 2;
            this.open_img_button.Text = "Open";
            this.open_img_button.UseVisualStyleBackColor = true;
            this.open_img_button.Click += new System.EventHandler(this.open_img_button_Click);
            // 
            // save_img_button
            // 
            this.save_img_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save_img_button.Location = new System.Drawing.Point(102, 416);
            this.save_img_button.Name = "save_img_button";
            this.save_img_button.Size = new System.Drawing.Size(90, 29);
            this.save_img_button.TabIndex = 1;
            this.save_img_button.Text = "Save";
            this.save_img_button.UseVisualStyleBackColor = true;
            this.save_img_button.Click += new System.EventHandler(this.save_img_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(197, 410);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ruler_cb);
            this.tabPage1.Controls.Add(this.finish_cb);
            this.tabPage1.Controls.Add(this.point_cb);
            this.tabPage1.Controls.Add(this.route_but);
            this.tabPage1.Controls.Add(this.back_but);
            this.tabPage1.Controls.Add(this.clear_but);
            this.tabPage1.Controls.Add(this.optimize_graph_but);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.build_but);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.distance_textBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.map_scale_textBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(189, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ruler_cb
            // 
            this.ruler_cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ruler_cb.Appearance = System.Windows.Forms.Appearance.Button;
            this.ruler_cb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ruler_cb.BackgroundImage")));
            this.ruler_cb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ruler_cb.Location = new System.Drawing.Point(156, 55);
            this.ruler_cb.Name = "ruler_cb";
            this.ruler_cb.Size = new System.Drawing.Size(27, 27);
            this.ruler_cb.TabIndex = 20;
            this.ruler_cb.UseVisualStyleBackColor = true;
            this.ruler_cb.CheckedChanged += new System.EventHandler(this.ruler_cb_CheckedChanged);
            // 
            // finish_cb
            // 
            this.finish_cb.Appearance = System.Windows.Forms.Appearance.Button;
            this.finish_cb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finish_cb.BackgroundImage")));
            this.finish_cb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.finish_cb.Location = new System.Drawing.Point(60, 6);
            this.finish_cb.Name = "finish_cb";
            this.finish_cb.Size = new System.Drawing.Size(45, 45);
            this.finish_cb.TabIndex = 19;
            this.finish_cb.UseVisualStyleBackColor = true;
            this.finish_cb.CheckedChanged += new System.EventHandler(this.finish_cb_CheckedChanged);
            // 
            // point_cb
            // 
            this.point_cb.Appearance = System.Windows.Forms.Appearance.Button;
            this.point_cb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("point_cb.BackgroundImage")));
            this.point_cb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.point_cb.Location = new System.Drawing.Point(9, 6);
            this.point_cb.Name = "point_cb";
            this.point_cb.Size = new System.Drawing.Size(45, 45);
            this.point_cb.TabIndex = 18;
            this.point_cb.UseVisualStyleBackColor = true;
            this.point_cb.CheckedChanged += new System.EventHandler(this.point_cb_CheckedChanged);
            // 
            // route_but
            // 
            this.route_but.Location = new System.Drawing.Point(14, 352);
            this.route_but.Name = "route_but";
            this.route_but.Size = new System.Drawing.Size(157, 23);
            this.route_but.TabIndex = 17;
            this.route_but.Text = "build route";
            this.route_but.UseVisualStyleBackColor = true;
            this.route_but.Click += new System.EventHandler(this.route_but_Click);
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(93, 280);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(75, 23);
            this.back_but.TabIndex = 16;
            this.back_but.Text = "back";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // clear_but
            // 
            this.clear_but.Location = new System.Drawing.Point(14, 280);
            this.clear_but.Name = "clear_but";
            this.clear_but.Size = new System.Drawing.Size(75, 23);
            this.clear_but.TabIndex = 15;
            this.clear_but.Text = "clear";
            this.clear_but.UseVisualStyleBackColor = true;
            this.clear_but.Click += new System.EventHandler(this.clear_but_Click);
            // 
            // optimize_graph_but
            // 
            this.optimize_graph_but.Location = new System.Drawing.Point(14, 309);
            this.optimize_graph_but.Name = "optimize_graph_but";
            this.optimize_graph_but.Size = new System.Drawing.Size(75, 23);
            this.optimize_graph_but.TabIndex = 14;
            this.optimize_graph_but.Text = "optimize";
            this.optimize_graph_but.UseVisualStyleBackColor = true;
            this.optimize_graph_but.Click += new System.EventHandler(this.optimize_graph_but_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Speed:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(98, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 22);
            this.textBox3.TabIndex = 11;
            // 
            // build_but
            // 
            this.build_but.BackColor = System.Drawing.Color.Transparent;
            this.build_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.build_but.Location = new System.Drawing.Point(111, 6);
            this.build_but.Name = "build_but";
            this.build_but.Size = new System.Drawing.Size(72, 45);
            this.build_but.TabIndex = 10;
            this.build_but.Text = "Build";
            this.build_but.UseVisualStyleBackColor = false;
            this.build_but.Click += new System.EventHandler(this.build_but_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hours:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(98, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 22);
            this.textBox2.TabIndex = 8;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(125, 92);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(47, 92);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Distance, km:";
            // 
            // distance_textBox
            // 
            this.distance_textBox.Location = new System.Drawing.Point(17, 130);
            this.distance_textBox.Name = "distance_textBox";
            this.distance_textBox.Size = new System.Drawing.Size(73, 22);
            this.distance_textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scale, m:";
            // 
            // map_scale_textBox
            // 
            this.map_scale_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map_scale_textBox.Location = new System.Drawing.Point(83, 57);
            this.map_scale_textBox.Name = "map_scale_textBox";
            this.map_scale_textBox.Size = new System.Drawing.Size(70, 22);
            this.map_scale_textBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.save_graph_in_DB);
            this.tabPage2.Controls.Add(this.map_name_textBox);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.search_but);
            this.tabPage2.Controls.Add(this.change_but);
            this.tabPage2.Controls.Add(this.open_but);
            this.tabPage2.Controls.Add(this.add_but);
            this.tabPage2.Controls.Add(this.del_but);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(189, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DataBase";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // save_graph_in_DB
            // 
            this.save_graph_in_DB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save_graph_in_DB.Location = new System.Drawing.Point(7, 49);
            this.save_graph_in_DB.Name = "save_graph_in_DB";
            this.save_graph_in_DB.Size = new System.Drawing.Size(169, 23);
            this.save_graph_in_DB.TabIndex = 10;
            this.save_graph_in_DB.Text = "Save graph";
            this.save_graph_in_DB.UseVisualStyleBackColor = true;
            this.save_graph_in_DB.Click += new System.EventHandler(this.save_graph_in_DB_Click);
            // 
            // map_name_textBox
            // 
            this.map_name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map_name_textBox.Location = new System.Drawing.Point(6, 78);
            this.map_name_textBox.Name = "map_name_textBox";
            this.map_name_textBox.Size = new System.Drawing.Size(152, 22);
            this.map_name_textBox.TabIndex = 6;
            this.map_name_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.map_name_textBox_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(182, 272);
            this.dataGridView1.TabIndex = 5;
            // 
            // search_but
            // 
            this.search_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_but.BackgroundImage")));
            this.search_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_but.Location = new System.Drawing.Point(163, 77);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(27, 27);
            this.search_but.TabIndex = 9;
            this.search_but.UseVisualStyleBackColor = true;
            this.search_but.Click += new System.EventHandler(this.search_but_Click);
            // 
            // change_but
            // 
            this.change_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.change_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("change_but.BackgroundImage")));
            this.change_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.change_but.Location = new System.Drawing.Point(94, 6);
            this.change_but.Name = "change_but";
            this.change_but.Size = new System.Drawing.Size(38, 38);
            this.change_but.TabIndex = 8;
            this.change_but.UseVisualStyleBackColor = true;
            this.change_but.Click += new System.EventHandler(this.change_but_Click);
            // 
            // open_but
            // 
            this.open_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.open_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open_but.BackgroundImage")));
            this.open_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.open_but.Location = new System.Drawing.Point(50, 6);
            this.open_but.Name = "open_but";
            this.open_but.Size = new System.Drawing.Size(38, 38);
            this.open_but.TabIndex = 7;
            this.open_but.UseVisualStyleBackColor = true;
            this.open_but.Click += new System.EventHandler(this.open_but_Click);
            // 
            // add_but
            // 
            this.add_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_but.BackgroundImage")));
            this.add_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_but.Location = new System.Drawing.Point(6, 6);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(38, 38);
            this.add_but.TabIndex = 4;
            this.add_but.UseVisualStyleBackColor = true;
            this.add_but.Click += new System.EventHandler(this.add_but_Click);
            // 
            // del_but
            // 
            this.del_but.AccessibleDescription = "";
            this.del_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.del_but.BackColor = System.Drawing.Color.Transparent;
            this.del_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("del_but.BackgroundImage")));
            this.del_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.del_but.Location = new System.Drawing.Point(138, 6);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(38, 38);
            this.del_but.TabIndex = 3;
            this.del_but.UseVisualStyleBackColor = false;
            this.del_but.Click += new System.EventHandler(this.del_but_Click);
            // 
            // mapsBindingSource1
            // 
            this.mapsBindingSource1.DataMember = "Maps";
            // 
            // mapsBindingSource
            // 
            this.mapsBindingSource.DataMember = "Maps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(888, 497);
            this.Name = "Form1";
            this.Text = "Roure builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource mapsBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button save_img_button;
        private System.Windows.Forms.Button open_img_button;
        private System.Windows.Forms.Button add_but;
        private System.Windows.Forms.Button del_but;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mapsBindingSource1;
        private System.Windows.Forms.TextBox map_name_textBox;
        private System.Windows.Forms.Button change_but;
        private System.Windows.Forms.Button open_but;
        private System.Windows.Forms.Button search_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox map_scale_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox distance_textBox;
        private System.Windows.Forms.Button build_but;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button optimize_graph_but;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Button clear_but;
        private System.Windows.Forms.Button route_but;
        private System.Windows.Forms.Button save_graph_in_DB;
        private System.Windows.Forms.CheckBox point_cb;
        private System.Windows.Forms.CheckBox ruler_cb;
        private System.Windows.Forms.CheckBox finish_cb;
    }
}

