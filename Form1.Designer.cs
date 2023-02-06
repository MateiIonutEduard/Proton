using Proton.Models;

namespace Proton
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.min = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.close = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.last = new Bunifu.Framework.UI.BunifuFlatButton();
            this.current = new Bunifu.Framework.UI.BunifuFlatButton();
            this.next = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pageDown = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pageUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.movies = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.genres = new System.Windows.Forms.CheckedListBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.movieViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movies)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.min);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 34);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Image = global::Proton.Resources.app_small;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(3, 3);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(38, 28);
            this.bunifuCustomLabel6.TabIndex = 4;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(47, 6);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(77, 24);
            this.bunifuCustomLabel4.TabIndex = 2;
            this.bunifuCustomLabel4.Text = "Proton ";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.min.Location = new System.Drawing.Point(563, 5);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(20, 25);
            this.min.TabIndex = 1;
            this.min.Text = "-";
            this.min.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            this.min.MouseLeave += new System.EventHandler(this.min_MouseLeave);
            this.min.MouseHover += new System.EventHandler(this.bunifuCustomLabel3_MouseHover_1);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.close.Location = new System.Drawing.Point(589, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 24);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.bunifuCustomLabel3_MouseHover);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(99)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 44);
            this.panel2.TabIndex = 1;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.bunifuFlatButton2.BackgroundImage = global::Proton.Resources.search;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton2.BorderRadius = 5;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(582, 7);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(32, 32);
            this.bunifuFlatButton2.TabIndex = 3;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.SearchClick);
            // 
            // name
            // 
            this.name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.name.BackColor = System.Drawing.Color.White;
            this.name.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name.HintText = "Search";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.Blue;
            this.name.LineIdleColor = System.Drawing.Color.Gray;
            this.name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.name.LineThickness = 3;
            this.name.Location = new System.Drawing.Point(428, 7);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(146, 33);
            this.name.TabIndex = 2;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(321, 12);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(56, 20);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Home";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 20);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Photon";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.last);
            this.panel4.Controls.Add(this.current);
            this.panel4.Controls.Add(this.next);
            this.panel4.Controls.Add(this.pageDown);
            this.panel4.Controls.Add(this.pageUp);
            this.panel4.Controls.Add(this.movies);
            this.panel4.Controls.Add(this.bunifuCustomLabel3);
            this.panel4.Controls.Add(this.bunifuSeparator1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(622, 430);
            this.panel4.TabIndex = 3;
            // 
            // last
            // 
            this.last.Active = false;
            this.last.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(219)))));
            this.last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.last.BorderRadius = 0;
            this.last.ButtonText = "1";
            this.last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.last.DisabledColor = System.Drawing.Color.Gray;
            this.last.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.last.Iconcolor = System.Drawing.Color.Transparent;
            this.last.Iconimage = null;
            this.last.Iconimage_right = null;
            this.last.Iconimage_right_Selected = null;
            this.last.Iconimage_Selected = null;
            this.last.IconMarginLeft = 0;
            this.last.IconMarginRight = 0;
            this.last.IconRightVisible = true;
            this.last.IconRightZoom = 0D;
            this.last.IconVisible = true;
            this.last.IconZoom = 90D;
            this.last.IsTab = false;
            this.last.Location = new System.Drawing.Point(463, 371);
            this.last.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.last.Name = "last";
            this.last.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(219)))));
            this.last.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.last.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.last.selected = false;
            this.last.Size = new System.Drawing.Size(31, 28);
            this.last.TabIndex = 10;
            this.last.Text = "1";
            this.last.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.last.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.last.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // current
            // 
            this.current.Active = false;
            this.current.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(219)))));
            this.current.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.current.BorderRadius = 0;
            this.current.ButtonText = "1";
            this.current.Cursor = System.Windows.Forms.Cursors.Hand;
            this.current.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(219)))));
            this.current.Enabled = false;
            this.current.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(69)))), ((int)(((byte)(53)))));
            this.current.Iconcolor = System.Drawing.Color.Transparent;
            this.current.Iconimage = null;
            this.current.Iconimage_right = null;
            this.current.Iconimage_right_Selected = null;
            this.current.Iconimage_Selected = null;
            this.current.IconMarginLeft = 0;
            this.current.IconMarginRight = 0;
            this.current.IconRightVisible = true;
            this.current.IconRightZoom = 0D;
            this.current.IconVisible = true;
            this.current.IconZoom = 90D;
            this.current.IsTab = false;
            this.current.Location = new System.Drawing.Point(502, 371);
            this.current.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.current.Name = "current";
            this.current.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(219)))));
            this.current.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.current.OnHoverTextColor = System.Drawing.Color.White;
            this.current.selected = false;
            this.current.Size = new System.Drawing.Size(33, 28);
            this.current.TabIndex = 9;
            this.current.Text = "1";
            this.current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.current.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(69)))), ((int)(((byte)(53)))));
            this.current.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // next
            // 
            this.next.Active = false;
            this.next.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(219)))));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.BorderRadius = 0;
            this.next.ButtonText = "1";
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.DisabledColor = System.Drawing.Color.Gray;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.next.Iconcolor = System.Drawing.Color.Transparent;
            this.next.Iconimage = null;
            this.next.Iconimage_right = null;
            this.next.Iconimage_right_Selected = null;
            this.next.Iconimage_Selected = null;
            this.next.IconMarginLeft = 0;
            this.next.IconMarginRight = 0;
            this.next.IconRightVisible = true;
            this.next.IconRightZoom = 0D;
            this.next.IconVisible = true;
            this.next.IconZoom = 90D;
            this.next.IsTab = false;
            this.next.Location = new System.Drawing.Point(542, 371);
            this.next.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.next.Name = "next";
            this.next.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(219)))));
            this.next.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.next.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.next.selected = false;
            this.next.Size = new System.Drawing.Size(29, 28);
            this.next.TabIndex = 8;
            this.next.Text = "1";
            this.next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.next.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.next.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pageDown
            // 
            this.pageDown.Active = false;
            this.pageDown.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.pageDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(219)))));
            this.pageDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pageDown.BorderRadius = 0;
            this.pageDown.ButtonText = ">>";
            this.pageDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pageDown.DisabledColor = System.Drawing.Color.Gray;
            this.pageDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.pageDown.Iconcolor = System.Drawing.Color.Transparent;
            this.pageDown.Iconimage = null;
            this.pageDown.Iconimage_right = null;
            this.pageDown.Iconimage_right_Selected = null;
            this.pageDown.Iconimage_Selected = null;
            this.pageDown.IconMarginLeft = 0;
            this.pageDown.IconMarginRight = 0;
            this.pageDown.IconRightVisible = true;
            this.pageDown.IconRightZoom = 0D;
            this.pageDown.IconVisible = true;
            this.pageDown.IconZoom = 90D;
            this.pageDown.IsTab = false;
            this.pageDown.Location = new System.Drawing.Point(581, 371);
            this.pageDown.Name = "pageDown";
            this.pageDown.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(219)))));
            this.pageDown.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.pageDown.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.pageDown.selected = false;
            this.pageDown.Size = new System.Drawing.Size(34, 28);
            this.pageDown.TabIndex = 4;
            this.pageDown.Text = ">>";
            this.pageDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pageDown.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.pageDown.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageDown.Click += new System.EventHandler(this.pageDown_ClickAsync);
            // 
            // pageUp
            // 
            this.pageUp.Active = false;
            this.pageUp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.pageUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(219)))));
            this.pageUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pageUp.BorderRadius = 0;
            this.pageUp.ButtonText = "<<";
            this.pageUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pageUp.DisabledColor = System.Drawing.Color.Gray;
            this.pageUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.pageUp.Iconcolor = System.Drawing.Color.Transparent;
            this.pageUp.Iconimage = null;
            this.pageUp.Iconimage_right = null;
            this.pageUp.Iconimage_right_Selected = null;
            this.pageUp.Iconimage_Selected = null;
            this.pageUp.IconMarginLeft = 0;
            this.pageUp.IconMarginRight = 0;
            this.pageUp.IconRightVisible = true;
            this.pageUp.IconRightZoom = 0D;
            this.pageUp.IconVisible = true;
            this.pageUp.IconZoom = 90D;
            this.pageUp.IsTab = false;
            this.pageUp.Location = new System.Drawing.Point(422, 371);
            this.pageUp.Name = "pageUp";
            this.pageUp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(219)))));
            this.pageUp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.pageUp.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.pageUp.selected = false;
            this.pageUp.Size = new System.Drawing.Size(34, 28);
            this.pageUp.TabIndex = 3;
            this.pageUp.Text = "<<";
            this.pageUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pageUp.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.pageUp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageUp.Click += new System.EventHandler(this.pageUp_Click);
            // 
            // movies
            // 
            this.movies.AllowUserToAddRows = false;
            this.movies.AllowUserToDeleteRows = false;
            this.movies.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(99)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.movies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.movies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.movies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(99)))), ((int)(((byte)(173)))));
            this.movies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.movies.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.movies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(99)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(99)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.movies.DefaultCellStyle = dataGridViewCellStyle3;
            this.movies.DoubleBuffered = true;
            this.movies.EnableHeadersVisualStyles = false;
            this.movies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.movies.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(99)))), ((int)(((byte)(173)))));
            this.movies.HeaderForeColor = System.Drawing.Color.White;
            this.movies.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.movies.Location = new System.Drawing.Point(163, 66);
            this.movies.Name = "movies";
            this.movies.ReadOnly = true;
            this.movies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(99)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movies.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(99)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.movies.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.movies.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(99)))), ((int)(((byte)(173)))));
            this.movies.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.movies.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            this.movies.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.movies.RowTemplate.Height = 32;
            this.movies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.movies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movies.Size = new System.Drawing.Size(451, 299);
            this.movies.TabIndex = 2;
            this.movies.DoubleClick += new System.EventHandler(this.movies_DoubleClick);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(163, 16);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(126, 20);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "Home / Movies";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(163, 25);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(451, 35);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.genres);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(99)))), ((int)(((byte)(173)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(99)))), ((int)(((byte)(173)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 78);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(157, 430);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // genres
            // 
            this.genres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(146)))), ((int)(((byte)(241)))));
            this.genres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genres.CheckOnClick = true;
            this.genres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genres.FormattingEnabled = true;
            this.genres.Location = new System.Drawing.Point(16, 43);
            this.genres.Margin = new System.Windows.Forms.Padding(0);
            this.genres.MultiColumn = true;
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(116, 294);
            this.genres.TabIndex = 3;
            this.genres.UseCompatibleTextRendering = true;
            this.genres.SelectedIndexChanged += new System.EventHandler(this.genres_SelectedIndexChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(99)))), ((int)(((byte)(114)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(33, 16);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(78, 24);
            this.bunifuCustomLabel5.TabIndex = 2;
            this.bunifuCustomLabel5.Text = "Genres";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton1.ButtonText = "Search";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(16, 366);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(116, 34);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "Search";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.SearchClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 508);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proton";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movies)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel close;
        private Bunifu.Framework.UI.BunifuCustomLabel min;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.CheckedListBox genres;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.BindingSource movieViewBindingSource;
        private Bunifu.Framework.UI.BunifuCustomDataGrid movies;
        private Bunifu.Framework.UI.BunifuFlatButton pageDown;
        private Bunifu.Framework.UI.BunifuFlatButton pageUp;
        private System.Windows.Forms.DataGridViewImageColumn captureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn watchDataGridButtonColumn;
        private Bunifu.Framework.UI.BunifuFlatButton last;
        private Bunifu.Framework.UI.BunifuFlatButton current;
        private Bunifu.Framework.UI.BunifuFlatButton next;
    }
}

