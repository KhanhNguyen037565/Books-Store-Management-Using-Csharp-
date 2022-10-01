
namespace report_statistics_of_staff
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnReportStatistics = new System.Windows.Forms.Panel();
            this.btnStatisticsManager = new System.Windows.Forms.Button();
            this.btnStatisticsStaff = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnStocker = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconButton = new FontAwesome.Sharp.IconButton();
            this.panelSideMenu.SuspendLayout();
            this.btnReportStatistics.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnReportStatistics);
            this.panelSideMenu.Controls.Add(this.btnStatistics);
            this.panelSideMenu.Controls.Add(this.btnStocker);
            this.panelSideMenu.Controls.Add(this.btnCustomer);
            this.panelSideMenu.Controls.Add(this.btnStaff);
            this.panelSideMenu.Controls.Add(this.btnBill);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 553);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnReportStatistics
            // 
            this.btnReportStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnReportStatistics.Controls.Add(this.btnStatisticsManager);
            this.btnReportStatistics.Controls.Add(this.btnStatisticsStaff);
            this.btnReportStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportStatistics.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportStatistics.Location = new System.Drawing.Point(0, 370);
            this.btnReportStatistics.Name = "btnReportStatistics";
            this.btnReportStatistics.Size = new System.Drawing.Size(250, 82);
            this.btnReportStatistics.TabIndex = 7;
            // 
            // btnStatisticsManager
            // 
            this.btnStatisticsManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatisticsManager.FlatAppearance.BorderSize = 0;
            this.btnStatisticsManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStatisticsManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnStatisticsManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticsManager.Location = new System.Drawing.Point(0, 40);
            this.btnStatisticsManager.Name = "btnStatisticsManager";
            this.btnStatisticsManager.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStatisticsManager.Size = new System.Drawing.Size(250, 40);
            this.btnStatisticsManager.TabIndex = 1;
            this.btnStatisticsManager.Text = "Report statistics of Manager";
            this.btnStatisticsManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatisticsManager.UseVisualStyleBackColor = true;
            this.btnStatisticsManager.Click += new System.EventHandler(this.btnStatisticsManager_Click);
            // 
            // btnStatisticsStaff
            // 
            this.btnStatisticsStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatisticsStaff.FlatAppearance.BorderSize = 0;
            this.btnStatisticsStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStatisticsStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnStatisticsStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticsStaff.Location = new System.Drawing.Point(0, 0);
            this.btnStatisticsStaff.Name = "btnStatisticsStaff";
            this.btnStatisticsStaff.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStatisticsStaff.Size = new System.Drawing.Size(250, 40);
            this.btnStatisticsStaff.TabIndex = 0;
            this.btnStatisticsStaff.Text = "Report statistics of Staff";
            this.btnStatisticsStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatisticsStaff.UseVisualStyleBackColor = true;
            this.btnStatisticsStaff.Click += new System.EventHandler(this.btnStatisticsStaff_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatistics.Location = new System.Drawing.Point(0, 325);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStatistics.Size = new System.Drawing.Size(250, 45);
            this.btnStatistics.TabIndex = 6;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnStocker
            // 
            this.btnStocker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStocker.FlatAppearance.BorderSize = 0;
            this.btnStocker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnStocker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnStocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStocker.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStocker.Location = new System.Drawing.Point(0, 280);
            this.btnStocker.Name = "btnStocker";
            this.btnStocker.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStocker.Size = new System.Drawing.Size(250, 45);
            this.btnStocker.TabIndex = 5;
            this.btnStocker.Text = "Stocker";
            this.btnStocker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStocker.UseVisualStyleBackColor = true;
            this.btnStocker.Click += new System.EventHandler(this.btnStocker_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomer.Location = new System.Drawing.Point(0, 235);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(250, 45);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStaff.Location = new System.Drawing.Point(0, 190);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(250, 45);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnBill
            // 
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBill.Location = new System.Drawing.Point(0, 145);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBill.Size = new System.Drawing.Size(250, 45);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "Bill";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 45);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.iconButton);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(250, 427);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(682, 126);
            this.panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(682, 427);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // iconButton
            // 
            this.iconButton.FlatAppearance.BorderSize = 0;
            this.iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.iconButton.IconColor = System.Drawing.Color.White;
            this.iconButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton.Location = new System.Drawing.Point(12, 23);
            this.iconButton.Name = "iconButton";
            this.iconButton.Size = new System.Drawing.Size(209, 61);
            this.iconButton.TabIndex = 1;
            this.iconButton.Text = "WatchStore";
            this.iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.btnReportStatistics.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel btnReportStatistics;
        private System.Windows.Forms.Button btnStatisticsManager;
        private System.Windows.Forms.Button btnStatisticsStaff;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnStocker;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton iconButton;
    }
}

