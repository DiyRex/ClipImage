namespace ClipImage
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbTypePNG = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbTypeJPG = new Guna.UI2.WinForms.Guna2RadioButton();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Crimson;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(225, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(31, 24);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(76, 55);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(112, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "ClipImage";
            // 
            // txtPath
            // 
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.DefaultText = "";
            this.txtPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.Location = new System.Drawing.Point(21, 134);
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.PlaceholderText = "";
            this.txtPath.ReadOnly = true;
            this.txtPath.SelectedText = "";
            this.txtPath.Size = new System.Drawing.Size(187, 23);
            this.txtPath.TabIndex = 2;
            this.txtPath.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(76, 277);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(128, 35);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Save";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Location = new System.Drawing.Point(214, 134);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Size = new System.Drawing.Size(34, 23);
            this.guna2ImageButton1.TabIndex = 4;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = false;
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(27, 228);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(221, 16);
            this.txtStatus.TabIndex = 5;
            this.txtStatus.Text = "-";
            this.txtStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbTypePNG
            // 
            this.rbTypePNG.AutoSize = true;
            this.rbTypePNG.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTypePNG.CheckedState.BorderThickness = 0;
            this.rbTypePNG.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.rbTypePNG.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbTypePNG.CheckedState.InnerOffset = -4;
            this.rbTypePNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbTypePNG.Location = new System.Drawing.Point(74, 174);
            this.rbTypePNG.Name = "rbTypePNG";
            this.rbTypePNG.Size = new System.Drawing.Size(48, 17);
            this.rbTypePNG.TabIndex = 7;
            this.rbTypePNG.Text = "PNG";
            this.rbTypePNG.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbTypePNG.UncheckedState.BorderThickness = 2;
            this.rbTypePNG.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbTypePNG.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbTypePNG.CheckedChanged += new System.EventHandler(this.rbTypePNG_CheckedChanged);
            // 
            // rbTypeJPG
            // 
            this.rbTypeJPG.AutoSize = true;
            this.rbTypeJPG.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTypeJPG.CheckedState.BorderThickness = 0;
            this.rbTypeJPG.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.rbTypeJPG.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbTypeJPG.CheckedState.InnerOffset = -4;
            this.rbTypeJPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbTypeJPG.Location = new System.Drawing.Point(159, 174);
            this.rbTypeJPG.Name = "rbTypeJPG";
            this.rbTypeJPG.Size = new System.Drawing.Size(45, 17);
            this.rbTypeJPG.TabIndex = 8;
            this.rbTypeJPG.Text = "JPG";
            this.rbTypeJPG.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbTypeJPG.UncheckedState.BorderThickness = 2;
            this.rbTypeJPG.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbTypeJPG.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbTypeJPG.CheckedChanged += new System.EventHandler(this.rbTypeJPG_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 339);
            this.Controls.Add(this.rbTypeJPG);
            this.Controls.Add(this.rbTypePNG);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtPath;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtStatus;
        private Guna.UI2.WinForms.Guna2RadioButton rbTypeJPG;
        private Guna.UI2.WinForms.Guna2RadioButton rbTypePNG;
    }
}

