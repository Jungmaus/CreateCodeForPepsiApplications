namespace _101PepsiHack
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtAlanX = new System.Windows.Forms.TextBox();
            this.txtAlanY = new System.Windows.Forms.TextBox();
            this.txtButtonX = new System.Windows.Forms.TextBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.txtButtonY = new System.Windows.Forms.TextBox();
            this.btnDur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(13, 425);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(35, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "label1";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(54, 425);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(35, 13);
            this.lblY.TabIndex = 0;
            this.lblY.Text = "label1";
            this.lblY.Click += new System.EventHandler(this.lblX_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(13, 13);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 1;
            // 
            // txtAlanX
            // 
            this.txtAlanX.Location = new System.Drawing.Point(247, 123);
            this.txtAlanX.Name = "txtAlanX";
            this.txtAlanX.Size = new System.Drawing.Size(100, 20);
            this.txtAlanX.TabIndex = 1;
            // 
            // txtAlanY
            // 
            this.txtAlanY.Location = new System.Drawing.Point(247, 149);
            this.txtAlanY.Name = "txtAlanY";
            this.txtAlanY.Size = new System.Drawing.Size(100, 20);
            this.txtAlanY.TabIndex = 1;
            // 
            // txtButtonX
            // 
            this.txtButtonX.Location = new System.Drawing.Point(247, 178);
            this.txtButtonX.Name = "txtButtonX";
            this.txtButtonX.Size = new System.Drawing.Size(100, 20);
            this.txtButtonX.TabIndex = 1;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(234, 247);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 2;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // txtButtonY
            // 
            this.txtButtonY.Location = new System.Drawing.Point(247, 204);
            this.txtButtonY.Name = "txtButtonY";
            this.txtButtonY.Size = new System.Drawing.Size(100, 20);
            this.txtButtonY.TabIndex = 1;
            // 
            // btnDur
            // 
            this.btnDur.Location = new System.Drawing.Point(315, 247);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(75, 23);
            this.btnDur.TabIndex = 2;
            this.btnDur.Text = "Dur";
            this.btnDur.UseVisualStyleBackColor = true;
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TextboxALANX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TextboxALANY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "BUTTONALANX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "BUTTONALANY";
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDur);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.txtButtonY);
            this.Controls.Add(this.txtButtonX);
            this.Controls.Add(this.txtAlanY);
            this.Controls.Add(this.txtAlanX);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtAlanX;
        private System.Windows.Forms.TextBox txtAlanY;
        private System.Windows.Forms.TextBox txtButtonX;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.TextBox txtButtonY;
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
    }
}

