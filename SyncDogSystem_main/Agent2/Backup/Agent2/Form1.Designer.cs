namespace Agent2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.alert = new System.Windows.Forms.Label();
            this.pg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clone
            // 
            this.clone.BackColor = System.Drawing.Color.DodgerBlue;
            this.clone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.clone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clone.Location = new System.Drawing.Point(184, 199);
            this.clone.Name = "clone";
            this.clone.Size = new System.Drawing.Size(254, 42);
            this.clone.TabIndex = 0;
            this.clone.Text = "Force Sync";
            this.clone.UseVisualStyleBackColor = false;
            this.clone.Click += new System.EventHandler(this.clone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(160, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 1;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.alert.Location = new System.Drawing.Point(243, 136);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(0, 24);
            this.alert.TabIndex = 2;
            // 
            // pg
            // 
            this.pg.AutoSize = true;
            this.pg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pg.Cursor = System.Windows.Forms.Cursors.Default;
            this.pg.ForeColor = System.Drawing.Color.Red;
            this.pg.Location = new System.Drawing.Point(281, 265);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(289, 13);
            this.pg.TabIndex = 3;
            this.pg.Text = "หมายเหตุ : ระบบจะทำการซิงค์ข้อมูลเวลา 07:30:00 ของทุกวัน ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(582, 287);
            this.Controls.Add(this.pg);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SyncSystemDog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button clone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label alert;
        private System.Windows.Forms.Label pg;
    }
}

