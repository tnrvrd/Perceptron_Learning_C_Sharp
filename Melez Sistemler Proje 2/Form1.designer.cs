namespace Melez_Sistemler_Proje_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbInput = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaxLoop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNewInput = new System.Windows.Forms.TextBox();
            this.tbResultWeightVector = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInitialWeightVector = new System.Windows.Forms.TextBox();
            this.btnCalculatePercepron = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbInput
            // 
            this.lbInput.FormattingEnabled = true;
            this.lbInput.Location = new System.Drawing.Point(3, 30);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(258, 316);
            this.lbInput.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbMaxLoop);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tbResultWeightVector);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbTeta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbInitialWeightVector);
            this.panel1.Controls.Add(this.btnCalculatePercepron);
            this.panel1.Controls.Add(this.lbInput);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 406);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Max Loop";
            // 
            // tbMaxLoop
            // 
            this.tbMaxLoop.Location = new System.Drawing.Point(558, 7);
            this.tbMaxLoop.Name = "tbMaxLoop";
            this.tbMaxLoop.Size = new System.Drawing.Size(100, 20);
            this.tbMaxLoop.TabIndex = 13;
            this.tbMaxLoop.Text = "9999";
            this.tbMaxLoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Inputs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNewInput);
            this.groupBox1.Location = new System.Drawing.Point(273, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 136);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate for New Inputs";
            this.groupBox1.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(10, 105);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 13);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "Result :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "New Input";
            // 
            // tbNewInput
            // 
            this.tbNewInput.Location = new System.Drawing.Point(99, 30);
            this.tbNewInput.Name = "tbNewInput";
            this.tbNewInput.Size = new System.Drawing.Size(103, 20);
            this.tbNewInput.TabIndex = 9;
            this.tbNewInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbResultWeightVector
            // 
            this.tbResultWeightVector.Enabled = false;
            this.tbResultWeightVector.Location = new System.Drawing.Point(384, 109);
            this.tbResultWeightVector.Name = "tbResultWeightVector";
            this.tbResultWeightVector.Size = new System.Drawing.Size(433, 20);
            this.tbResultWeightVector.TabIndex = 8;
            this.tbResultWeightVector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result Weight Vector";
            // 
            // tbTeta
            // 
            this.tbTeta.Location = new System.Drawing.Point(375, 33);
            this.tbTeta.Name = "tbTeta";
            this.tbTeta.Size = new System.Drawing.Size(100, 20);
            this.tbTeta.TabIndex = 6;
            this.tbTeta.Text = "0,1";
            this.tbTeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Teta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Initial Weight Vector";
            // 
            // tbInitialWeightVector
            // 
            this.tbInitialWeightVector.Location = new System.Drawing.Point(375, 7);
            this.tbInitialWeightVector.Name = "tbInitialWeightVector";
            this.tbInitialWeightVector.Size = new System.Drawing.Size(100, 20);
            this.tbInitialWeightVector.TabIndex = 3;
            this.tbInitialWeightVector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculatePercepron
            // 
            this.btnCalculatePercepron.Location = new System.Drawing.Point(270, 61);
            this.btnCalculatePercepron.Name = "btnCalculatePercepron";
            this.btnCalculatePercepron.Size = new System.Drawing.Size(208, 23);
            this.btnCalculatePercepron.TabIndex = 2;
            this.btnCalculatePercepron.Text = "Calculate Perceptron";
            this.btnCalculatePercepron.UseVisualStyleBackColor = true;
            this.btnCalculatePercepron.Click += new System.EventHandler(this.btnCalculatePercepron_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem,
            this.algorithmToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userManualToolStripMenuItem.Text = "User Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // algorithmToolStripMenuItem
            // 
            this.algorithmToolStripMenuItem.Name = "algorithmToolStripMenuItem";
            this.algorithmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.algorithmToolStripMenuItem.Text = "Algorithm";
            this.algorithmToolStripMenuItem.Click += new System.EventHandler(this.algorithmToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "The Perceptron Learning";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalculatePercepron;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInitialWeightVector;
        private System.Windows.Forms.TextBox tbTeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResultWeightVector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNewInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaxLoop;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

