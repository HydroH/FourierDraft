namespace FourierDraft
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.originPicBox = new System.Windows.Forms.PictureBox();
            this.buttonImportPic = new System.Windows.Forms.Button();
            this.openPic = new System.Windows.Forms.OpenFileDialog();
            this.barThreshold = new System.Windows.Forms.TrackBar();
            this.textThreshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // originPicBox
            // 
            this.originPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originPicBox.Location = new System.Drawing.Point(22, 50);
            this.originPicBox.Name = "originPicBox";
            this.originPicBox.Size = new System.Drawing.Size(281, 276);
            this.originPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originPicBox.TabIndex = 0;
            this.originPicBox.TabStop = false;
            // 
            // buttonImportPic
            // 
            this.buttonImportPic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonImportPic.Location = new System.Drawing.Point(22, 12);
            this.buttonImportPic.Name = "buttonImportPic";
            this.buttonImportPic.Size = new System.Drawing.Size(111, 24);
            this.buttonImportPic.TabIndex = 1;
            this.buttonImportPic.Text = "Import Image...";
            this.buttonImportPic.UseVisualStyleBackColor = true;
            this.buttonImportPic.Click += new System.EventHandler(this.buttonImportPic_Click);
            // 
            // openPic
            // 
            this.openPic.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jp" +
    "g|GIF Files (*.gif)|*.gif";
            this.openPic.Title = "Select a Image...";
            // 
            // barThreshold
            // 
            this.barThreshold.LargeChange = 10;
            this.barThreshold.Location = new System.Drawing.Point(447, 47);
            this.barThreshold.Maximum = 255;
            this.barThreshold.Name = "barThreshold";
            this.barThreshold.Size = new System.Drawing.Size(311, 45);
            this.barThreshold.TabIndex = 2;
            this.barThreshold.TickFrequency = 15;
            this.barThreshold.Value = 127;
            this.barThreshold.Scroll += new System.EventHandler(this.barThreshold_Scroll);
            // 
            // textThreshold
            // 
            this.textThreshold.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textThreshold.Location = new System.Drawing.Point(402, 47);
            this.textThreshold.MaxLength = 3;
            this.textThreshold.Name = "textThreshold";
            this.textThreshold.Size = new System.Drawing.Size(39, 29);
            this.textThreshold.TabIndex = 3;
            this.textThreshold.Text = "127";
            this.textThreshold.TextChanged += new System.EventHandler(this.textThreshold_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(309, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Threshold:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textThreshold);
            this.Controls.Add(this.barThreshold);
            this.Controls.Add(this.buttonImportPic);
            this.Controls.Add(this.originPicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Fourier Draft";
            ((System.ComponentModel.ISupportInitialize)(this.originPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originPicBox;
        private System.Windows.Forms.Button buttonImportPic;
        private System.Windows.Forms.OpenFileDialog openPic;
        private System.Windows.Forms.TrackBar barThreshold;
        private System.Windows.Forms.TextBox textThreshold;
        private System.Windows.Forms.Label label1;
    }
}

