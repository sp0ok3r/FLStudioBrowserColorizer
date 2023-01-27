namespace FLStudioBrowserColorizer
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
            this.btn_OneFolder = new MetroFramework.Controls.MetroButton();
            this.btn_allfolders = new MetroFramework.Controls.MetroButton();
            this.btn_randomColorsfolders = new MetroFramework.Controls.MetroButton();
            this.chc_firstfoldercolor = new MetroFramework.Controls.MetroCheckBox();
            this.txtbox_hexcode = new MetroFramework.Controls.MetroTextBox();
            this.lbl_setcolormanual = new MetroFramework.Controls.MetroLabel();
            this.apppicbox = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.link_spk = new MetroFramework.Controls.MetroLink();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.apppicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OneFolder
            // 
            this.btn_OneFolder.Location = new System.Drawing.Point(28, 127);
            this.btn_OneFolder.Name = "btn_OneFolder";
            this.btn_OneFolder.TabIndex = 2;
            this.btn_OneFolder.TabStop = false;
            this.btn_OneFolder.Text = "One Folder";
            this.btn_OneFolder.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_OneFolder.UseSelectable = true;
            this.btn_OneFolder.Click += new System.EventHandler(this.btn_OneFolder_Click);
            // 
            // btn_allfolders
            // 
            this.btn_allfolders.Location = new System.Drawing.Point(137, 127);
            this.btn_allfolders.Name = "btn_allfolders";
            this.btn_allfolders.TabIndex = 3;
            this.btn_allfolders.TabStop = false;
            this.btn_allfolders.Text = "All Folders";
            this.btn_allfolders.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_allfolders.UseSelectable = true;
            this.btn_allfolders.Click += new System.EventHandler(this.btn_allfolders_Click);
            // 
            // btn_randomColorsfolders
            // 
            this.btn_randomColorsfolders.Location = new System.Drawing.Point(28, 217);
            this.btn_randomColorsfolders.Name = "btn_randomColorsfolders";
            this.btn_randomColorsfolders.Size = new System.Drawing.Size(255, 23);
            this.btn_randomColorsfolders.TabIndex = 4;
            this.btn_randomColorsfolders.TabStop = false;
            this.btn_randomColorsfolders.Text = "All Folders Random Colors";
            this.btn_randomColorsfolders.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_randomColorsfolders.UseSelectable = true;
            this.btn_randomColorsfolders.UseStyleColors = true;
            this.btn_randomColorsfolders.Click += new System.EventHandler(this.btn_randomColorsfolders_Click);
            // 
            // chc_firstfoldercolor
            // 
            this.chc_firstfoldercolor.AutoSize = true;
            this.chc_firstfoldercolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chc_firstfoldercolor.Location = new System.Drawing.Point(157, 156);
            this.chc_firstfoldercolor.Name = "chc_firstfoldercolor";
            this.chc_firstfoldercolor.Size = new System.Drawing.Size(132, 15);
            this.chc_firstfoldercolor.TabIndex = 0;
            this.chc_firstfoldercolor.TabStop = false;
            this.chc_firstfoldercolor.Text = "Apply to Root Folder";
            this.chc_firstfoldercolor.UseCustomBackColor = true;
            this.chc_firstfoldercolor.UseSelectable = true;
            this.chc_firstfoldercolor.UseStyleColors = true;
            // 
            // txtbox_hexcode
            // 
            this.txtbox_hexcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtbox_hexcode.CustomButton.Image = null;
            this.txtbox_hexcode.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtbox_hexcode.CustomButton.Name = "";
            this.txtbox_hexcode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbox_hexcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbox_hexcode.CustomButton.TabIndex = 1;
            this.txtbox_hexcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbox_hexcode.CustomButton.UseSelectable = true;
            this.txtbox_hexcode.CustomButton.Visible = false;
            this.txtbox_hexcode.Lines = new string[0];
            this.txtbox_hexcode.Location = new System.Drawing.Point(137, 79);
            this.txtbox_hexcode.MaxLength = 6;
            this.txtbox_hexcode.Name = "txtbox_hexcode";
            this.txtbox_hexcode.PasswordChar = '\0';
            this.txtbox_hexcode.PromptText = "XXXXXX";
            this.txtbox_hexcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_hexcode.SelectedText = "";
            this.txtbox_hexcode.SelectionLength = 0;
            this.txtbox_hexcode.SelectionStart = 0;
            this.txtbox_hexcode.ShortcutsEnabled = true;
            this.txtbox_hexcode.Size = new System.Drawing.Size(145, 23);
            this.txtbox_hexcode.TabIndex = 5;
            this.txtbox_hexcode.TabStop = false;
            this.txtbox_hexcode.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.txtbox_hexcode, "LEAVE BLANK, TO SHOW COLOR PICKER");
            this.txtbox_hexcode.UseSelectable = true;
            this.txtbox_hexcode.UseStyleColors = true;
            this.txtbox_hexcode.WaterMark = "XXXXXX";
            this.txtbox_hexcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbox_hexcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_setcolormanual
            // 
            this.lbl_setcolormanual.AutoSize = true;
            this.lbl_setcolormanual.ForeColor = System.Drawing.Color.White;
            this.lbl_setcolormanual.Location = new System.Drawing.Point(134, 58);
            this.lbl_setcolormanual.Name = "lbl_setcolormanual";
            this.lbl_setcolormanual.Size = new System.Drawing.Size(67, 19);
            this.lbl_setcolormanual.TabIndex = 6;
            this.lbl_setcolormanual.Text = "Hex code:";
            this.lbl_setcolormanual.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbl_setcolormanual.UseStyleColors = true;
            // 
            // apppicbox
            // 
            this.apppicbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apppicbox.Image = ((System.Drawing.Image)(resources.GetObject("apppicbox.Image")));
            this.apppicbox.Location = new System.Drawing.Point(28, 58);
            this.apppicbox.Name = "apppicbox";
            this.apppicbox.Size = new System.Drawing.Size(75, 63);
            this.apppicbox.TabIndex = 7;
            this.apppicbox.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.richTextBox1.Location = new System.Drawing.Point(134, 156);
            this.richTextBox1.MaxLength = 50;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(22, 14);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "└───";
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.White;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // link_spk
            // 
            this.link_spk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_spk.ForeColor = System.Drawing.Color.Black;
            this.link_spk.Location = new System.Drawing.Point(241, 243);
            this.link_spk.Name = "link_spk";
            this.link_spk.TabIndex = 10;
            this.link_spk.TabStop = false;
            this.link_spk.Text = "by.sp0ok3r";
            this.link_spk.UseCustomForeColor = true;
            this.link_spk.UseSelectable = true;
            this.link_spk.Click += new System.EventHandler(this.link_spk_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Default;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 263);
            this.Controls.Add(this.link_spk);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.apppicbox);
            this.Controls.Add(this.lbl_setcolormanual);
            this.Controls.Add(this.txtbox_hexcode);
            this.Controls.Add(this.chc_firstfoldercolor);
            this.Controls.Add(this.btn_randomColorsfolders);
            this.Controls.Add(this.btn_allfolders);
            this.Controls.Add(this.btn_OneFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "FLBrowserColorizer";
            ((System.ComponentModel.ISupportInitialize)(this.apppicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_OneFolder;
        private MetroFramework.Controls.MetroButton btn_allfolders;
        private MetroFramework.Controls.MetroButton btn_randomColorsfolders;
        private MetroFramework.Controls.MetroCheckBox chc_firstfoldercolor;
        private MetroFramework.Controls.MetroTextBox txtbox_hexcode;
        private MetroFramework.Controls.MetroLabel lbl_setcolormanual;
        private System.Windows.Forms.PictureBox apppicbox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroLink link_spk;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}

