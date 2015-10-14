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
            this.tabPicBox = new System.Windows.Forms.TabControl();
            this.tabOrigin = new System.Windows.Forms.TabPage();
            this.tabBW = new System.Windows.Forms.TabPage();
            this.bwPicBox = new System.Windows.Forms.PictureBox();
            this.tabEdge = new System.Windows.Forms.TabPage();
            this.tabCurve = new System.Windows.Forms.TabPage();
            this.edgePicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.originPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barThreshold)).BeginInit();
            this.tabPicBox.SuspendLayout();
            this.tabOrigin.SuspendLayout();
            this.tabBW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bwPicBox)).BeginInit();
            this.tabEdge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edgePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // originPicBox
            // 
            this.originPicBox.Location = new System.Drawing.Point(0, 2);
            this.originPicBox.Name = "originPicBox";
            this.originPicBox.Size = new System.Drawing.Size(280, 280);
            this.originPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originPicBox.TabIndex = 0;
            this.originPicBox.TabStop = false;
            this.originPicBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.originPicBox_LoadCompleted);
            // 
            // buttonImportPic
            // 
            this.buttonImportPic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonImportPic.Location = new System.Drawing.Point(314, 15);
            this.buttonImportPic.Name = "buttonImportPic";
            this.buttonImportPic.Size = new System.Drawing.Size(111, 24);
            this.buttonImportPic.TabIndex = 1;
            this.buttonImportPic.Text = "Import Image...";
            this.buttonImportPic.UseVisualStyleBackColor = true;
            this.buttonImportPic.Click += new System.EventHandler(this.buttonImportPic_Click);
            // 
            // openPic
            // 
            this.openPic.Filter = "Image files (*.jpg, *.jpeg, *png, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png|JP" +
    "EG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Fil" +
    "es (*.gif)|*.gif";
            this.openPic.Title = "Select a Image...";
            // 
            // barThreshold
            // 
            this.barThreshold.LargeChange = 10;
            this.barThreshold.Location = new System.Drawing.Point(448, 48);
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
            this.textThreshold.Location = new System.Drawing.Point(403, 48);
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
            this.label1.Location = new System.Drawing.Point(310, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Threshold:";
            // 
            // tabPicBox
            // 
            this.tabPicBox.Controls.Add(this.tabOrigin);
            this.tabPicBox.Controls.Add(this.tabBW);
            this.tabPicBox.Controls.Add(this.tabEdge);
            this.tabPicBox.Controls.Add(this.tabCurve);
            this.tabPicBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPicBox.Location = new System.Drawing.Point(12, 12);
            this.tabPicBox.Name = "tabPicBox";
            this.tabPicBox.SelectedIndex = 0;
            this.tabPicBox.Size = new System.Drawing.Size(290, 315);
            this.tabPicBox.TabIndex = 5;
            // 
            // tabOrigin
            // 
            this.tabOrigin.BackColor = System.Drawing.Color.Transparent;
            this.tabOrigin.Controls.Add(this.originPicBox);
            this.tabOrigin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabOrigin.Location = new System.Drawing.Point(4, 26);
            this.tabOrigin.Name = "tabOrigin";
            this.tabOrigin.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrigin.Size = new System.Drawing.Size(282, 285);
            this.tabOrigin.TabIndex = 0;
            this.tabOrigin.Text = "Original";
            // 
            // tabBW
            // 
            this.tabBW.BackColor = System.Drawing.Color.Transparent;
            this.tabBW.Controls.Add(this.bwPicBox);
            this.tabBW.Location = new System.Drawing.Point(4, 26);
            this.tabBW.Name = "tabBW";
            this.tabBW.Padding = new System.Windows.Forms.Padding(3);
            this.tabBW.Size = new System.Drawing.Size(282, 285);
            this.tabBW.TabIndex = 1;
            this.tabBW.Text = "Black&White";
            // 
            // bwPicBox
            // 
            this.bwPicBox.Location = new System.Drawing.Point(0, 2);
            this.bwPicBox.Name = "bwPicBox";
            this.bwPicBox.Size = new System.Drawing.Size(280, 280);
            this.bwPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bwPicBox.TabIndex = 1;
            this.bwPicBox.TabStop = false;
            // 
            // tabEdge
            // 
            this.tabEdge.BackColor = System.Drawing.Color.Transparent;
            this.tabEdge.Controls.Add(this.edgePicBox);
            this.tabEdge.Location = new System.Drawing.Point(4, 26);
            this.tabEdge.Name = "tabEdge";
            this.tabEdge.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdge.Size = new System.Drawing.Size(282, 285);
            this.tabEdge.TabIndex = 2;
            this.tabEdge.Text = "Edge";
            // 
            // tabCurve
            // 
            this.tabCurve.BackColor = System.Drawing.Color.Transparent;
            this.tabCurve.Location = new System.Drawing.Point(4, 26);
            this.tabCurve.Name = "tabCurve";
            this.tabCurve.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurve.Size = new System.Drawing.Size(282, 285);
            this.tabCurve.TabIndex = 3;
            this.tabCurve.Text = "Curve";
            // 
            // edgePicBox
            // 
            this.edgePicBox.Location = new System.Drawing.Point(0, 2);
            this.edgePicBox.Name = "edgePicBox";
            this.edgePicBox.Size = new System.Drawing.Size(280, 280);
            this.edgePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edgePicBox.TabIndex = 2;
            this.edgePicBox.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 347);
            this.Controls.Add(this.tabPicBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textThreshold);
            this.Controls.Add(this.barThreshold);
            this.Controls.Add(this.buttonImportPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Fourier Draft";
            ((System.ComponentModel.ISupportInitialize)(this.originPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barThreshold)).EndInit();
            this.tabPicBox.ResumeLayout(false);
            this.tabOrigin.ResumeLayout(false);
            this.tabBW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bwPicBox)).EndInit();
            this.tabEdge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edgePicBox)).EndInit();
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
        private System.Windows.Forms.TabControl tabPicBox;
        private System.Windows.Forms.TabPage tabOrigin;
        private System.Windows.Forms.TabPage tabBW;
        private System.Windows.Forms.TabPage tabEdge;
        private System.Windows.Forms.TabPage tabCurve;
        private System.Windows.Forms.PictureBox bwPicBox;
        private System.Windows.Forms.PictureBox edgePicBox;
    }
}

