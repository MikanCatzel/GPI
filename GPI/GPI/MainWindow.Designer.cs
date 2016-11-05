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
            this.pNavBar = new System.Windows.Forms.Panel();
            this.pNavBar_DTT = new System.Windows.Forms.Panel();
            this.bNavBar_DTT = new System.Windows.Forms.Button();
            this.pNavBar_Title = new System.Windows.Forms.Panel();
            this.lProgramDesc = new System.Windows.Forms.Label();
            this.lProgramTitle = new System.Windows.Forms.Label();
            this.bNavBar_Temp = new System.Windows.Forms.Button();
            this.pNavBar_Temp = new System.Windows.Forms.Panel();
            this.pMainWindow.SuspendLayout();
            this.pNavBar.SuspendLayout();
            this.pNavBar_DTT.SuspendLayout();
            this.pNavBar_Title.SuspendLayout();
            this.pNavBar_Temp.SuspendLayout();
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
            this.pActiveModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pActiveModule.Location = new System.Drawing.Point(183, 0);
            this.pActiveModule.Name = "pActiveModule";
            this.pActiveModule.Size = new System.Drawing.Size(913, 590);
            this.pActiveModule.TabIndex = 1;
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
            this.lProgramDesc.Font = new System.Drawing.Font("Lato Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProgramDesc.Location = new System.Drawing.Point(12, 34);
            this.lProgramDesc.Name = "lProgramDesc";
            this.lProgramDesc.Size = new System.Drawing.Size(149, 13);
            this.lProgramDesc.TabIndex = 1;
            this.lProgramDesc.Text = "General Purpose Intelligence";
            // 
            // lProgramTitle
            // 
            this.lProgramTitle.AutoSize = true;
            this.lProgramTitle.Font = new System.Drawing.Font("Lato Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProgramTitle.Location = new System.Drawing.Point(11, 9);
            this.lProgramTitle.Name = "lProgramTitle";
            this.lProgramTitle.Size = new System.Drawing.Size(43, 24);
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
            this.pNavBar.ResumeLayout(false);
            this.pNavBar_DTT.ResumeLayout(false);
            this.pNavBar_Title.ResumeLayout(false);
            this.pNavBar_Title.PerformLayout();
            this.pNavBar_Temp.ResumeLayout(false);
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
    }
}