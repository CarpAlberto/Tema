namespace Tema2.views
{
    partial class ManagementUseriView
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
            System.Windows.Forms.Button btn_Activ;
            System.Windows.Forms.Button btn_Delete;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxMP = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxSP = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxNewPass = new System.Windows.Forms.CheckBox();
            this.checkBoxSU = new System.Windows.Forms.CheckBox();
            this.checkBoxMU = new System.Windows.Forms.CheckBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            btn_Activ = new System.Windows.Forms.Button();
            btn_Delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(345, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Management utilizatori";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(btn_Delete);
            this.groupBox1.Controls.Add(btn_Activ);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(2, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pending users";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 134);
            this.listBox1.TabIndex = 0;
            // 
            // btn_Activ
            // 
            btn_Activ.BackColor = System.Drawing.Color.RoyalBlue;
            btn_Activ.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Activ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_Activ.Location = new System.Drawing.Point(10, 196);
            btn_Activ.Name = "btn_Activ";
            btn_Activ.Size = new System.Drawing.Size(75, 36);
            btn_Activ.TabIndex = 6;
            btn_Activ.Text = "Activare";
            btn_Activ.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = System.Drawing.Color.RoyalBlue;
            btn_Delete.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_Delete.Location = new System.Drawing.Point(236, 196);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new System.Drawing.Size(75, 36);
            btn_Delete.TabIndex = 7;
            btn_Delete.Text = "Stergere";
            btn_Delete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "*selectati contul apoi apasati Activare sau Stergere";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 509);
            this.panel2.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(314, 715);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 59;
            this.button1.Text = "Update  User";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(579, 642);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 58;
            this.label9.Text = "Student";
            // 
            // checkBoxMP
            // 
            this.checkBoxMP.AutoSize = true;
            this.checkBoxMP.Location = new System.Drawing.Point(542, 647);
            this.checkBoxMP.Name = "checkBoxMP";
            this.checkBoxMP.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMP.TabIndex = 57;
            this.checkBoxMP.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(376, 647);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 56;
            this.label8.Text = "Secretariat";
            // 
            // checkBoxSP
            // 
            this.checkBoxSP.AutoSize = true;
            this.checkBoxSP.Location = new System.Drawing.Point(338, 652);
            this.checkBoxSP.Name = "checkBoxSP";
            this.checkBoxSP.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSP.TabIndex = 55;
            this.checkBoxSP.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(124, 648);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "SefDepartament/Decan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(579, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "Profesor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(376, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "Comandant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(125, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(292, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Permisiuni Noi";
            // 
            // checkBoxNewPass
            // 
            this.checkBoxNewPass.AutoSize = true;
            this.checkBoxNewPass.Location = new System.Drawing.Point(296, 430);
            this.checkBoxNewPass.Name = "checkBoxNewPass";
            this.checkBoxNewPass.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNewPass.TabIndex = 49;
            this.checkBoxNewPass.UseVisualStyleBackColor = true;
            // 
            // checkBoxSU
            // 
            this.checkBoxSU.AutoSize = true;
            this.checkBoxSU.Location = new System.Drawing.Point(338, 591);
            this.checkBoxSU.Name = "checkBoxSU";
            this.checkBoxSU.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSU.TabIndex = 48;
            this.checkBoxSU.UseVisualStyleBackColor = true;
            // 
            // checkBoxMU
            // 
            this.checkBoxMU.AutoSize = true;
            this.checkBoxMU.Location = new System.Drawing.Point(542, 591);
            this.checkBoxMU.Name = "checkBoxMU";
            this.checkBoxMU.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMU.TabIndex = 47;
            this.checkBoxMU.UseVisualStyleBackColor = true;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.Purple;
            this.textBoxPass.Location = new System.Drawing.Point(348, 424);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(174, 25);
            this.textBoxPass.TabIndex = 46;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(153, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 19);
            this.label10.TabIndex = 45;
            this.label10.Text = "New Password";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(348, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 26);
            this.comboBox1.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(153, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 19);
            this.label11.TabIndex = 43;
            this.label11.Text = "Toti Userii";
            // 
            // ManagementUseriView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(942, 799);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBoxMP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxSP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxNewPass);
            this.Controls.Add(this.checkBoxSU);
            this.Controls.Add(this.checkBoxMU);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ManagementUseriView";
            this.Text = "ManagementUseriView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxMP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxNewPass;
        private System.Windows.Forms.CheckBox checkBoxSU;
        private System.Windows.Forms.CheckBox checkBoxMU;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
    }
}