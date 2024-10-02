//**********************************************************************
//**                                                                  **
//**             STUDENT NAME: ALPEREN YAZICI                         **
//**             STUDENT NUMBER: B221202019                           **
//**********************************************************************

namespace proje1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_centerX = new System.Windows.Forms.TextBox();
            this.txt_rotation = new System.Windows.Forms.TextBox();
            this.txt_edgeNumber = new System.Windows.Forms.TextBox();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.txt_centerY = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_draw = new System.Windows.Forms.Button();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Center Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number Of Edge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rotation Angel";
            // 
            // txt_centerX
            // 
            this.txt_centerX.Location = new System.Drawing.Point(131, 32);
            this.txt_centerX.Name = "txt_centerX";
            this.txt_centerX.Size = new System.Drawing.Size(100, 20);
            this.txt_centerX.TabIndex = 4;
            this.txt_centerX.TextChanged += new System.EventHandler(this.txt_centerX_TextChanged);
            // 
            // txt_rotation
            // 
            this.txt_rotation.Location = new System.Drawing.Point(131, 133);
            this.txt_rotation.Name = "txt_rotation";
            this.txt_rotation.Size = new System.Drawing.Size(100, 20);
            this.txt_rotation.TabIndex = 5;
            this.txt_rotation.TextChanged += new System.EventHandler(this.txt_rotation_TextChanged);
            // 
            // txt_edgeNumber
            // 
            this.txt_edgeNumber.Location = new System.Drawing.Point(131, 94);
            this.txt_edgeNumber.Name = "txt_edgeNumber";
            this.txt_edgeNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_edgeNumber.TabIndex = 6;
            this.txt_edgeNumber.TextChanged += new System.EventHandler(this.txt_edgeNumber_TextChanged);
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(131, 62);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(100, 20);
            this.txt_length.TabIndex = 7;
            this.txt_length.TextChanged += new System.EventHandler(this.txt_length_TextChanged);
            // 
            // txt_centerY
            // 
            this.txt_centerY.Location = new System.Drawing.Point(252, 32);
            this.txt_centerY.Name = "txt_centerY";
            this.txt_centerY.Size = new System.Drawing.Size(100, 20);
            this.txt_centerY.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(51, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 121);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_random
            // 
            this.btn_random.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_random.Location = new System.Drawing.Point(236, 227);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(116, 23);
            this.btn_random.TabIndex = 10;
            this.btn_random.Text = "Set Random Value";
            this.btn_random.UseVisualStyleBackColor = false;
            this.btn_random.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_draw
            // 
            this.btn_draw.Location = new System.Drawing.Point(236, 256);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(116, 23);
            this.btn_draw.TabIndex = 11;
            this.btn_draw.Text = "Draw";
            this.btn_draw.UseVisualStyleBackColor = true;
            this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
            // 
            // btn_rotate
            // 
            this.btn_rotate.Location = new System.Drawing.Point(236, 285);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(116, 23);
            this.btn_rotate.TabIndex = 12;
            this.btn_rotate.Text = "Rotate";
            this.btn_rotate.UseVisualStyleBackColor = true;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(445, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 276);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_rotate);
            this.Controls.Add(this.btn_draw);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_centerY);
            this.Controls.Add(this.txt_length);
            this.Controls.Add(this.txt_edgeNumber);
            this.Controls.Add(this.txt_rotation);
            this.Controls.Add(this.txt_centerX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_centerX;
        private System.Windows.Forms.TextBox txt_rotation;
        private System.Windows.Forms.TextBox txt_edgeNumber;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.TextBox txt_centerY;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
#endregion