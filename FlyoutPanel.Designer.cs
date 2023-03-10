namespace Dotnet6WinFormComponents
{
    partial class FlyoutPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlyoutPanel));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picCloseAtHeader = new System.Windows.Forms.PictureBox();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.picCloseAtFooter = new System.Windows.Forms.PictureBox();
            this.ucBody = new Dotnet6WinFormComponents.ControlContainer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseAtHeader)).BeginInit();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseAtFooter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.lblTitle);
            this.pnHeader.Controls.Add(this.picCloseAtHeader);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(10, 10);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(412, 44);
            this.pnHeader.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(368, 44);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picCloseAtHeader
            // 
            this.picCloseAtHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseAtHeader.Dock = System.Windows.Forms.DockStyle.Right;
            this.picCloseAtHeader.Image = ((System.Drawing.Image)(resources.GetObject("picCloseAtHeader.Image")));
            this.picCloseAtHeader.Location = new System.Drawing.Point(368, 0);
            this.picCloseAtHeader.Name = "picCloseAtHeader";
            this.picCloseAtHeader.Size = new System.Drawing.Size(44, 44);
            this.picCloseAtHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCloseAtHeader.TabIndex = 4;
            this.picCloseAtHeader.TabStop = false;
            this.picCloseAtHeader.Click += new System.EventHandler(this.picCloseAtHeader_Click);
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.picCloseAtFooter);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(10, 207);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(412, 44);
            this.pnFooter.TabIndex = 6;
            // 
            // picCloseAtFooter
            // 
            this.picCloseAtFooter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseAtFooter.Dock = System.Windows.Forms.DockStyle.Right;
            this.picCloseAtFooter.Image = ((System.Drawing.Image)(resources.GetObject("picCloseAtFooter.Image")));
            this.picCloseAtFooter.Location = new System.Drawing.Point(368, 0);
            this.picCloseAtFooter.Name = "picCloseAtFooter";
            this.picCloseAtFooter.Size = new System.Drawing.Size(44, 44);
            this.picCloseAtFooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCloseAtFooter.TabIndex = 5;
            this.picCloseAtFooter.TabStop = false;
            this.picCloseAtFooter.Click += new System.EventHandler(this.picCloseAtHeader_Click);
            // 
            // ucBody
            // 
            this.ucBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBody.Location = new System.Drawing.Point(10, 54);
            this.ucBody.Name = "ucBody";
            this.ucBody.Size = new System.Drawing.Size(412, 153);
            this.ucBody.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FlyoutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucBody);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnHeader);
            this.Name = "FlyoutPanel";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(432, 261);
            this.Load += new System.EventHandler(this.FlyoutPanel_Load);
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCloseAtHeader)).EndInit();
            this.pnFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCloseAtFooter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnHeader;
        private Label lblTitle;
        private PictureBox picCloseAtHeader;
        private Panel pnFooter;
        private PictureBox picCloseAtFooter;
        private ControlContainer ucBody;
        private System.Windows.Forms.Timer timer1;
    }
}
