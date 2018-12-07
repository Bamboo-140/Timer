namespace Timer
{
    partial class Frm_Question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Question));
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tim_shutDownStopWatch = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pic_QuestionICO = new System.Windows.Forms.PictureBox();
            this.lab_time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_QuestionICO)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(80, 78);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "确认";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(162, 78);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tim_shutDownStopWatch
            // 
            this.tim_shutDownStopWatch.Enabled = true;
            this.tim_shutDownStopWatch.Interval = 1000;
            this.tim_shutDownStopWatch.Tick += new System.EventHandler(this.tim_shutDownStopWatch_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "您有设置关机,时间已到是否关闭计算机?";
            // 
            // pic_QuestionICO
            // 
            this.pic_QuestionICO.Image = ((System.Drawing.Image)(resources.GetObject("pic_QuestionICO.Image")));
            this.pic_QuestionICO.Location = new System.Drawing.Point(12, 12);
            this.pic_QuestionICO.Name = "pic_QuestionICO";
            this.pic_QuestionICO.Size = new System.Drawing.Size(48, 48);
            this.pic_QuestionICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_QuestionICO.TabIndex = 3;
            this.pic_QuestionICO.TabStop = false;
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.Location = new System.Drawing.Point(87, 48);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(17, 12);
            this.lab_time.TabIndex = 4;
            this.lab_time.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "秒后将自动执行确定";
            // 
            // Frm_Question
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 113);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.pic_QuestionICO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Question";
            this.Text = "Frm_Question";
            ((System.ComponentModel.ISupportInitialize)(this.pic_QuestionICO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Timer tim_shutDownStopWatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_QuestionICO;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Label label2;
    }
}