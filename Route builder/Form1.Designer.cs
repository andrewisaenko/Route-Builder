
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.open_img_button = new System.Windows.Forms.Button();
            this.save_img_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.search_but = new System.Windows.Forms.Button();
            this.change_but = new System.Windows.Forms.Button();
            this.open_but = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picturedox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox1_DragEnter);
            // 
            // open_img_button
            // 
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
            this.save_img_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(196, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(188, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.search_but);
            this.tabPage2.Controls.Add(this.change_but);
            this.tabPage2.Controls.Add(this.open_but);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.add_but);
            this.tabPage2.Controls.Add(this.del_but);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(188, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DataBase";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // search_but
            // 
            this.search_but.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.search_but.Location = new System.Drawing.Point(140, 39);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(40, 22);
            this.search_but.TabIndex = 9;
            this.search_but.Text = "Search";
            this.search_but.UseVisualStyleBackColor = true;
            this.search_but.Click += new System.EventHandler(this.search_but_Click);
            // 
            // change_but
            // 
            this.change_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.change_but.Location = new System.Drawing.Point(94, 6);
            this.change_but.Name = "change_but";
            this.change_but.Size = new System.Drawing.Size(40, 27);
            this.change_but.TabIndex = 8;
            this.change_but.Text = "Change";
            this.change_but.UseVisualStyleBackColor = true;
            this.change_but.Click += new System.EventHandler(this.change_but_Click);
            // 
            // open_but
            // 
            this.open_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.open_but.Location = new System.Drawing.Point(50, 6);
            this.open_but.Name = "open_but";
            this.open_but.Size = new System.Drawing.Size(40, 27);
            this.open_but.TabIndex = 7;
            this.open_but.Text = "Open";
            this.open_but.UseVisualStyleBackColor = true;
            this.open_but.Click += new System.EventHandler(this.open_but_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(182, 311);
            this.dataGridView1.TabIndex = 5;
            // 
            // add_but
            // 
            this.add_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_but.Location = new System.Drawing.Point(6, 6);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(40, 27);
            this.add_but.TabIndex = 4;
            this.add_but.Text = "Add";
            this.add_but.UseVisualStyleBackColor = true;
            this.add_but.Click += new System.EventHandler(this.add_but_Click);
            // 
            // del_but
            // 
            this.del_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.del_but.Location = new System.Drawing.Point(140, 6);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(40, 27);
            this.del_but.TabIndex = 3;
            this.del_but.Text = "Delete";
            this.del_but.UseVisualStyleBackColor = true;
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
            this.MinimumSize = new System.Drawing.Size(888, 497);
            this.Name = "Form1";
            this.Text = "Roure builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button change_but;
        private System.Windows.Forms.Button open_but;
        private System.Windows.Forms.Button search_but;
    }
}

