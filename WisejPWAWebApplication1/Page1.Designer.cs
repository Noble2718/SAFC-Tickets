namespace WisejPWAWebApplication1
{
	partial class Page1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            this.panel1 = new Wisej.Web.Panel();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.label2 = new Wisej.Web.Label();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.listBox1 = new Wisej.Web.ListBox();
            this.Refresh = new Wisej.Web.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("default, Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1564, 50);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.pictureBox1.CssStyle = "border-radius:40px";
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1481, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 76);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // label2
            // 
            this.label2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SAFC Ticket Stats";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.listBox1);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(40);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1564, 670);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Transparent;
            this.listBox1.BorderStyle = Wisej.Web.BorderStyle.None;
            this.listBox1.Cursor = Wisej.Web.Cursors.Arrow;
            this.listBox1.Enabled = false;
            this.listBox1.Focusable = false;
            this.listBox1.Font = new System.Drawing.Font("Verdana", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.Items.AddRange(new object[] {
            "Stadium Capacity: ",
            "",
            "Tickets Sold: ",
            "",
            "Tickets Available: ",
            "",
            "Percentage Sold: "});
            this.listBox1.Location = new System.Drawing.Point(43, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = Wisej.Web.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(541, 269);
            this.listBox1.TabIndex = 6;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Refresh
            // 
            this.Refresh.Enabled = true;
            this.Refresh.Tick += new System.EventHandler(this.Refresh_Tick);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1564, 720);
            this.Text = "SAFC Ticket Stats";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panel1;
		private Wisej.Web.PictureBox pictureBox1;
		private Wisej.Web.Label label2;
		private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.Timer Refresh;
        private Wisej.Web.ListBox listBox1;
    }
}

