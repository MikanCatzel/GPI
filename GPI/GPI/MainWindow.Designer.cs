namespace GPI
{
    partial class MainWindow
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
            if(disposing && (components != null))
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
            this.pMainWindow = new System.Windows.Forms.Panel();
            this.pActiveModule = new System.Windows.Forms.Panel();
            this.pDebug = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEndTime = new System.Windows.Forms.TextBox();
            this.tbStartTime = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.bDebugSetValues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pNavBar = new System.Windows.Forms.Panel();
            this.pNavBar_Temp = new System.Windows.Forms.Panel();
            this.bNavBar_Temp = new System.Windows.Forms.Button();
            this.pNavBar_DTT = new System.Windows.Forms.Panel();
            this.bNavBar_DTT = new System.Windows.Forms.Button();
            this.pNavBar_Title = new System.Windows.Forms.Panel();
            this.lProgramDesc = new System.Windows.Forms.Label();
            this.lProgramTitle = new System.Windows.Forms.Label();
            this.bNavBar_Temp = new System.Windows.Forms.Button();
            this.pNavBar_Temp = new System.Windows.Forms.Panel();
            this.bDebugSetValues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pDebug = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbStartTime = new System.Windows.Forms.TextBox();
            this.tbEndTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lEventTitle = new System.Windows.Forms.Label();
            this.lEventStartTime = new System.Windows.Forms.Label();
            this.lEventEndTime = new System.Windows.Forms.Label();
            this.pMainWindow.SuspendLayout();
            this.pActiveModule.SuspendLayout();
            this.pDebug.SuspendLayout();
            this.pNavBar.SuspendLayout();
            this.pNavBar_Temp.SuspendLayout();
            this.pNavBar_DTT.SuspendLayout();
            this.pNavBar_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMainWindow
            // 
            this.pMainWindow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pMainWindow.Controls.Add(this.pActiveModule);
            this.pMainWindow.Controls.Add(this.pNavBar);
            this.pMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainWindow.Location = new System.Drawing.Point(0, 0);
            this.pMainWindow.Name = "pMainWindow";
            this.pMainWindow.Size = new System.Drawing.Size(1096, 590);
            this.pMainWindow.TabIndex = 0;
            // 
            // pActiveModule
            // 
            this.pActiveModule.Controls.Add(this.pDebug);
            this.pActiveModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pActiveModule.Location = new System.Drawing.Point(183, 0);
            this.pActiveModule.Name = "pActiveModule";
            this.pActiveModule.Size = new System.Drawing.Size(913, 590);
            this.pActiveModule.TabIndex = 1;
            // 
            // pDebug
            // 
            this.pDebug.BackColor = System.Drawing.Color.MistyRose;
            this.pDebug.Controls.Add(this.label4);
            this.pDebug.Controls.Add(this.label3);
            this.pDebug.Controls.Add(this.label2);
            this.pDebug.Controls.Add(this.tbEndTime);
            this.pDebug.Controls.Add(this.tbStartTime);
            this.pDebug.Controls.Add(this.tbTitle);
            this.pDebug.Controls.Add(this.bDebugSetValues);
            this.pDebug.Controls.Add(this.label1);
            this.pDebug.Location = new System.Drawing.Point(297, 134);
            this.pDebug.Name = "pDebug";
            this.pDebug.Size = new System.Drawing.Size(332, 291);
            this.pDebug.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Event End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Event Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Event Title";
            // 
            // tbEndTime
            // 
            this.tbEndTime.Location = new System.Drawing.Point(20, 78);
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Size = new System.Drawing.Size(100, 20);
            this.tbEndTime.TabIndex = 4;
            // 
            // tbStartTime
            // 
            this.tbStartTime.Location = new System.Drawing.Point(20, 52);
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(100, 20);
            this.tbStartTime.TabIndex = 3;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(20, 26);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 2;
            // 
            // bDebugSetValues
            // 
            this.bDebugSetValues.Location = new System.Drawing.Point(222, 252);
            this.bDebugSetValues.Name = "bDebugSetValues";
            this.bDebugSetValues.Size = new System.Drawing.Size(97, 27);
            this.bDebugSetValues.TabIndex = 0;
            this.bDebugSetValues.Text = "Create Event";
            this.bDebugSetValues.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Info";
            // 
            // pNavBar
            // 
            this.pNavBar.BackColor = System.Drawing.Color.Gainsboro;
            this.pNavBar.Controls.Add(this.pNavBar_Temp);
            this.pNavBar.Controls.Add(this.pNavBar_DTT);
            this.pNavBar.Controls.Add(this.pNavBar_Title);
            this.pNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pNavBar.Location = new System.Drawing.Point(0, 0);
            this.pNavBar.Name = "pNavBar";
            this.pNavBar.Size = new System.Drawing.Size(183, 590);
            this.pNavBar.TabIndex = 0;
            // 
            // pNavBar_Temp
            // 
            this.pNavBar_Temp.BackColor = System.Drawing.Color.PapayaWhip;
            this.pNavBar_Temp.Controls.Add(this.bNavBar_Temp);
            this.pNavBar_Temp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNavBar_Temp.Location = new System.Drawing.Point(0, 120);
            this.pNavBar_Temp.Name = "pNavBar_Temp";
            this.pNavBar_Temp.Size = new System.Drawing.Size(183, 64);
            this.pNavBar_Temp.TabIndex = 3;
            // 
            // bNavBar_Temp
            // 
            this.bNavBar_Temp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bNavBar_Temp.BackColor = System.Drawing.Color.BurlyWood;
            this.bNavBar_Temp.FlatAppearance.BorderSize = 3;
            this.bNavBar_Temp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNavBar_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNavBar_Temp.Location = new System.Drawing.Point(4, 4);
            this.bNavBar_Temp.Name = "bNavBar_Temp";
            this.bNavBar_Temp.Size = new System.Drawing.Size(176, 57);
            this.bNavBar_Temp.TabIndex = 0;
            this.bNavBar_Temp.Text = "Temp Button";
            this.bNavBar_Temp.UseVisualStyleBackColor = false;
            this.bNavBar_Temp.Click += new System.EventHandler(this.bNavBar_Temp_Click);
            // 
            // pNavBar_DTT
            // 
            this.pNavBar_DTT.BackColor = System.Drawing.Color.PapayaWhip;
            this.pNavBar_DTT.Controls.Add(this.bNavBar_DTT);
            this.pNavBar_DTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNavBar_DTT.Location = new System.Drawing.Point(0, 56);
            this.pNavBar_DTT.Name = "pNavBar_DTT";
            this.pNavBar_DTT.Size = new System.Drawing.Size(183, 64);
            this.pNavBar_DTT.TabIndex = 2;
            // 
            // bNavBar_DTT
            // 
            this.bNavBar_DTT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bNavBar_DTT.BackColor = System.Drawing.Color.BurlyWood;
            this.bNavBar_DTT.FlatAppearance.BorderSize = 3;
            this.bNavBar_DTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNavBar_DTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNavBar_DTT.Location = new System.Drawing.Point(4, 4);
            this.bNavBar_DTT.Name = "bNavBar_DTT";
            this.bNavBar_DTT.Size = new System.Drawing.Size(176, 57);
            this.bNavBar_DTT.TabIndex = 0;
            this.bNavBar_DTT.Text = "Daily Timetable";
            this.bNavBar_DTT.UseVisualStyleBackColor = false;
            this.bNavBar_DTT.Click += new System.EventHandler(this.bNavBar_DTT_Click);
            // 
            // pNavBar_Title
            // 
            this.pNavBar_Title.BackColor = System.Drawing.Color.Silver;
            this.pNavBar_Title.Controls.Add(this.lProgramDesc);
            this.pNavBar_Title.Controls.Add(this.lProgramTitle);
            this.pNavBar_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNavBar_Title.Location = new System.Drawing.Point(0, 0);
            this.pNavBar_Title.Name = "pNavBar_Title";
            this.pNavBar_Title.Size = new System.Drawing.Size(183, 56);
            this.pNavBar_Title.TabIndex = 1;
            // 
            // lProgramDesc
            // 
            this.lProgramDesc.AutoSize = true;
            this.lProgramDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProgramDesc.Location = new System.Drawing.Point(12, 34);
            this.lProgramDesc.Name = "lProgramDesc";
            this.lProgramDesc.Size = new System.Drawing.Size(143, 13);
            this.lProgramDesc.TabIndex = 1;
            this.lProgramDesc.Text = "General Purpose Intelligence";
            // 
            // lProgramTitle
            // 
            this.lProgramTitle.AutoSize = true;
            this.lProgramTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProgramTitle.Location = new System.Drawing.Point(11, 9);
            this.lProgramTitle.Name = "lProgramTitle";
            this.lProgramTitle.Size = new System.Drawing.Size(45, 25);
            this.lProgramTitle.TabIndex = 1;
            this.lProgramTitle.Text = "GPI";
            // 
            // bNavBar_Temp
            // 
            this.bNavBar_Temp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bNavBar_Temp.BackColor = System.Drawing.Color.BurlyWood;
            this.bNavBar_Temp.FlatAppearance.BorderSize = 3;
            this.bNavBar_Temp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNavBar_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNavBar_Temp.Location = new System.Drawing.Point(4, 4);
            this.bNavBar_Temp.Name = "bNavBar_Temp";
            this.bNavBar_Temp.Size = new System.Drawing.Size(176, 57);
            this.bNavBar_Temp.TabIndex = 0;
            this.bNavBar_Temp.Text = "Temp Button";
            this.bNavBar_Temp.UseVisualStyleBackColor = false;
            this.bNavBar_Temp.Click += new System.EventHandler(this.bNavBar_Temp_Click);
            // 
            // pNavBar_Temp
            // 
            this.pNavBar_Temp.BackColor = System.Drawing.Color.PapayaWhip;
            this.pNavBar_Temp.Controls.Add(this.bNavBar_Temp);
            this.pNavBar_Temp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNavBar_Temp.Location = new System.Drawing.Point(0, 120);
            this.pNavBar_Temp.Name = "pNavBar_Temp";
            this.pNavBar_Temp.Size = new System.Drawing.Size(183, 64);
            this.pNavBar_Temp.TabIndex = 3;
            // 
            // bDebugSetValues
            // 
            this.bDebugSetValues.Location = new System.Drawing.Point(222, 252);
            this.bDebugSetValues.Name = "bDebugSetValues";
            this.bDebugSetValues.Size = new System.Drawing.Size(97, 27);
            this.bDebugSetValues.TabIndex = 0;
            this.bDebugSetValues.Text = "Create Event";
            this.bDebugSetValues.UseVisualStyleBackColor = true;
            this.bDebugSetValues.Click += new System.EventHandler(this.bDebugSetValues_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Info";
            // 
            // pDebug
            // 
            this.pDebug.BackColor = System.Drawing.Color.MistyRose;
            this.pDebug.Controls.Add(this.lEventEndTime);
            this.pDebug.Controls.Add(this.lEventStartTime);
            this.pDebug.Controls.Add(this.lEventTitle);
            this.pDebug.Controls.Add(this.label4);
            this.pDebug.Controls.Add(this.label3);
            this.pDebug.Controls.Add(this.label2);
            this.pDebug.Controls.Add(this.tbEndTime);
            this.pDebug.Controls.Add(this.tbStartTime);
            this.pDebug.Controls.Add(this.tbTitle);
            this.pDebug.Controls.Add(this.bDebugSetValues);
            this.pDebug.Controls.Add(this.label1);
            this.pDebug.Location = new System.Drawing.Point(297, 134);
            this.pDebug.Name = "pDebug";
            this.pDebug.Size = new System.Drawing.Size(332, 291);
            this.pDebug.TabIndex = 2;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(20, 26);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 2;
            // 
            // tbStartTime
            // 
            this.tbStartTime.Location = new System.Drawing.Point(20, 52);
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(100, 20);
            this.tbStartTime.TabIndex = 3;
            // 
            // tbEndTime
            // 
            this.tbEndTime.Location = new System.Drawing.Point(20, 78);
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Size = new System.Drawing.Size(100, 20);
            this.tbEndTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Event Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Event Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Event End Time";
            // 
            // lEventTitle
            // 
            this.lEventTitle.AutoSize = true;
            this.lEventTitle.Location = new System.Drawing.Point(17, 160);
            this.lEventTitle.Name = "lEventTitle";
            this.lEventTitle.Size = new System.Drawing.Size(30, 13);
            this.lEventTitle.TabIndex = 7;
            this.lEventTitle.Text = "Title:";
            // 
            // lEventStartTime
            // 
            this.lEventStartTime.AutoSize = true;
            this.lEventStartTime.Location = new System.Drawing.Point(17, 186);
            this.lEventStartTime.Name = "lEventStartTime";
            this.lEventStartTime.Size = new System.Drawing.Size(54, 13);
            this.lEventStartTime.TabIndex = 7;
            this.lEventStartTime.Text = "Start time:";
            // 
            // lEventEndTime
            // 
            this.lEventEndTime.AutoSize = true;
            this.lEventEndTime.Location = new System.Drawing.Point(17, 213);
            this.lEventEndTime.Name = "lEventEndTime";
            this.lEventEndTime.Size = new System.Drawing.Size(51, 13);
            this.lEventEndTime.TabIndex = 7;
            this.lEventEndTime.Text = "End time:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1096, 590);
            this.Controls.Add(this.pMainWindow);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPI Program";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.pMainWindow.ResumeLayout(false);
            this.pActiveModule.ResumeLayout(false);
            this.pDebug.ResumeLayout(false);
            this.pDebug.PerformLayout();
            this.pNavBar.ResumeLayout(false);
            this.pNavBar_Temp.ResumeLayout(false);
            this.pNavBar_DTT.ResumeLayout(false);
            this.pNavBar_Title.ResumeLayout(false);
            this.pNavBar_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMainWindow;
        private System.Windows.Forms.Panel pNavBar;
        private System.Windows.Forms.Panel pNavBar_Title;
        private System.Windows.Forms.Label lProgramDesc;
        private System.Windows.Forms.Label lProgramTitle;
        private System.Windows.Forms.Panel pNavBar_DTT;
        private System.Windows.Forms.Button bNavBar_DTT;
        private System.Windows.Forms.Panel pActiveModule;
        private System.Windows.Forms.Panel pNavBar_Temp;
        private System.Windows.Forms.Button bNavBar_Temp;
        private System.Windows.Forms.Panel pDebug;
        private System.Windows.Forms.Label lEventEndTime;
        private System.Windows.Forms.Label lEventStartTime;
        private System.Windows.Forms.Label lEventTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEndTime;
        private System.Windows.Forms.TextBox tbStartTime;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button bDebugSetValues;
        private System.Windows.Forms.Label label1;
    }
}