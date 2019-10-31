namespace Lab1
{
    partial class Fractals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fractals));
            this.Picture = new System.Windows.Forms.PictureBox();
            this.cRealField = new System.Windows.Forms.TextBox();
            this.cImagineField = new System.Windows.Forms.TextBox();
            this.RankCombobox = new System.Windows.Forms.ComboBox();
            this.ColorSchemaCombobox = new System.Windows.Forms.ComboBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TrackBar1 = new System.Windows.Forms.TrackBar();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.WrongComplexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Indigo;
            this.Picture.Location = new System.Drawing.Point(12, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(586, 381);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // cRealField
            // 
            this.cRealField.Location = new System.Drawing.Point(7, 33);
            this.cRealField.Name = "cRealField";
            this.cRealField.Size = new System.Drawing.Size(99, 29);
            this.cRealField.TabIndex = 1;
            this.cRealField.TextChanged += new System.EventHandler(this.cRealField_TextChanged);
            // 
            // cImagineField
            // 
            this.cImagineField.Location = new System.Drawing.Point(112, 33);
            this.cImagineField.Name = "cImagineField";
            this.cImagineField.Size = new System.Drawing.Size(111, 29);
            this.cImagineField.TabIndex = 2;
            this.cImagineField.TextChanged += new System.EventHandler(this.cRealField_TextChanged);
            // 
            // RankCombobox
            // 
            this.RankCombobox.DisplayMember = "4";
            this.RankCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.RankCombobox.FormattingEnabled = true;
            this.RankCombobox.Items.AddRange(new object[] {
            "3",
            "4"});
            this.RankCombobox.Location = new System.Drawing.Point(613, 66);
            this.RankCombobox.Name = "RankCombobox";
            this.RankCombobox.Size = new System.Drawing.Size(229, 32);
            this.RankCombobox.TabIndex = 3;
            this.RankCombobox.Text = "3";
            // 
            // ColorSchemaCombobox
            // 
            this.ColorSchemaCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ColorSchemaCombobox.FormattingEnabled = true;
            this.ColorSchemaCombobox.Items.AddRange(new object[] {
            "Фіолетова",
            "Жовта",
            "Зелена",
            "Синя",
            "Червона"});
            this.ColorSchemaCombobox.Location = new System.Drawing.Point(612, 225);
            this.ColorSchemaCombobox.Name = "ColorSchemaCombobox";
            this.ColorSchemaCombobox.Size = new System.Drawing.Size(229, 32);
            this.ColorSchemaCombobox.TabIndex = 4;
            this.ColorSchemaCombobox.Text = "Фіолетова";
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartBtn.Location = new System.Drawing.Point(612, 368);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(230, 57);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "Побудувати";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cImagineField);
            this.groupBox1.Controls.Add(this.cRealField);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(612, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complex constant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrchid;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(657, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Порядок: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrchid;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(638, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Колірна схема: ";
            // 
            // TrackBar1
            // 
            this.TrackBar1.Location = new System.Drawing.Point(612, 139);
            this.TrackBar1.Maximum = 500;
            this.TrackBar1.Minimum = 20;
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(229, 45);
            this.TrackBar1.TabIndex = 11;
            this.TrackBar1.TickFrequency = 20;
            this.TrackBar1.Value = 100;
            this.TrackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.BackColor = System.Drawing.Color.DarkOrchid;
            this.ScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScaleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ScaleLabel.Location = new System.Drawing.Point(638, 111);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(177, 25);
            this.ScaleLabel.TabIndex = 12;
            this.ScaleLabel.Text = "Масштаб: 100% ";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(13, 399);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(585, 26);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Зберегти";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // WrongComplexLabel
            // 
            this.WrongComplexLabel.AutoSize = true;
            this.WrongComplexLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongComplexLabel.Location = new System.Drawing.Point(616, 342);
            this.WrongComplexLabel.Name = "WrongComplexLabel";
            this.WrongComplexLabel.Size = new System.Drawing.Size(206, 13);
            this.WrongComplexLabel.TabIndex = 14;
            this.WrongComplexLabel.Text = "Only digits and \",\" can be used in this field";
            this.WrongComplexLabel.Visible = false;
            // 
            // Fractals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(853, 443);
            this.Controls.Add(this.WrongComplexLabel);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ScaleLabel);
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.ColorSchemaCombobox);
            this.Controls.Add(this.RankCombobox);
            this.Controls.Add(this.Picture);
            this.Name = "Fractals";
            this.Text = "Fractals";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox cRealField;
        private System.Windows.Forms.TextBox cImagineField;
        private System.Windows.Forms.ComboBox RankCombobox;
        private System.Windows.Forms.ComboBox ColorSchemaCombobox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TrackBar TrackBar1;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label WrongComplexLabel;
    }
}