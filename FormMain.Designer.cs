namespace ScaleNearestNeighborWinFormCoreCSharp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxOperation = new System.Windows.Forms.Label();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxScale = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.groupBoxImage = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblSelectFileName = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBoxOperation.Location = new System.Drawing.Point(26, 74);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Size = new System.Drawing.Size(481, 1158);
            this.groupBoxOperation.TabIndex = 0;
            this.groupBoxOperation.Text = "Operation";
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFileSelect.Location = new System.Drawing.Point(111, 133);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(300, 100);
            this.btnFileSelect.TabIndex = 1;
            this.btnFileSelect.Text = "File Select...";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.OnClickBtnFileSelect);
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInit.Location = new System.Drawing.Point(111, 384);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(300, 100);
            this.btnInit.TabIndex = 3;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = false;
            this.btnInit.Click += new System.EventHandler(this.OnClickBtnInit);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Location = new System.Drawing.Point(111, 511);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(300, 100);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // groupBoxScale
            // 
            this.groupBoxScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBoxScale.Location = new System.Drawing.Point(76, 796);
            this.groupBoxScale.Name = "groupBoxScale";
            this.groupBoxScale.Size = new System.Drawing.Size(379, 398);
            this.groupBoxScale.TabIndex = 4;
            this.groupBoxScale.Text = "Scale";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGo.Location = new System.Drawing.Point(111, 943);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(300, 100);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.OnClickBtnGo);
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBoxImage.Location = new System.Drawing.Point(527, 74);
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.Size = new System.Drawing.Size(1154, 1158);
            this.groupBoxImage.TabIndex = 11;
            this.groupBoxImage.Text = "Image";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(546, 181);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1118, 1032);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(1, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1698, 55);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Scale Nearest Neighbor";
            // 
            // numericUpDown
            // 
            this.numericUpDown.DecimalPlaces = 1;
            this.numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown.Location = new System.Drawing.Point(111, 865);
            this.numericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.ReadOnly = true;
            this.numericUpDown.Size = new System.Drawing.Size(300, 54);
            this.numericUpDown.TabIndex = 5;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveImage.Location = new System.Drawing.Point(111, 258);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(300, 100);
            this.btnSaveImage.TabIndex = 2;
            this.btnSaveImage.Text = "Save Image...";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(26, 1252);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1655, 30);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 14;
            // 
            // lblSelectFileName
            // 
            this.lblSelectFileName.Location = new System.Drawing.Point(546, 120);
            this.lblSelectFileName.Name = "lblSelectFileName";
            this.lblSelectFileName.Size = new System.Drawing.Size(1118, 51);
            this.lblSelectFileName.TabIndex = 15;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStop.Location = new System.Drawing.Point(111, 1068);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(300, 100);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.OnClickBtnStop);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1700, 1300);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblSelectFileName);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.groupBoxScale);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.groupBoxOperation);
            this.Controls.Add(this.groupBoxImage);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label groupBoxOperation;
        private System.Windows.Forms.Label groupBoxScale;
        private System.Windows.Forms.Label groupBoxImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblSelectFileName;
        private System.Windows.Forms.Button btnStop;
    }
}

