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
            this.labelThreshold = new System.Windows.Forms.Label();
            this.tabPicBox = new System.Windows.Forms.TabControl();
            this.tabOrigin = new System.Windows.Forms.TabPage();
            this.tabBW = new System.Windows.Forms.TabPage();
            this.bwPicBox = new System.Windows.Forms.PictureBox();
            this.tabEdge = new System.Windows.Forms.TabPage();
            this.edgePicBox = new System.Windows.Forms.PictureBox();
            this.tabCurve = new System.Windows.Forms.TabPage();
            this.curvePicBox = new System.Windows.Forms.PictureBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelLevel = new System.Windows.Forms.Label();
            this.textLevel = new System.Windows.Forms.TextBox();
            this.barLevel = new System.Windows.Forms.TrackBar();
            this.textResult = new System.Windows.Forms.TextBox();
            this.numAccuracy = new System.Windows.Forms.NumericUpDown();
            this.labelAccuracy = new System.Windows.Forms.Label();
            this.labelIgnore = new System.Windows.Forms.Label();
            this.numIgnore = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.originPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barThreshold)).BeginInit();
            this.tabPicBox.SuspendLayout();
            this.tabOrigin.SuspendLayout();
            this.tabBW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bwPicBox)).BeginInit();
            this.tabEdge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edgePicBox)).BeginInit();
            this.tabCurve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curvePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIgnore)).BeginInit();
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
            this.barThreshold.Location = new System.Drawing.Point(448, 51);
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
            this.textThreshold.Location = new System.Drawing.Point(403, 51);
            this.textThreshold.MaxLength = 3;
            this.textThreshold.Name = "textThreshold";
            this.textThreshold.Size = new System.Drawing.Size(39, 29);
            this.textThreshold.TabIndex = 3;
            this.textThreshold.Text = "127";
            this.textThreshold.TextChanged += new System.EventHandler(this.textThreshold_TextChanged);
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelThreshold.Location = new System.Drawing.Point(310, 54);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(87, 21);
            this.labelThreshold.TabIndex = 4;
            this.labelThreshold.Text = "Threshold:";
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
            this.tabOrigin.Enter += new System.EventHandler(this.tabOrigin_Enter);
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
            this.tabBW.Enter += new System.EventHandler(this.tabBW_Enter);
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
            this.tabEdge.Enter += new System.EventHandler(this.tabEdge_Enter);
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
            // tabCurve
            // 
            this.tabCurve.BackColor = System.Drawing.Color.Transparent;
            this.tabCurve.Controls.Add(this.curvePicBox);
            this.tabCurve.Location = new System.Drawing.Point(4, 26);
            this.tabCurve.Name = "tabCurve";
            this.tabCurve.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurve.Size = new System.Drawing.Size(282, 285);
            this.tabCurve.TabIndex = 3;
            this.tabCurve.Text = "Curve";
            this.tabCurve.Enter += new System.EventHandler(this.tabCurve_Enter);
            // 
            // curvePicBox
            // 
            this.curvePicBox.Location = new System.Drawing.Point(0, 2);
            this.curvePicBox.Name = "curvePicBox";
            this.curvePicBox.Size = new System.Drawing.Size(280, 280);
            this.curvePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.curvePicBox.TabIndex = 3;
            this.curvePicBox.TabStop = false;
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCalc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCalc.Location = new System.Drawing.Point(683, 134);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 24);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "Calculate!";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLevel.Location = new System.Drawing.Point(310, 96);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(88, 21);
            this.labelLevel.TabIndex = 9;
            this.labelLevel.Text = "Expansion:";
            // 
            // textLevel
            // 
            this.textLevel.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textLevel.Location = new System.Drawing.Point(403, 93);
            this.textLevel.MaxLength = 3;
            this.textLevel.Name = "textLevel";
            this.textLevel.Size = new System.Drawing.Size(39, 29);
            this.textLevel.TabIndex = 8;
            this.textLevel.Text = "10";
            this.textLevel.TextChanged += new System.EventHandler(this.textLevel_TextChanged);
            // 
            // barLevel
            // 
            this.barLevel.Location = new System.Drawing.Point(448, 93);
            this.barLevel.Maximum = 128;
            this.barLevel.Minimum = 1;
            this.barLevel.Name = "barLevel";
            this.barLevel.Size = new System.Drawing.Size(311, 45);
            this.barLevel.TabIndex = 7;
            this.barLevel.TickFrequency = 8;
            this.barLevel.Value = 10;
            this.barLevel.Scroll += new System.EventHandler(this.barLevel_Scroll);
            // 
            // textResult
            // 
            this.textResult.AcceptsReturn = true;
            this.textResult.AcceptsTab = true;
            this.textResult.BackColor = System.Drawing.Color.White;
            this.textResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textResult.Location = new System.Drawing.Point(314, 165);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResult.Size = new System.Drawing.Size(445, 162);
            this.textResult.TabIndex = 10;
            // 
            // numAccuracy
            // 
            this.numAccuracy.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numAccuracy.Location = new System.Drawing.Point(378, 136);
            this.numAccuracy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAccuracy.Name = "numAccuracy";
            this.numAccuracy.Size = new System.Drawing.Size(52, 23);
            this.numAccuracy.TabIndex = 11;
            this.numAccuracy.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelAccuracy
            // 
            this.labelAccuracy.AutoSize = true;
            this.labelAccuracy.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAccuracy.Location = new System.Drawing.Point(317, 138);
            this.labelAccuracy.Name = "labelAccuracy";
            this.labelAccuracy.Size = new System.Drawing.Size(62, 17);
            this.labelAccuracy.TabIndex = 12;
            this.labelAccuracy.Text = "Accuracy:";
            // 
            // labelIgnore
            // 
            this.labelIgnore.AutoSize = true;
            this.labelIgnore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelIgnore.Location = new System.Drawing.Point(445, 138);
            this.labelIgnore.Name = "labelIgnore";
            this.labelIgnore.Size = new System.Drawing.Size(165, 17);
            this.labelIgnore.TabIndex = 14;
            this.labelIgnore.Text = "Ignore edges shorter than:";
            // 
            // numIgnore
            // 
            this.numIgnore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numIgnore.Location = new System.Drawing.Point(609, 136);
            this.numIgnore.Name = "numIgnore";
            this.numIgnore.Size = new System.Drawing.Size(52, 23);
            this.numIgnore.TabIndex = 13;
            this.numIgnore.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 347);
            this.Controls.Add(this.numAccuracy);
            this.Controls.Add(this.numIgnore);
            this.Controls.Add(this.labelIgnore);
            this.Controls.Add(this.labelAccuracy);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.textLevel);
            this.Controls.Add(this.barLevel);
            this.Controls.Add(this.tabPicBox);
            this.Controls.Add(this.labelThreshold);
            this.Controls.Add(this.textThreshold);
            this.Controls.Add(this.barThreshold);
            this.Controls.Add(this.buttonImportPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
            this.tabCurve.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.curvePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIgnore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originPicBox;
        private System.Windows.Forms.Button buttonImportPic;
        private System.Windows.Forms.OpenFileDialog openPic;
        private System.Windows.Forms.TrackBar barThreshold;
        private System.Windows.Forms.TextBox textThreshold;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.TabControl tabPicBox;
        private System.Windows.Forms.TabPage tabOrigin;
        private System.Windows.Forms.TabPage tabBW;
        private System.Windows.Forms.TabPage tabEdge;
        private System.Windows.Forms.TabPage tabCurve;
        private System.Windows.Forms.PictureBox bwPicBox;
        private System.Windows.Forms.PictureBox edgePicBox;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.TextBox textLevel;
        private System.Windows.Forms.TrackBar barLevel;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.PictureBox curvePicBox;
        private System.Windows.Forms.NumericUpDown numAccuracy;
        private System.Windows.Forms.Label labelAccuracy;
        private System.Windows.Forms.Label labelIgnore;
        private System.Windows.Forms.NumericUpDown numIgnore;
    }
}

